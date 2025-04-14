using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Exception
{
    internal class NotAvailableException: System.Exception
    {
        public NotAvailableException() : base()
        {

        }
        public NotAvailableException(string? message):base(message)
        {

        }
    }
}
