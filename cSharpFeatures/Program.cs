using System;

namespace cSharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var propertySetters = new PropertySetters();
            Console.WriteLine(propertySetters.myDateTime);

        }
    }
}
