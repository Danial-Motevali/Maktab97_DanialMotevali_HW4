using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class PhoneNumberException : Exception
    {
        public PhoneNumberException(string massage)
            : base(massage);
    }
}
