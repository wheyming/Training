using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4WednesdayDemonstration
{
    class EmailIncorrectException : Exception
    {
        public EmailIncorrectException()
        {

        }
        public EmailIncorrectException(string email) : base(string.Format("Invalid Email Id {0}", email))
        {

        }
    }
}
