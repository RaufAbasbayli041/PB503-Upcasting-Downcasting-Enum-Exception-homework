using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Enum__Exception_homework___1
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException()
        {

        }

        public NotAvailableException(string? message) : base(message)
        {

        }

    }
}
