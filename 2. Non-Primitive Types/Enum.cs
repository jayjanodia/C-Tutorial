using System;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            // Note that console.writeline explicitly converts method to string
            // using the method.ToString() method as mentioned on line 24
            Console.WriteLine($"Key: {method}, Value: {(int)method}");

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); // will get name at value=3

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            // Parsing: Getting a string and converting into a new type
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine("Shipping Method: " + shippingMethod.ToString() + "Type: " + (int)shippingMethod);
        }
    }
}

