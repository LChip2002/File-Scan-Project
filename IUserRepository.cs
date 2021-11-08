using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Scan_Project_Proper
{
    public interface IUserRepository
    {
        Task<bool> Insert(Form1.User user); //Aids in adding the user details from the program into the database.
    }
}
