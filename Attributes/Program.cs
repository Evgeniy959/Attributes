using System;

namespace Attributes
{
    class Program
    {
        static void Main()
        {
            //Person human;
            Console.WriteLine("Введите имя человека:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите возраст человека:");
            var age = Convert.ToUInt32(Console.ReadLine());
            //human = new Person(name, age);
            var human = new Person();
            var validAgeResult = ValidatePerson.ValidAge(human, out uint Attr2);
            if (validAgeResult) Console.WriteLine($"{human.Name} совершеннолетний");
            else Console.WriteLine($"{human.Name} несовершеннолетний");
        }
    }
}
