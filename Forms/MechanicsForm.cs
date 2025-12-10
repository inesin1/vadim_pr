using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZadachaVadim.Models;
using ZadachaVadim.Services;

namespace ZadachaVadim.Forms
{
    public partial class MechanicsForm : Form
    {
        private DataManager _dataManager;

        public MechanicsForm(DataManager dataManager)
        {
            InitializeComponent();

            _dataManager = dataManager;


            // Обрабатываем событие изменения выбора в DataGridView
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;

            // Отключаем генерацию столбцов
            dataGridView.AutoGenerateColumns = false;

            Shown += MechanicForm_Shown;

            dataGridView.CellFormatting += dataGridView_CellFormatting;
        }

        private void MechanicForm_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _dataManager.GetAllMechanics();
            dataGridView.Refresh();
        }

        private void addMechanicButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поле 'Имя'", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newMechanic = new AutoMechanic {
                Id = 0,
                Name = nameTextBox.Text.Trim(),
                IsAvailable = isAvailableCheckbox.Checked
            };

            _dataManager.AddMechanic(newMechanic);

            MessageBox.Show($"Механик '{newMechanic.Name}' (ID: {newMechanic.Id}) успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nameTextBox.Clear();

            RefreshData(); // Обновляем DataGridView
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                AutoMechanic selectedItem = selectedRow.DataBoundItem as AutoMechanic;

                if (selectedItem != null)
                {
                    nameTextBox.Text = selectedItem.Name;
                    isAvailableCheckbox.Checked = selectedItem.IsAvailable;
                }
            }
            else
            {
                nameTextBox.Clear();
                isAvailableCheckbox.Checked = true;
            }
        }

        private void editMechanicButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите элемент для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            AutoMechanic selectedMechanic = selectedRow.DataBoundItem as AutoMechanic;

            if (selectedMechanic == null)
            {
                MessageBox.Show("Не удалось получить данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(nameTextBox.Text) )
            {
                MessageBox.Show("Пожалуйста, заполните поле 'Имя'", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var updatedMechanic = new AutoMechanic
            {
                Id = selectedMechanic.Id,
                Name = nameTextBox.Text.Trim(),
                IsAvailable = isAvailableCheckbox.Checked
            };

            bool success = _dataManager.UpdateMechanic(updatedMechanic);

            if (success)
            {
                MessageBox.Show($"Механик '{updatedMechanic.Name}' (ID: {updatedMechanic.Id}) успешно обновлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();        
            }
            else
            {
                MessageBox.Show("Не удалось обновить элемент. Возможно, он был удален или ID не найден.", "Ошибка обновления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteMechanicButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите элемент для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            AutoMechanic itemToDelete = selectedRow.DataBoundItem as AutoMechanic;

            if (itemToDelete == null)
            {
                MessageBox.Show("Не удалось получить данные выбранного элемента для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                $"Вы уверены, что хотите удалить механика '{itemToDelete.Name}' (ID: {itemToDelete.Id})?\n" +
                "Если у него есть активные заказы, его нельзя будет удалить.",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                bool success = _dataManager.DeleteMechanic(itemToDelete.Id);

                if (success)
                {
                    MessageBox.Show($"Механик '{itemToDelete.Name}' (ID: {itemToDelete.Id}) успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData(); // Обновляем DataGridView
                }
                else
                {
                    MessageBox.Show("Не удалось удалить элемент. Возможно у него есть активные заказы", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Подставляем вместо True/False в столбец Активен Да/Нет
            if (dataGridView.Columns[e.ColumnIndex].Name == "IsAvailable" && e.RowIndex >= 0)
            {
                // Получаем объект строки данных
                AutoMechanic mechanic = dataGridView.Rows[e.RowIndex].DataBoundItem as AutoMechanic;

                // Устанавливаем значение для отображения
                e.Value = mechanic.IsAvailable ? "Да" : "Нет";
                e.FormattingApplied = true; 
            }
        }
    }
}
