using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLib
{
    public interface IContext
    {
        User GetUser(int id);
        void Save(User user);
    }
}
