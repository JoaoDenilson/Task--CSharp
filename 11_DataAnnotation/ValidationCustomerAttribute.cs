using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace _11_DataAnnotation
{
    public class ValidationCustomerAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if ( ((string)value).Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
