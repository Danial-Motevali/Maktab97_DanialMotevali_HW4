using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class UpDataException : Exception
    {
        public UpDataException() { }
        public UpDataException(string massage) 
            : base(massage) { }
    }
}
