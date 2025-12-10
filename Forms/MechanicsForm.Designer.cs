using System.Windows.Forms;

namespace ZadachaVadim.Forms
{
    partial class MechanicsForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.isAvailableCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editMechanicButton = new System.Windows.Forms.Button();
            this.deleteMechanicButton = new System.Windows.Forms.Button();
            this.addMechanicButton = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.IsAvailable});
            this.dataGridView.Location = new System.Drawing.Point(8, 31);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(615, 493);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            this.dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(745, 31);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(127, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // isAvailableCheckbox
            // 
            this.isAvailableCheckbox.AutoSize = true;
            this.isAvailableCheckbox.Location = new System.Drawing.Point(652, 66);
            this.isAvailableCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.isAvailableCheckbox.Name = "isAvailableCheckbox";
            this.isAvailableCheckbox.Size = new System.Drawing.Size(75, 17);
            this.isAvailableCheckbox.TabIndex = 4;
            this.isAvailableCheckbox.Text = "Свободен";
            this.isAvailableCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // editMechanicButton
            // 
            this.editMechanicButton.Location = new System.Drawing.Point(650, 135);
            this.editMechanicButton.Margin = new System.Windows.Forms.Padding(2);
            this.editMechanicButton.Name = "editMechanicButton";
            this.editMechanicButton.Size = new System.Drawing.Size(141, 32);
            this.editMechanicButton.TabIndex = 9;
            this.editMechanicButton.Text = "Редактировать";
            this.editMechanicButton.UseVisualStyleBackColor = true;
            this.editMechanicButton.Click += new System.EventHandler(this.editMechanicButton_Click);
            // 
            // deleteMechanicButton
            // 
            this.deleteMechanicButton.Location = new System.Drawing.Point(650, 171);
            this.deleteMechanicButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteMechanicButton.Name = "deleteMechanicButton";
            this.deleteMechanicButton.Size = new System.Drawing.Size(141, 33);
            this.deleteMechanicButton.TabIndex = 10;
            this.deleteMechanicButton.Text = "Удалить";
            this.deleteMechanicButton.UseVisualStyleBackColor = true;
            this.deleteMechanicButton.Click += new System.EventHandler(this.deleteMechanicButton_Click);
            // 
            // addMechanicButton
            // 
            this.addMechanicButton.Location = new System.Drawing.Point(650, 99);
            this.addMechanicButton.Margin = new System.Windows.Forms.Padding(2);
            this.addMechanicButton.Name = "addMechanicButton";
            this.addMechanicButton.Size = new System.Drawing.Size(141, 32);
            this.addMechanicButton.TabIndex = 8;
            this.addMechanicButton.Text = "Добавить";
            this.addMechanicButton.UseVisualStyleBackColor = true;
            this.addMechanicButton.Click += new System.EventHandler(this.addMechanicButton_Click);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.FillWeight = 50F;
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.Width = 50;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Имя";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // IsAvailable
            // 
            this.IsAvailable.DataPropertyName = "IsAvailable";
            this.IsAvailable.HeaderText = "Свободен";
            this.IsAvailable.MinimumWidth = 8;
            this.IsAvailable.Name = "IsAvailable";
            this.IsAvailable.Width = 150;
            // 
            // MechanicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 541);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.addMechanicButton);
            this.Controls.Add(this.deleteMechanicButton);
            this.Controls.Add(this.editMechanicButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isAvailableCheckbox);
            this.Controls.Add(this.nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MechanicsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox isAvailableCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editMechanicButton;
        private System.Windows.Forms.Button deleteMechanicButton;
        private System.Windows.Forms.Button addMechanicButton;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn IsAvailable;
    }
}