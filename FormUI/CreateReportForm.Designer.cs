namespace FormUI
{
    partial class CreateReportForm
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
            this.NameFromForm1Label = new System.Windows.Forms.Label();
            this.IdFromForm1Label = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.CreateReportButton = new System.Windows.Forms.Button();
            this.WorkedHoursLabel = new System.Windows.Forms.Label();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.WorkedHoursTextBox = new System.Windows.Forms.TextBox();
            this.WeekComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectComboBox = new System.Windows.Forms.ComboBox();
            this.ProjIdLAbel = new System.Windows.Forms.Label();
            this.TimeReportGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeReportGroupBox
            // 
            this.TimeReportGroupBox.Controls.Add(this.ProjIdLAbel);
            this.TimeReportGroupBox.Controls.Add(this.NameFromForm1Label);
            this.TimeReportGroupBox.Controls.Add(this.IdFromForm1Label);
            this.TimeReportGroupBox.Controls.Add(this.EmployeeNameLabel);
            this.TimeReportGroupBox.Controls.Add(this.EmployeeIDLabel);
            this.TimeReportGroupBox.Controls.Add(this.CreateReportButton);
            this.TimeReportGroupBox.Controls.Add(this.WorkedHoursLabel);
            this.TimeReportGroupBox.Controls.Add(this.WeekLabel);
            this.TimeReportGroupBox.Controls.Add(this.ProjectLabel);
            this.TimeReportGroupBox.Controls.Add(this.WorkedHoursTextBox);
            this.TimeReportGroupBox.Controls.Add(this.WeekComboBox);
            this.TimeReportGroupBox.Controls.Add(this.ProjectComboBox);
            this.TimeReportGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeReportGroupBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeReportGroupBox.ForeColor = System.Drawing.Color.Coral;
            this.TimeReportGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TimeReportGroupBox.Name = "TimeReportGroupBox";
            this.TimeReportGroupBox.Size = new System.Drawing.Size(442, 379);
            this.TimeReportGroupBox.TabIndex = 1;
            this.TimeReportGroupBox.TabStop = false;
            this.TimeReportGroupBox.Text = "Create Report";
            // 
            // NameFromForm1Label
            // 
            this.NameFromForm1Label.AutoSize = true;
            this.NameFromForm1Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFromForm1Label.Location = new System.Drawing.Point(147, 83);
            this.NameFromForm1Label.Name = "NameFromForm1Label";
            this.NameFromForm1Label.Size = new System.Drawing.Size(0, 21);
            this.NameFromForm1Label.TabIndex = 13;
            // 
            // IdFromForm1Label
            // 
            this.IdFromForm1Label.AutoSize = true;
            this.IdFromForm1Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdFromForm1Label.Location = new System.Drawing.Point(120, 50);
            this.IdFromForm1Label.Name = "IdFromForm1Label";
            this.IdFromForm1Label.Size = new System.Drawing.Size(0, 21);
            this.IdFromForm1Label.TabIndex = 12;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLabel.Location = new System.Drawing.Point(14, 83);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(127, 21);
            this.EmployeeNameLabel.TabIndex = 11;
            this.EmployeeNameLabel.Text = "Employee Name:";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.Location = new System.Drawing.Point(14, 50);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(100, 21);
            this.EmployeeIDLabel.TabIndex = 10;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // CreateReportButton
            // 
            this.CreateReportButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateReportButton.Location = new System.Drawing.Point(18, 333);
            this.CreateReportButton.Name = "CreateReportButton";
            this.CreateReportButton.Size = new System.Drawing.Size(132, 31);
            this.CreateReportButton.TabIndex = 9;
            this.CreateReportButton.Text = "Create";
            this.CreateReportButton.UseVisualStyleBackColor = true;
            this.CreateReportButton.Click += new System.EventHandler(this.CreateReportButton_Click);
            // 
            // WorkedHoursLabel
            // 
            this.WorkedHoursLabel.AutoSize = true;
            this.WorkedHoursLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkedHoursLabel.Location = new System.Drawing.Point(14, 261);
            this.WorkedHoursLabel.Name = "WorkedHoursLabel";
            this.WorkedHoursLabel.Size = new System.Drawing.Size(110, 21);
            this.WorkedHoursLabel.TabIndex = 8;
            this.WorkedHoursLabel.Text = "Worked Hours";
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekLabel.Location = new System.Drawing.Point(14, 191);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(48, 21);
            this.WeekLabel.TabIndex = 7;
            this.WeekLabel.Text = "Week";
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLabel.Location = new System.Drawing.Point(14, 129);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(58, 21);
            this.ProjectLabel.TabIndex = 6;
            this.ProjectLabel.Text = "Project";
            // 
            // WorkedHoursTextBox
            // 
            this.WorkedHoursTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkedHoursTextBox.Location = new System.Drawing.Point(17, 285);
            this.WorkedHoursTextBox.Name = "WorkedHoursTextBox";
            this.WorkedHoursTextBox.Size = new System.Drawing.Size(404, 29);
            this.WorkedHoursTextBox.TabIndex = 4;
            // 
            // WeekComboBox
            // 
            this.WeekComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekComboBox.FormattingEnabled = true;
            this.WeekComboBox.Location = new System.Drawing.Point(17, 215);
            this.WeekComboBox.Name = "WeekComboBox";
            this.WeekComboBox.Size = new System.Drawing.Size(404, 29);
            this.WeekComboBox.TabIndex = 2;
            // 
            // ProjectComboBox
            // 
            this.ProjectComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectComboBox.FormattingEnabled = true;
            this.ProjectComboBox.Location = new System.Drawing.Point(17, 153);
            this.ProjectComboBox.Name = "ProjectComboBox";
            this.ProjectComboBox.Size = new System.Drawing.Size(404, 29);
            this.ProjectComboBox.TabIndex = 1;
            this.ProjectComboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectComboBox_SelectedIndexChanged);
            // 
            // ProjIdLAbel
            // 
            this.ProjIdLAbel.AutoSize = true;
            this.ProjIdLAbel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjIdLAbel.Location = new System.Drawing.Point(78, 129);
            this.ProjIdLAbel.Name = "ProjIdLAbel";
            this.ProjIdLAbel.Size = new System.Drawing.Size(0, 21);
            this.ProjIdLAbel.TabIndex = 14;
            // 
            // CreateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 403);
            this.Controls.Add(this.TimeReportGroupBox);
            this.Name = "CreateReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateReportForm";
            this.TimeReportGroupBox.ResumeLayout(false);
            this.TimeReportGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TimeReportGroupBox;
        private System.Windows.Forms.Label WorkedHoursLabel;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.TextBox WorkedHoursTextBox;
        private System.Windows.Forms.ComboBox WeekComboBox;
        private System.Windows.Forms.ComboBox ProjectComboBox;
        private System.Windows.Forms.Button CreateReportButton;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label NameFromForm1Label;
        private System.Windows.Forms.Label IdFromForm1Label;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label ProjIdLAbel;
    }
}