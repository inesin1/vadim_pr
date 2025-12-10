namespace ZadachaVadim
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalOrdersLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.completedOrdersLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.activeOrdersLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateToSelect = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFromSelect = new System.Windows.Forms.DateTimePicker();
            this.mechanicSelect = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.formReportButton = new System.Windows.Forms.Button();
            this.mechanicLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedMechanic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProblemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalOrdersLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.completedOrdersLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.activeOrdersLabel);
            this.groupBox1.Controls.Add(this.totalCostLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 386);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(263, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Итого";
            // 
            // totalOrdersLabel
            // 
            this.totalOrdersLabel.AutoSize = true;
            this.totalOrdersLabel.Location = new System.Drawing.Point(170, 43);
            this.totalOrdersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalOrdersLabel.Name = "totalOrdersLabel";
            this.totalOrdersLabel.Size = new System.Drawing.Size(35, 13);
            this.totalOrdersLabel.TabIndex = 12;
            this.totalOrdersLabel.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Всего заказов";
            // 
            // completedOrdersLabel
            // 
            this.completedOrdersLabel.AutoSize = true;
            this.completedOrdersLabel.Location = new System.Drawing.Point(170, 83);
            this.completedOrdersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.completedOrdersLabel.Name = "completedOrdersLabel";
            this.completedOrdersLabel.Size = new System.Drawing.Size(35, 13);
            this.completedOrdersLabel.TabIndex = 10;
            this.completedOrdersLabel.Text = "label4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Всего завершенных заказов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Всего активных заказов";
            // 
            // activeOrdersLabel
            // 
            this.activeOrdersLabel.AutoSize = true;
            this.activeOrdersLabel.Location = new System.Drawing.Point(170, 63);
            this.activeOrdersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activeOrdersLabel.Name = "activeOrdersLabel";
            this.activeOrdersLabel.Size = new System.Drawing.Size(35, 13);
            this.activeOrdersLabel.TabIndex = 4;
            this.activeOrdersLabel.Text = "label1";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(170, 21);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(35, 13);
            this.totalCostLabel.TabIndex = 2;
            this.totalCostLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общая выручка:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearFilterButton);
            this.groupBox2.Controls.Add(this.dateToSelect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateFromSelect);
            this.groupBox2.Controls.Add(this.mechanicSelect);
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Controls.Add(this.formReportButton);
            this.groupBox2.Controls.Add(this.mechanicLabel);
            this.groupBox2.Location = new System.Drawing.Point(8, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(835, 357);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отчёт по ремонтам";
            // 
            // dateToSelect
            // 
            this.dateToSelect.Location = new System.Drawing.Point(356, 45);
            this.dateToSelect.Name = "dateToSelect";
            this.dateToSelect.Size = new System.Drawing.Size(154, 20);
            this.dateToSelect.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Диапазон дат";
            // 
            // dateFromSelect
            // 
            this.dateFromSelect.Location = new System.Drawing.Point(193, 45);
            this.dateFromSelect.Name = "dateFromSelect";
            this.dateFromSelect.Size = new System.Drawing.Size(157, 20);
            this.dateFromSelect.TabIndex = 18;
            // 
            // mechanicSelect
            // 
            this.mechanicSelect.FormattingEnabled = true;
            this.mechanicSelect.Location = new System.Drawing.Point(15, 45);
            this.mechanicSelect.Name = "mechanicSelect";
            this.mechanicSelect.Size = new System.Drawing.Size(151, 21);
            this.mechanicSelect.TabIndex = 17;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.AssignedMechanic,
            this.CarInfo,
            this.ProblemDescription,
            this.ClientName,
            this.ClientPhone,
            this.Status,
            this.OrderDate,
            this.CompletionDate});
            this.dataGridView.Location = new System.Drawing.Point(15, 71);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(759, 262);
            this.dataGridView.TabIndex = 16;
            // 
            // formReportButton
            // 
            this.formReportButton.Location = new System.Drawing.Point(662, 34);
            this.formReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.formReportButton.Name = "formReportButton";
            this.formReportButton.Size = new System.Drawing.Size(112, 32);
            this.formReportButton.TabIndex = 13;
            this.formReportButton.Text = "Сформировать";
            this.formReportButton.UseVisualStyleBackColor = true;
            this.formReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // mechanicLabel
            // 
            this.mechanicLabel.AutoSize = true;
            this.mechanicLabel.Location = new System.Drawing.Point(12, 29);
            this.mechanicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mechanicLabel.Name = "mechanicLabel";
            this.mechanicLabel.Size = new System.Drawing.Size(51, 13);
            this.mechanicLabel.TabIndex = 11;
            this.mechanicLabel.Text = "Механик";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(289, 391);
            this.exportButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(112, 32);
            this.exportButton.TabIndex = 17;
            this.exportButton.Text = "Экспорт";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "Id";
            this.OrderId.HeaderText = "ID Заказа";
            this.OrderId.Name = "OrderId";
            // 
            // AssignedMechanic
            // 
            this.AssignedMechanic.DataPropertyName = "AssignedMechanicName";
            this.AssignedMechanic.HeaderText = "Механик";
            this.AssignedMechanic.Name = "AssignedMechanic";
            // 
            // CarInfo
            // 
            this.CarInfo.DataPropertyName = "CarInfo";
            this.CarInfo.HeaderText = "Авто";
            this.CarInfo.Name = "CarInfo";
            // 
            // ProblemDescription
            // 
            this.ProblemDescription.DataPropertyName = "ProblemDescription";
            this.ProblemDescription.HeaderText = "Описание проблемы";
            this.ProblemDescription.Name = "ProblemDescription";
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Имя клиента";
            this.ClientName.Name = "ClientName";
            // 
            // ClientPhone
            // 
            this.ClientPhone.DataPropertyName = "ClientPhone";
            this.ClientPhone.HeaderText = "Телефон клиента";
            this.ClientPhone.Name = "ClientPhone";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус заказа";
            this.Status.Name = "Status";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Дата заказа";
            this.OrderDate.Name = "OrderDate";
            // 
            // CompletionDate
            // 
            this.CompletionDate.DataPropertyName = "CompletionDate";
            this.CompletionDate.HeaderText = "Дата завершения";
            this.CompletionDate.Name = "CompletionDate";
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Location = new System.Drawing.Point(546, 34);
            this.clearFilterButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(112, 32);
            this.clearFilterButton.TabIndex = 21;
            this.clearFilterButton.Text = "Очистить";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 504);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label activeOrdersLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label completedOrdersLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label mechanicLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label totalOrdersLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button formReportButton;
        private System.Windows.Forms.DateTimePicker dateToSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFromSelect;
        private System.Windows.Forms.ComboBox mechanicSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedMechanic;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletionDate;
        private System.Windows.Forms.Button clearFilterButton;
    }
}