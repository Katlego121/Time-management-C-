using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using System.Reflection;

namespace ST10104140_POE_Katlego_Mononyane.Pages
{
    public class modulesModel : PageModel
    {

        public void OnPost()
        {
            string modulecode = Request.Form["moduleCode"];
            string modulename = Request.Form["moduleName"];
            int credits = Convert.ToInt32(Request.Form["credits"]);
            int hoursperweek = Convert.ToInt32(Request.Form["hoursPerWeek"]);
            int weeks = Convert.ToInt32(Request.Form["weeks"]);
            string startsemester = Request.Form["startSemester"];
            string selfstudyhours = Request.Form["selfStudyHours"];

            int calcSelfStudyHours = (credits * 10 / weeks) - hoursperweek;
            int hoursLeft = calcSelfStudyHours - hoursperweek;

            //Please place your own connection string from the StudyDB.mdf file
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lab_services_student\\Desktop\\PROG6212\\ST10104140_PROG6212_POE\\StudyDB.mdf;Integrated Security=True";

            string sqlQuery = "INSERT INTO Modules(ModuleCode,ModuleName,Credits,HoursPerWeek,Weeks,StartSemester,SelfStudyHours,calculateSelfStudyHours,CalculateRemainHours) VALUES(" + "'" + modulecode + "'" + "," + "'" + modulename + "'" + "," + credits + "," + hoursperweek + "," + weeks + "," + "'" + startsemester + "'" + "," + "'" + selfstudyhours + "'" + "," + calcSelfStudyHours + "," + hoursLeft + ")";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}



