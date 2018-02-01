using System.Data;
using System.Data.SqlClient;

namespace MVCArch.Data
{
    public class WorldEvents
    {
        readonly static string connString;
        DataTable dt;
        
        static WorldEvents()
        {
            connString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        }

        public DataTable GetEventDetails()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("Usp_GetEventDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    dt = new DataTable();
                    con.Open();
                    dt.Load(cmd.ExecuteReader());
                }
            }
           return dt;
        }

    }
}