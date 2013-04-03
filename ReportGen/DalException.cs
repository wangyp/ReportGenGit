using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportGen
{
    public class DalException : ApplicationException
    {
        public DalException(string message) :base(message)
        {
        }
    }
}
