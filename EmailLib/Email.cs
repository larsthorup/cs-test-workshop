using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailLib
{
    public class Email
    {
        public string Body { get; set; }

        // Note: this is included to allow Email objects to be used in NSubstitute argument matchers
        public override bool Equals(object other)
        {
            var otherEmail = other as Email;
            if (otherEmail != null)
            {
                return Body == otherEmail.Body;
            }
            else 
            {
                return base.Equals(other);
            }
        }

        // Note: this is included to get more informative error messages from failing NSubstitute argument matchers
        public override string ToString()
        {
            return string.Format("Email {{ Body = {0} }}", Body);
        }

        // Note: this is included to avoid warning CS0659
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
