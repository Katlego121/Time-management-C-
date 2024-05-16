using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;

namespace ST10104140_POE_Katlego_Mononyane.Pages
{
    public class loginModel : PageModel
    {
        private readonly ILogger<loginModel> _logger;

        public loginModel(ILogger<loginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            string user = Request.Form["username"];
            string pass = Request.Form["password"];
            //Please place your own connection string from the StudyDB.mdf file
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lab_services_student\\Desktop\\PROG6212\\ST10104140_PROG6212_POE\\StudyDB.mdf;Integrated Security=True";

            string sqlQuery = "SELECT username, password FROM usersTBL WHERE username = @username AND password = @password";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand sc = new SqlCommand(sqlQuery, con))
                {
                    sc.Parameters.AddWithValue("@username", user);
                    sc.Parameters.AddWithValue("@password", pass);

                    using (SqlDataReader reader = sc.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Successful login, redirect to my dashboard
                            TempData["SuccessMessage"] = "Login Successful";
                            return RedirectToPage("/modules");
                        }
                    }
                }
            }
            //Failer to login in message 
            TempData["FailedMessage"] = "Login Failed.";
            return Page();
        }
    }
}
        
