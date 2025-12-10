using System;
using System.Windows.Forms;
using ZadachaVadim.Forms;
using ZadachaVadim.Services;

namespace ZadachaVadim
{
    public partial class Form1 : Form
    {
        private DataManager _dataManager; // Менеджер данных
        private Form _activeForm; // Текущая форма

        public Form1()
        {
            InitializeComponent();
            _dataManager = new DataManager(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dataManager.LoadData();

            ShowForm(new RepairForm(_dataManager));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dataManager.SaveData();
        }

        private void ShowForm(Form formToShow)
        {
            if (_activeForm != null)
            {
                _activeForm.Hide(); 
                //_activeForm.Close(); 
            }

            _activeForm = formToShow;
            _activeForm.TopLevel = false; 
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            _activeForm.Dock = DockStyle.Fill; 

            pageContent.Controls.Clear(); 
            pageContent.Controls.Add(_activeForm); 
            _activeForm.Show(); 
            _activeForm.BringToFront(); 
        }

        private void openRepairOrderForm_Click(object sender, EventArgs e)
        {
            ShowForm(new RepairForm(_dataManager));
        }

        private void openMechanicsForm_Click(object sender, EventArgs e)
        {
            ShowForm(new MechanicsForm(_dataManager));
        }

        private void openReportForm_Click(object sender, EventArgs e)
        {
            ShowForm(new ReportForm(_dataManager));
        }
    }
}
