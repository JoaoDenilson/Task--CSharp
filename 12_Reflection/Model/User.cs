using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Reflection.Model
{
    public class User : ICloneable
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
            //throw new NotImplementedException();
        }
    }
}
