using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLib;

namespace UserServiceTestMs
{
    public class ContextStub : IContext
    {
        public User[] Users { get; set; }

        public User GetUser(string name)
        {
            return Users.Single(u => u.Name == name);
        }

        public User GetUser(int id)
        {
            return Users.Single(u => u.Id == id);
        }

        public void Save(User user)
        {
            // Nothing to do
        }
    }
}
