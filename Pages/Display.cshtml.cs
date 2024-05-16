using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace ST10104140_POE_Katlego_Mononyane.Pages
{
    public class DisplayModel : PageModel
    {
        public List<Module> Modules { get; set; }

        public void OnGet()
        {
            //Please place your own connection string from the StudyDB.mdf file
            Modules = new List<Module>();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lab_services_student\\Desktop\\PROG6212\\ST10104140_PROG6212_POE\\StudyDB.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string selectQuery = "SELECT * FROM Modules";

                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var module = new Module
                        {
                            ModuleCode = reader["ModuleCode"].ToString(),
                            ModuleName = reader["ModuleName"].ToString(),
                            Credits = reader["Credits"] is DBNull ? 0 : (int)reader["Credits"],
                            HoursPerWeek = reader["HoursPerWeek"] is DBNull ? 0 : (int)reader["HoursPerWeek"],
                            Weeks = reader["Weeks"] is DBNull ? 0 : (int)reader["Weeks"],
                            StartSemester = reader["StartSemester"].ToString(),
                            SelfStudyHours = reader["SelfStudyHours"] is DBNull ? 0 : (int)reader["SelfStudyHours"],
                            calculateSelfStudyHours = reader["calculateSelfStudyHours"] is DBNull ? 0 : (int)reader["calculateSelfStudyHours"],
                            CalculateRemainHours = reader["CalculateRemainHours"] is DBNull ? 0 : (int)reader["CalculateRemainHours"],
                        };
                        Modules.Add(module);
                    }
                }
            }
        }
    }
}
