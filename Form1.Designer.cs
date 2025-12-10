namespace ZadachaVadim
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.openReportForm = new System.Windows.Forms.Button();
            this.openMechanicsForm = new System.Windows.Forms.Button();
            this.openRepairOrderForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pageContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.openReportForm);
            this.panel1.Controls.Add(this.openMechanicsForm);
            this.panel1.Controls.Add(this.openRepairOrderForm);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 541);
            this.panel1.TabIndex = 2;
            // 
            // openReportForm
            // 
            this.openReportForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.openReportForm.FlatAppearance.BorderSize = 0;
            this.openReportForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.openReportForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.openReportForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openReportForm.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openReportForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openReportForm.Location = new System.Drawing.Point(0, 198);
            this.openReportForm.Margin = new System.Windows.Forms.Padding(2);
            this.openReportForm.Name = "openReportForm";
            this.openReportForm.Size = new System.Drawing.Size(233, 47);
            this.openReportForm.TabIndex = 2;
            this.openReportForm.Text = "Отчет";
            this.openReportForm.UseVisualStyleBackColor = true;
            this.openReportForm.Click += new System.EventHandler(this.openReportForm_Click);
            // 
            // openMechanicsForm
            // 
            this.openMechanicsForm.BackColor = System.Drawing.Color.AliceBlue;
            this.openMechanicsForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.openMechanicsForm.FlatAppearance.BorderSize = 0;
            this.openMechanicsForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.openMechanicsForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.openMechanicsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openMechanicsForm.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openMechanicsForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openMechanicsForm.Location = new System.Drawing.Point(0, 154);
            this.openMechanicsForm.Margin = new System.Windows.Forms.Padding(2);
            this.openMechanicsForm.Name = "openMechanicsForm";
            this.openMechanicsForm.Size = new System.Drawing.Size(233, 44);
            this.openMechanicsForm.TabIndex = 5;
            this.openMechanicsForm.Text = "Автомеханики";
            this.openMechanicsForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.openMechanicsForm.UseVisualStyleBackColor = false;
            this.openMechanicsForm.Click += new System.EventHandler(this.openMechanicsForm_Click);
            // 
            // openRepairOrderForm
            // 
            this.openRepairOrderForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.openRepairOrderForm.FlatAppearance.BorderSize = 0;
            this.openRepairOrderForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.openRepairOrderForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.openRepairOrderForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openRepairOrderForm.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openRepairOrderForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openRepairOrderForm.Location = new System.Drawing.Point(0, 108);
            this.openRepairOrderForm.Margin = new System.Windows.Forms.Padding(2);
            this.openRepairOrderForm.Name = "openRepairOrderForm";
            this.openRepairOrderForm.Size = new System.Drawing.Size(233, 46);
            this.openRepairOrderForm.TabIndex = 3;
            this.openRepairOrderForm.Text = "Очередь на ремонт";
            this.openRepairOrderForm.UseVisualStyleBackColor = true;
            this.openRepairOrderForm.Click += new System.EventHandler(this.openRepairOrderForm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 108);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Автосервис";
            // 
            // pageContent
            // 
            this.pageContent.BackColor = System.Drawing.SystemColors.Window;
            this.pageContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageContent.ForeColor = System.Drawing.Color.Black;
            this.pageContent.Location = new System.Drawing.Point(233, 0);
            this.pageContent.Margin = new System.Windows.Forms.Padding(2);
            this.pageContent.MinimumSize = new System.Drawing.Size(533, 520);
            this.pageContent.Name = "pageContent";
            this.pageContent.Size = new System.Drawing.Size(1147, 541);
            this.pageContent.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 541);
            this.Controls.Add(this.pageContent);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система управления прокатом";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pageContent;
        private System.Windows.Forms.Button openRepairOrderForm;
        private System.Windows.Forms.Button openReportForm;
        private System.Windows.Forms.Button openMechanicsForm;
    }
}