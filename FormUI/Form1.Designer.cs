namespace FormUI
{
    partial class TimeReportForm
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
            this.TimeReportGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateReportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportListBox = new System.Windows.Forms.ListBox();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.TimeReportGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeReportGroupBox
            // 
            this.TimeReportGroupBox.Controls.Add(this.CreateReportButton);
            this.TimeReportGroupBox.Controls.Add(this.label1);
            this.TimeReportGroupBox.Controls.Add(this.ReportListBox);
            this.TimeReportGroupBox.Controls.Add(this.EmployeeLabel);
            this.TimeReportGroupBox.Controls.Add(this.EmployeeComboBox);
            this.TimeReportGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeReportGroupBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeReportGroupBox.ForeColor = System.Drawing.Color.Coral;
            this.TimeReportGroupBox.Location = new System.Drawing.Point(13, 13);
            this.TimeReportGroupBox.Name = "TimeReportGroupBox";
            this.TimeReportGroupBox.Size = new System.Drawing.Size(696, 525);
            this.TimeReportGroupBox.TabIndex = 0;
            this.TimeReportGroupBox.TabStop = false;
            this.TimeReportGroupBox.Text = "Time Report";
            // 
            // CreateReportButton
            // 
            this.CreateReportButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateReportButton.Location = new System.Drawing.Point(19, 103);
            this.CreateReportButton.Name = "CreateReportButton";
            this.CreateReportButton.Size = new System.Drawing.Size(407, 29);
            this.CreateReportButton.TabIndex = 11;
            this.CreateReportButton.Text = "Create New Report";
            this.CreateReportButton.UseVisualStyleBackColor = true;
            this.CreateReportButton.Click += new System.EventHandler(this.CreateReportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Worked hours for current section";
            // 
            // ReportListBox
            // 
            this.ReportListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportListBox.FormattingEnabled = true;
            this.ReportListBox.ItemHeight = 21;
            this.ReportListBox.Location = new System.Drawing.Point(19, 182);
            this.ReportListBox.Name = "ReportListBox";
            this.ReportListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ReportListBox.Size = new System.Drawing.Size(663, 298);
            this.ReportListBox.TabIndex = 9;
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLabel.Location = new System.Drawing.Point(15, 44);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(78, 21);
            this.EmployeeLabel.TabIndex = 5;
            this.EmployeeLabel.Text = "Employee";
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(19, 68);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(599, 29);
            this.EmployeeComboBox.TabIndex = 3;
            this.EmployeeComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeComboBox_SelectedIndexChanged);
            // 
            // TimeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 550);
            this.Controls.Add(this.TimeReportGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Report";
            this.TimeReportGroupBox.ResumeLayout(false);
            this.TimeReportGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TimeReportGroupBox;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.ComboBox EmployeeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ReportListBox;
        private System.Windows.Forms.Button CreateReportButton;
    }
}

