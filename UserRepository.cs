using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper; 

namespace File_Scan_Project_Proper
{
    public class UserRepository : IUserRepository
    {
        public async Task<bool> Insert(Form1.User user)
        {
            using(IDbConnection db=new SqlConnection(AppHelper.ConnectionString)) //Uses the connectionstring in the Apphelper class
            {
                //This inserts the new user into the database when it is called.
                var result = await db.ExecuteAsync(File_Scan_Project_Proper.Properties.Resources.InsertUser, new { UserName = user.UserName, Password = user.Password }); 
                return result > 0;
            }
        }
    }
}
