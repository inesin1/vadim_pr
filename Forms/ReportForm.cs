using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
using System.Globalization;
using ZadachaVadim.Services;
using ZadachaVadim.Models;

namespace ZadachaVadim
{
    public partial class ReportForm : Form
    {
        private DataManager _dataManager;
        private List<RepairOrder> _reportList = new List<RepairOrder>();

        public ReportForm(DataManager dataManager)
        {
            InitializeComponent();
            _dataManager = dataManager;

            dataGridView.AutoGenerateColumns = false;

            LoadMechanicsSelect();
            RefreshData();

            dataGridView.CellFormatting += dataGridView_CellFormatting;
        }

        /// <summary>
        /// Загружает механиков для выбора
        /// </summary>
        private void LoadMechanicsSelect()
        {
            // Получаем всех механиков
            var mechanics = _dataManager.GetAllMechanics();

            mechanicSelect.DisplayMember = "Name";
            mechanicSelect.ValueMember = "Id";
            mechanicSelect.DataSource = mechanics;

            mechanicSelect.SelectedIndex = -1;
        }

        /// <summary>
        /// Обновляет данные в таблице
        /// </summary>
        private void RefreshData() {
            dataGridView.DataSource = _reportList;
            dataGridView.Refresh();
            CalculateResults();
        }

        /// <summary>
        /// Рассчитывает итоги
        /// </summary>
        private void CalculateResults()
        {
            // Расчет общей выручки
            decimal totalCost = _reportList.Sum(order => order.TotalCost); 
            totalCostLabel.Text = totalCost.ToString("C"); 

            // Количество активных заказов
            activeOrdersLabel.Text = _reportList.Where(order => order.Status == OrderStatus.Active).ToList().Count.ToString();

            // Количество завершенных заказов
            completedOrdersLabel.Text = _reportList.Where(order => order.Status == OrderStatus.Completed).ToList().Count.ToString();

            // Общее количество всех заказов
            totalOrdersLabel.Text = _reportList.Count.ToString();
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            // Получаем фильтры
            var mechanic = mechanicSelect.SelectedItem as AutoMechanic;
            DateTime dateFrom = dateFromSelect.Value.Date;
            DateTime dateTo = dateToSelect.Value.AddDays(1).Date;

            // Формируем отчёт
            _reportList = _dataManager.GetAllRepairOrders()
                .Where(order => order.OrderDate >= dateFrom && order.OrderDate <= dateTo)
                .ToList();

            if (mechanic != null) {
                _reportList = _reportList.Where(order => order.AssignedMechanic.Id == mechanic.Id).ToList();
            }

            RefreshData();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Текстовые файлы (*.txt)|*.txt|CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
                sfd.FileName = $"ordersReport_{DateTime.Now.Ticks}.txt"; 

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var reportLines = new List<string>();

                        // Заголовок
                        reportLines.Add("ID заказа|Авто|Имя клиента|Телефон клиента|Описание проблемы|Имя механика|Дата заказа|Дата завершения|Статус|Стоимость");

                        foreach (var order in _reportList)
                        {
                            string completionDate = order.CompletionDate.HasValue ? order.CompletionDate.Value.ToString("O") : "";
                            string mechanicName = order.AssignedMechanic.Name;

                            reportLines.Add($"{order.Id}|{order.CarInfo}|{order.ClientName}|{order.ClientPhone}|{order.ProblemDescription}|{mechanicName}|{order.OrderDate.ToString("O")}|{completionDate}|{(int)order.Status}|{order.TotalCost}");
                        }
                        File.WriteAllLines(sfd.FileName, reportLines, Encoding.UTF8); 
                        MessageBox.Show("Данные успешно экспортированы!", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при экспорте данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            mechanicSelect.SelectedIndex = -1;
        }


        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Подставляем статус
            if (dataGridView.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                RepairOrder order = dataGridView.Rows[e.RowIndex].DataBoundItem as RepairOrder;

                // Устанавливаем значение для отображения
                e.Value = order.Status == OrderStatus.Active ? "В работе" : "Завершен";
                e.FormattingApplied = true;
            }
        }
    }
}


