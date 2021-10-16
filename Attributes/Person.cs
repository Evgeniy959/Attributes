using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Attributes.AgeValidatу;

namespace Attributes
{
    public class Person
    {
        //[Age(Age = 18)]
        [AgeAttribute(16)]
        public uint Age { get; set; }
        public string Name { get; set; }
        /*public Person(string name, uint age)
        {
            Age = age;
            Name = name;
        }*/
    }
}
