using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FormUI.Classes
{
    public class ProjectContext
    {
        string connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        public List<string> GetProjects()
        {
            var projects = new List<string>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("GetProjects", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    projects.Add($"{reader["ProjectName"]}");
                }
                reader.Close();
            }
            return projects;
        }

        public int GetProjectID(string Project)
        {
            int Id = 0;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("GetProjectId", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
               

                cmd.Parameters.AddWithValue("@ProjectName", Project);

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
