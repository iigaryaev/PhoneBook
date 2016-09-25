using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exceptions
{
    public class PhoneBookManagerException : Exception
    {
        public PhoneBookManagerException() : base()
        {

        }

        public PhoneBookManagerException(string message) : base(message)
        {

        }
    }
}
