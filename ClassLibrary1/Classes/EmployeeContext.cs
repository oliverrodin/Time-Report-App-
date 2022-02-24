using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI.Classes
{
    public class EmployeeContext
    {
        string connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        public List<string> GetEmployees()
        {
            var employees = new List<string>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("GetEmployees", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    employees.Add($"{dr["FirstName"]} {dr["LastName"]}");
                }
                dr.Close();
            }
            return employees;
        }

        public int GetEmployeeID(string employee)
        {
            int Id = 0;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("GetEmployeeId", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("@Employee", employee);
                
                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    Id = (int)dr[0];
                }
                dr.Close();
            }
            return Id;
        }
    }
}
