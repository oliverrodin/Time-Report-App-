using FormUI.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public class Form1Config
    {
        
        public static void PopulateEmployeeComboBox(ComboBox employeeBox)
        {
            EmployeeContext employee = new EmployeeContext();

            employeeBox.Items.AddRange(employee.GetEmployees().ToArray());
            employeeBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void UpdateListBox(ListBox reportlistbox, ComboBox employeeBox)
        {
            ReportContext reports = new ReportContext();
            EmployeeContext employee = new EmployeeContext();

            List<string> specificReports =
                reports.ShowReportForSpecificEmployee(employee.GetEmployeeID(employeeBox.Text).ToString());
            specificReports.Sort();

            reportlistbox.Items.Clear();

            foreach (var report in specificReports)
            {
                reportlistbox.Items.Add(report);
            }
        }
    }
}
