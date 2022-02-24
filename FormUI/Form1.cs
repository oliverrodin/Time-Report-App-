using FormUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class TimeReportForm : Form
    {
        ReportContext reports = new ReportContext();
        EmployeeContext employee = new EmployeeContext();
        ProjectContext project = new ProjectContext();

        public TimeReportForm()
        {
            InitializeComponent();
            
            Form1Config.PopulateEmployeeComboBox(EmployeeComboBox);
            


        }


        //private void PopulateEmployeeComboBox()
        //{
        //    EmployeeComboBox.Items.AddRange(employee.GetEmployees().ToArray());
        //    EmployeeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        //}



        private void CreateReportButton_Click(object sender, EventArgs e)
        {
            CreateReportForm createReportForm = new CreateReportForm(EmployeeComboBox.SelectedItem.ToString());

            createReportForm.ShowDialog();

            Form1Config.UpdateListBox(ReportListBox, EmployeeComboBox);


            
        }

        private void EmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1Config.UpdateListBox(ReportListBox, EmployeeComboBox);

        }
        //private void UpdateListBox()
        //{
        //    List<string> specificReports =
        //        reports.ShowReportForSpecificEmployee(employee.GetEmployeeID(EmployeeComboBox.Text).ToString());
        //    specificReports.Sort();

        //    ReportListBox.Items.Clear();

        //    foreach (var report in specificReports)
        //    {
        //        ReportListBox.Items.Add(report);
        //    }
        //}

        
    }
}
