using ClassLibrary1.Classes;
using FormUI.Classes;
using System;
using System.Windows.Forms;

namespace FormUI
{
    public partial class CreateReportForm : Form
    {
        ProjectContext project = new ProjectContext();
        
        public CreateReportForm(string Employee)
        {
            InitializeComponent();

            CreateReportFormConfig.PopulateProjectComboBox(ProjectComboBox);
            CreateReportFormConfig.PopulateWeekComboBox(WeekComboBox);
            CreateReportFormConfig.PopulateEmployeeLabels(Employee, NameFromForm1Label, IdFromForm1Label);
        }

        private void CreateReportButton_Click(object sender, EventArgs e)
        {
            if (CreateReportFormConfig.ValidateInput(WeekComboBox.Text, IdFromForm1Label.Text, ProjIdLAbel.Text, WorkedHoursTextBox.Text, ProjectComboBox.Text))
                this.Close();

            else
            {
                

            }
        }
        private void ProjectComboBox_SelectedIndexChanged(object sender, EventArgs e) =>
            ProjIdLAbel.Text = $"{project.GetProjectID(ProjectComboBox.SelectedItem.ToString())}";



    }
}
