using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Attributes
{
    public class AgeValidatу
    {
        public static bool AgeValid() 
        {
            var person = new Person();
            var type = person.GetType();
            var members = type.GetMembers();
            foreach (var member in members)
            {
                var attrs = member.GetCustomAttributes(false);
                foreach (var attr in attrs)
                {
                    if (attr is AgeAttribute)
                    {

                    }
                }
            }
            

            //
        }
    }
}
