using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadachaVadim.Models;

namespace ZadachaVadim.Services
{
    public class DataManager
    {
        private List<AutoMechanic> _mechanicList = new List<AutoMechanic>();
        private Queue<RepairOrder> _repairOrderQueue = new Queue<RepairOrder>();

        // Счетчики id
        private int _nextMechanicId = 1;
        private int _nextRepairOrderId = 1;

        // Автомеханики

        public void AddMechanic(AutoMechanic newMechanic)
        {
            newMechanic.Id = _nextMechanicId++;
            _mechanicList.Add(newMechanic);
        }

        public AutoMechanic GetMechanicByID(int id)
        {
            return _mechanicList.FirstOrDefault(m => m.Id == id);
        }

        public List<AutoMechanic> GetAllMechanics()
        {
            return new List<AutoMechanic>(_mechanicList);
        }

        public bool UpdateMechanic(AutoMechanic updatedMechanic)
        {
            var existingMechanic = _mechanicList.FirstOrDefault(m => m.Id == updatedMechanic.Id);
            if (existingMechanic != null)
            {
                existingMechanic.Name = updatedMechanic.Name;
                existingMechanic.IsAvailable = updatedMechanic.IsAvailable;
                return true;
            }
            return false;
        }

        public bool DeleteMechanic(int id)
        {
            var mechanicToRemove = _mechanicList.FirstOrDefault(m => m.Id == id);
            if (mechanicToRemove != null)
            {
                // Проверка: нельзя удалить механика, если у него есть активные заказы
                if (_repairOrderQueue.Any(o => o.AssignedMechanic?.Id == id && o.Status == OrderStatus.Active))
                {
                    Console.WriteLine($"Ошибка: Механик с ID {id} имеет активные заказы и не может быть удален.");
                    return false;
                }
                _mechanicList.Remove(mechanicToRemove);
                return true;
            }
            return false;
        }

        // Очередь на ремонт

        public RepairOrder AddRepairOrder(RepairOrder newOrder)
        {
            newOrder.Id = _nextRepairOrderId++;
            _repairOrderQueue.Enqueue(newOrder);
            return newOrder;
        }

        public RepairOrder GetRepairOrderByID(int id)
        {
            return _repairOrderQueue.FirstOrDefault(o => o.Id == id);
        }

        public List<RepairOrder> GetAllRepairOrders()
        {
            return new List<RepairOrder>(_repairOrderQueue);
        }

        public List<RepairOrder> GetActiveRepairOrders()
        {
            return _repairOrderQueue.Where(order => order.Status == OrderStatus.Active).ToList();
        }

        public bool UpdateRepairOrder(RepairOrder updatedOrder)
        {
            // Для обновления заказа нужно пересоздать очередь
            var orders = _repairOrderQueue.ToList();
            var existingOrder = orders.FirstOrDefault(o => o.Id == updatedOrder.Id);

            if (existingOrder != null)
            {
                existingOrder.CarInfo = updatedOrder.CarInfo;
                existingOrder.ClientName = updatedOrder.ClientName;
                existingOrder.ClientPhone = updatedOrder.ClientPhone;
                existingOrder.ProblemDescription = updatedOrder.ProblemDescription;
                existingOrder.AssignedMechanic = updatedOrder.AssignedMechanic;
                existingOrder.OrderDate = updatedOrder.OrderDate;
                existingOrder.CompletionDate = updatedOrder.CompletionDate;
                existingOrder.Status = updatedOrder.Status;
                existingOrder.TotalCost = updatedOrder.TotalCost;

                // Пересоздаем очередь
                _repairOrderQueue = new Queue<RepairOrder>(orders);
                return true;
            }
            return false;
        }

