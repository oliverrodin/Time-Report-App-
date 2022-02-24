using FormUI.Classes;
using System.Windows.Forms;

namespace ClassLibrary1.Classes
{
    public class CreateReportFormConfig
    {
        public static void PopulateProjectComboBox(ComboBox projectComboBox)
        {
            ProjectContext project = new ProjectContext();

            projectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            projectComboBox.Items.AddRange(project.GetProjects().ToArray());
        }

        public static void PopulateWeekComboBox(ComboBox weekComboBox)
        {
            ReportContext report = new ReportContext();

            weekComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            weekComboBox.Items.AddRange(report.GetAllWeeksOfAYear().ToArray());
        }

        public static void PopulateEmployeeLabels(string Employee, Label Name, Label Id)
        {
            EmployeeContext employee = new EmployeeContext();

            Name.Text = Employee;
            Id.Text = employee.GetEmployeeID(Employee).ToString();
        }

        public static bool ValidateInput(string week, string employeeID, string projectID, string hours, string projectName)
        {
            ReportContext report = new ReportContext();
            

            if (week != "" && employeeID != "" &&
                projectID != "" && hours != "")
            {
                int weekInt = int.Parse(week);
                int employeeInt = int.Parse(employeeID);
                int projectInt = int.Parse(projectID);
                int hoursInt = int.Parse(hours);

                
                if (hoursInt > 168)
                {
                    MessageBox.Show("You cant work more hours than it is in one week.");
                    return false;
                }
                if (hoursInt < 1)
                {
                    MessageBox.Show("You cant work less than 1 hour");
                    return false;
                }

                if (report.SaveNewReport(weekInt, employeeInt, projectInt, hoursInt))
                {
                    MessageBox.Show("Saved");
                }
                return true;
            }
                
            else
            {
                MessageBox.Show("You need to fill in all the information to create a new report.");
                return false;
            }
        }
    }
}
