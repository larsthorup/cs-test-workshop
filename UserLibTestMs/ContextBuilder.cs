using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLib;

namespace UserServiceTestMs
{
    public class ContextBuilder
    {
        private static int nextId = 0;

        public User[] Users { get; set; }

        public ContextStub Build()
        {
            foreach(var user in Users) user.Id = ++nextId;
            return new ContextStub
            {
                Users = Users
            };
        }
    }
}