        public bool DeleteRepairOrder(int id)
        {
            var orders = _repairOrderQueue.ToList();
            var orderToRemove = orders.FirstOrDefault(o => o.Id == id);

            if (orderToRemove != null)
            {
                // Проверка на активный заказ
                if (orderToRemove.Status == OrderStatus.Active)
                {
                    Console.WriteLine($"Ошибка: Активный заказ с ID {id} не может быть удален.");
                    return false;
                }

                orders.Remove(orderToRemove);
                _repairOrderQueue = new Queue<RepairOrder>(orders);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Назначает механика на заказ.
        /// </summary>
        public bool AssignMechanicToOrder(int orderId, int mechanicId)
        {
            var order = GetRepairOrderByID(orderId);
            var mechanic = GetMechanicByID(mechanicId);

            if (order == null || mechanic == null)
            {
                Console.WriteLine("Ошибка: Заказ или механик не найдены.");
                return false;
            }

            if (!mechanic.IsAvailable)
            {
                Console.WriteLine($"Ошибка: Механик {mechanic.Name} недоступен.");
                return false;
            }

            order.AssignedMechanic = mechanic;
            order.Status = OrderStatus.Active;
            mechanic.IsAvailable = false;

            UpdateRepairOrder(order);
            UpdateMechanic(mechanic);

            Console.WriteLine($"Механик {mechanic.Name} назначен на заказ {orderId}");
            return true;
        }

        /// <summary>
        /// Завершает заказ
        /// </summary>
        public bool CompleteRepairOrder(int orderId)
        {
            var order = GetRepairOrderByID(orderId);
            if (order == null)
            {
                Console.WriteLine($"Ошибка: Заказ с ID {orderId} не найден");
                return false;
            }

            order.CompletionDate = DateTime.Now;
            order.Status = OrderStatus.Completed;

            // Освобождаем механика
            order.AssignedMechanic.IsAvailable = true;
            UpdateMechanic(order.AssignedMechanic);
            UpdateRepairOrder(order);

            Console.WriteLine($"Заказ {orderId} завершен");
            return true;
        }

        public void SaveData()
        {
            // Сохранение механиков
            try
            {
                var mechanicLines = new List<string>();
                foreach (var mechanic in _mechanicList)
                {
                    mechanicLines.Add($"{mechanic.Id}|{mechanic.Name}|{mechanic.IsAvailable}");
                }
                File.WriteAllLines("mechanics.txt", mechanicLines);
                Console.WriteLine("Данные механиков сохранены в mechanics.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении данных механиков: {ex.Message}");
            }

            // Сохранение заказов
            try
            {
                var orderLines = new List<string>();
                foreach (var order in _repairOrderQueue)
                {
                    string completionDate = order.CompletionDate.HasValue ? order.CompletionDate.Value.ToString("O") : "";
                    int mechanicId = order.AssignedMechanic.Id;

                    orderLines.Add($"{order.Id}|{order.CarInfo}|{order.ClientName}|{order.ClientPhone}|{order.ProblemDescription}|{mechanicId}|{order.OrderDate.ToString("O")}|{completionDate}|{(int)order.Status}|{order.TotalCost}");
                }
                File.WriteAllLines("repair_orders.txt", orderLines);
                Console.WriteLine("Данные заказов сохранены в repair_orders.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении данных заказов: {ex.Message}");
            }
        }

        public void LoadData()
        {
            _mechanicList.Clear();
            _repairOrderQueue.Clear();

            // Загрузка механиков
            int maxMechanicId = 0;
            try
            {
                if (!File.Exists("mechanics.txt")) return;

                var mechanicLines = File.ReadAllLines("mechanics.txt");
                foreach (var line in mechanicLines)
                {
                    var parts = line.Split('|');
                    var mechanic = new AutoMechanic
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        IsAvailable = bool.Parse(parts[2]),
                    };
                    _mechanicList.Add(mechanic);
                    if (mechanic.Id > maxMechanicId) maxMechanicId = mechanic.Id;
                }

                Console.WriteLine("Данные механиков загружены из mechanics.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных механиков: {ex.Message}");
                _mechanicList.Clear();
            }
            _nextMechanicId = maxMechanicId + 1;

            // Загрузка заказов
            int maxOrderId = 0;
            try
            {
                if (!File.Exists("repair_orders.txt")) return;

                var orderLines = File.ReadAllLines("repair_orders.txt");
                var orders = new List<RepairOrder>();

                foreach (var line in orderLines)
                {
                    var parts = line.Split('|');
                    var order = new RepairOrder
                    {
                        Id = int.Parse(parts[0]),
                        CarInfo = parts[1],
                        ClientName = parts[2],
                        ClientPhone = parts[3],
                        ProblemDescription = parts[4],
                        AssignedMechanic = GetMechanicByID(Convert.ToInt32(parts[5])),
                        OrderDate = DateTime.ParseExact(parts[6], "O", CultureInfo.InvariantCulture),
                        Status = (OrderStatus)int.Parse(parts[8]),
                        TotalCost = decimal.Parse(parts[9])
                    };

                    // Дата завершения
                    if (!string.IsNullOrEmpty(parts[7]))
                    {
                        order.CompletionDate = DateTime.ParseExact(parts[7], "O", CultureInfo.InvariantCulture);
                    }

                    orders.Add(order);
                    if (order.Id > maxOrderId) maxOrderId = order.Id;
                }

                // Восстанавливаем очередь
                _repairOrderQueue = new Queue<RepairOrder>(orders);
                Console.WriteLine("Данные заказов загружены из repair_orders.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных заказов: {ex.Message}");
                _repairOrderQueue.Clear();
            }
            _nextRepairOrderId = maxOrderId + 1;
        }
    }
}
