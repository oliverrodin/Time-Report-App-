using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI.Classes
{
    public class ReportContext
    {
        string connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        public List<string> GetAllWeeksOfAYear()
        {
            var weeks = new List<string>();

            for (int i = 1; i < 53; i++)
            {
                weeks.Add($"{i}");
            }

            return weeks;

        }

        public bool SaveNewReport(int week, int employeeId, int projectId, int hours)
        {


            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("SaveReport", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };


                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                cmd.Parameters.AddWithValue("@Hours", hours);


                connection.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (Exception)
                {

                    return false;
                }
                 
                
            }


        }

        public List<string> ShowReportForSpecificEmployee(string employee)
        {
            var reports = new List<string>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("ShowSpecificEmployeeReports", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@EmployeeID", employee);

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    reports.Add($"Week: {dr["Week"], -20} Hours: {dr["Hours"], -20} Project: {dr["ProjectName"]}");
                }
                dr.Close();
            }
            return reports;
        }
    }
}
