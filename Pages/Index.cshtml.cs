using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace ST10104140_POE_Katlego_Mononyane.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost() 
        {
            string user = Request.Form["username"];
            string pass = Request.Form["password"];

            //Please place your own connection string from the StudyDB.mdf file
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lab_services_student\\Desktop\\PROG6212\\ST10104140_PROG6212_POE\\StudyDB.mdf;Integrated Security=True";

            string sqlQuery = "INSERT INTO usersTBL(username,password) VALUES(" + "'" + user + "'" + "," + "'" + pass + "'" + ")";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}



