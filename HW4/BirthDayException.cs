using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class BirthDayException : Exception
    {
        public BirthDayException() { }
        public BirthDayException(string massage) 
            : base(massage) { }
    }
}
