using System;

namespace Attributes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите имя человека:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите возраст человека:");
            var age = Convert.ToUInt32(Console.ReadLine());
            var person = new Person(name, age);
            var type = person.GetType();
            var members = type.GetMembers();
            foreach (var member in members)
            {
                var attrs = member.GetCustomAttributes(false);
                foreach (var attr in attrs)
                {
                    if (attr is AgeAttribute)
                    {
                        var temp = (AgeAttribute)attr;
                        if (age >= temp.age) Console.WriteLine($"{person.Name} совершеннолетний");
                        else Console.WriteLine($"{person.Name} несовершеннолетний");

                    }
                }
            }
        }
    }
}
