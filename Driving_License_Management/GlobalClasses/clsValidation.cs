using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Driving_License_Management.GlobalClasses
{
    public class clsValidation
    {
        static public bool IsValidEmail(string Email)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex  = new Regex(pattern);
            return regex.IsMatch(Email);
        }

    }
}
