using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZadachaVadim.Models;
using ZadachaVadim.Services;

namespace ZadachaVadim.Forms
{
    public partial class RepairForm : Form
    {
        private DataManager _dataManager;

        public RepairForm(DataManager dataManager)
        {
            InitializeComponent();

            _dataManager = dataManager;

            Load += RepairForm_Load;
            dataGridView.AutoGenerateColumns = false;

            dataGridView.CellFormatting += dataGridView_CellFormatting;
        }

        private void RepairForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadMechanicsSelect();
        }

        /// <summary>
        /// Загружает механиков для выбора
        /// </summary>
        private void LoadMechanicsSelect()
        {
            // Получаем только доступных механиков
            var availableMechanics = _dataManager.GetAllMechanics().Where(m => m.IsAvailable).ToList();

            mechanicSelect.DisplayMember = "Name"; 
            mechanicSelect.ValueMember = "Id"; 
            mechanicSelect.DataSource = availableMechanics;

            // Если список пуст, отображаем подсказку
            if (availableMechanics.Count == 0)
            {
                mechanicSelect.Text = "Нет свободных механиков";
            }
            else
            {
                mechanicSelect.SelectedIndex = -1; 
            }
        }

        /// <summary>
        /// Обновляет DataGridView.
        /// </summary>
        private void LoadGrid()
        {
            dataGridView.DataSource = onlyActiveCheckbox.Checked ? _dataManager.GetActiveRepairOrders() : _dataManager.GetAllRepairOrders();
            dataGridView.Refresh();
        }

        /// <summary>
        /// Очищает все поля ввода
        /// </summary>
        private void ClearTextBoxes() {
            mechanicSelect.SelectedValue = -1;
            clientNameTextBox.Clear();
            clientPhoneTextBox.Clear();
            carInfoTextBox.Clear();
            problemDescriptionTextBox.Clear();
            totalCostTextBox.Clear();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            // Проверяем, что выбран механик
            if (mechanicSelect.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, выберите механика для заказа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int mechanicId = (int)mechanicSelect.SelectedValue; 
            string clientName = clientNameTextBox.Text;
            string clientPhone = clientPhoneTextBox.Text;
            string carInfo = carInfoTextBox.Text;
            string problemDescription = problemDescriptionTextBox.Text;
            decimal totalCost = Convert.ToDecimal(totalCostTextBox.Text);

            if (string.IsNullOrWhiteSpace(clientName) || 
                string.IsNullOrWhiteSpace(clientPhone) || 
                string.IsNullOrWhiteSpace(carInfo) || 
                string.IsNullOrWhiteSpace(problemDescription) || 
                string.IsNullOrWhiteSpace(totalCostTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newRepairOrder = _dataManager.AddRepairOrder(new RepairOrder { 
                ClientName = clientName, 
                ClientPhone = clientPhone, 
                CarInfo = carInfo, 
                AssignedMechanic = _dataManager.GetMechanicByID(mechanicId),
                ProblemDescription = problemDescription,
                TotalCost = totalCost,
                Status = Models.OrderStatus.Active,
                OrderDate = DateTime.Now,
            });

            MessageBox.Show($"Запись успешно добавлена! ID: {newRepairOrder.Id}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поля ввода
            ClearTextBoxes();

            // Обновляем таблицу и список доступных механиков
            LoadGrid();
            LoadMechanicsSelect();
        }

        private void completeOrderButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedOrder = dataGridView.SelectedRows[0].DataBoundItem as RepairOrder;

            bool isSuccess = _dataManager.CompleteRepairOrder(selectedOrder.Id);

            if (isSuccess)
            {
                MessageBox.Show($"Заказ {selectedOrder.Id} успешно завершен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Обновляем таблицу и список доступных механиков
                LoadGrid();
                LoadMechanicsSelect();
            }
            else
            {
                MessageBox.Show("Не удалось завершить заказ", "Ошибка возврата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onlyActiveCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            LoadGrid();
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
