using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLib
{
    public class UserService
    {
        private IContext context;

        public UserService(IContext context)
        {
            this.context = context;
        }

        public void Deactivate(int id)
        {
            var user = Get(id);
            user.IsActive = false;
            Save(user);
        }

        public void Save(User user)
        {
            context.Save(user);
        }

        public User Get(int id)
        {
            return context.GetUser(id);
        }
    }
}
