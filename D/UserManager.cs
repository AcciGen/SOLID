using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    public class UserManager
    {
        private readonly IDatabase _database;

        public UserManager(IDatabase database)
        {
            _database = database;
        }

        public void AddUser(string userData)
        {
            _database.SaveData(userData);
        }
    }
}
