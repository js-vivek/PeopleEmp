using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleEmpDataAccessLayer.Services.UserService
{
    class UserService : IUserService
    {
        public string TestService()
        {
            
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["PeopleEmpConn"].ConnectionString;
                SqlCommand cmd = new SqlCommand("select * from Emp", conn);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
                return "Ready to Use";
        }
    }
}
