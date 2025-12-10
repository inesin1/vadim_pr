using System.Windows.Forms;

namespace ZadachaVadim.Forms
{
    partial class RepairForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.carInfoTextBox = new System.Windows.Forms.TextBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.completeOrderButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mechanicSelect = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clientPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.problemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.onlyActiveCheckbox = new System.Windows.Forms.CheckBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mechanic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carInfoTextBox
            // 
            this.carInfoTextBox.Location = new System.Drawing.Point(238, 38);
            this.carInfoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.carInfoTextBox.Name = "carInfoTextBox";
            this.carInfoTextBox.Size = new System.Drawing.Size(224, 20);
            this.carInfoTextBox.TabIndex = 2;
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(10, 238);
            this.addOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(105, 39);
            this.addOrderButton.TabIndex = 3;
            this.addOrderButton.Text = "Добавить";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // completeOrderButton
            // 
            this.completeOrderButton.Location = new System.Drawing.Point(537, 224);
            this.completeOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.completeOrderButton.Name = "completeOrderButton";
            this.completeOrderButton.Size = new System.Drawing.Size(105, 39);
            this.completeOrderButton.TabIndex = 5;
            this.completeOrderButton.Text = "Завершить заказ";
            this.completeOrderButton.UseVisualStyleBackColor = true;
            this.completeOrderButton.Click += new System.EventHandler(this.completeOrderButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mechanic,
            this.carInfo,
            this.problemDescription,
            this.ClientName,
            this.ClientPhone,
            this.orderDate,
            this.completeDate,
            this.status,
            this.totalCost});
            this.dataGridView.Location = new System.Drawing.Point(5, 27);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(843, 140);
            this.dataGridView.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Механик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Авто";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Описание проблемы";
            // 
            // mechanicSelect
            // 
            this.mechanicSelect.FormattingEnabled = true;
            this.mechanicSelect.Location = new System.Drawing.Point(10, 39);
            this.mechanicSelect.Margin = new System.Windows.Forms.Padding(2);
            this.mechanicSelect.Name = "mechanicSelect";
            this.mechanicSelect.Size = new System.Drawing.Size(183, 21);
            this.mechanicSelect.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalCostTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.clientPhoneTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.clientNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addOrderButton);
            this.groupBox1.Controls.Add(this.problemDescriptionTextBox);
            this.groupBox1.Controls.Add(this.mechanicSelect);
            this.groupBox1.Controls.Add(this.carInfoTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 183);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(502, 290);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление заказа";
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Location = new System.Drawing.Point(10, 200);
            this.totalCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(183, 20);
            this.totalCostTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Стоимость";
            // 
            // clientPhoneTextBox
            // 
            this.clientPhoneTextBox.Location = new System.Drawing.Point(10, 145);
            this.clientPhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.clientPhoneTextBox.Name = "clientPhoneTextBox";
            this.clientPhoneTextBox.Size = new System.Drawing.Size(183, 20);
            this.clientPhoneTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Телефон клиента";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(10, 92);
            this.clientNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.clientNameTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Имя клиента";
            // 
            // problemDescriptionTextBox
            // 
            this.problemDescriptionTextBox.Location = new System.Drawing.Point(238, 92);
            this.problemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.problemDescriptionTextBox.Name = "problemDescriptionTextBox";
            this.problemDescriptionTextBox.Size = new System.Drawing.Size(224, 20);
            this.problemDescriptionTextBox.TabIndex = 1;
            // 
            // onlyActiveCheckbox
            // 
            this.onlyActiveCheckbox.AutoSize = true;
            this.onlyActiveCheckbox.Location = new System.Drawing.Point(537, 194);
            this.onlyActiveCheckbox.Name = "onlyActiveCheckbox";
            this.onlyActiveCheckbox.Size = new System.Drawing.Size(115, 17);
            this.onlyActiveCheckbox.TabIndex = 17;
            this.onlyActiveCheckbox.Text = "Только активные";
            this.onlyActiveCheckbox.UseVisualStyleBackColor = true;
            this.onlyActiveCheckbox.CheckedChanged += new System.EventHandler(this.onlyActiveCheckbox_CheckedChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // mechanic
            // 
            this.mechanic.DataPropertyName = "AssignedMechanicName";
            this.mechanic.HeaderText = "Механик";
            this.mechanic.MinimumWidth = 8;
            this.mechanic.Name = "mechanic";
            this.mechanic.Width = 150;
            // 
            // carInfo
            // 
            this.carInfo.DataPropertyName = "CarInfo";
            this.carInfo.HeaderText = "Авто";
            this.carInfo.Name = "carInfo";
            // 
            // problemDescription
            // 
            this.problemDescription.DataPropertyName = "ProblemDescription";
            this.problemDescription.HeaderText = "Описание проблемы";
            this.problemDescription.Name = "problemDescription";
            this.problemDescription.Width = 150;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Имя клиента";
            this.ClientName.MinimumWidth = 8;
            this.ClientName.Name = "ClientName";
            this.ClientName.Width = 150;
            // 
            // ClientPhone
            // 
            this.ClientPhone.DataPropertyName = "ClientPhone";
            this.ClientPhone.HeaderText = "Телефон клиента";
            this.ClientPhone.Name = "ClientPhone";
            // 
            // orderDate
            // 
            this.orderDate.DataPropertyName = "orderDate";
            this.orderDate.HeaderText = "Дата заказа";
            this.orderDate.MinimumWidth = 8;
            this.orderDate.Name = "orderDate";
            this.orderDate.Width = 150;
            // 
            // completeDate
            // 
            this.completeDate.DataPropertyName = "completionDate";
            this.completeDate.HeaderText = "Дата завершения";
            this.completeDate.MinimumWidth = 8;
            this.completeDate.Name = "completeDate";
            this.completeDate.Width = 150;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Статус";
            this.status.Name = "Status";
            // 
            // totalCost
            // 
            this.totalCost.DataPropertyName = "totalCost";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.totalCost.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalCost.HeaderText = "Стоимость";
            this.totalCost.MinimumWidth = 8;
            this.totalCost.Name = "totalCost";
            this.totalCost.Width = 150;
            // 
            // RepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 504);
            this.Controls.Add(this.onlyActiveCheckbox);
            this.Controls.Add(this.completeOrderButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RepairForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox carInfoTextBox;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button completeOrderButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mechanicSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox onlyActiveCheckbox;
        private System.Windows.Forms.TextBox problemDescriptionTextBox;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clientPhoneTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Label label4;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn mechanic;
        private DataGridViewTextBoxColumn carInfo;
        private DataGridViewTextBoxColumn problemDescription;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn ClientPhone;
        private DataGridViewTextBoxColumn orderDate;
        private DataGridViewTextBoxColumn completeDate;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn totalCost;
    }
}