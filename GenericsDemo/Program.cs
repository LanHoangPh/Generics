using System;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person<string, string, int> person = new ("1", "name", 12);
            Console.WriteLine($"Id: {person.GetId()}, Name: {person.GetName()}, Age: {person.GetAge()}");
            Console.ReadKey();
        }
    }
}
