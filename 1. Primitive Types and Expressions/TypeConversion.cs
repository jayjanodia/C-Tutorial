using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Implicit Type Conversion
        byte b = 1; // 1 byte
        int i = b; // 4 bytes
        Console.WriteLine(i);

        // Explicit type conversion
        // b = i; // Cannot convert source type 'int' to target type 'byte'
        b = (byte)i;
        Console.WriteLine(b);
        i = 1000;
        b = (byte)i;
        Console.WriteLine(b); // goes out of bounds without exception

        // Non-Compatible Types
        string number = "1234";
        // i = (int)number; //cannot cast expression of type 'string' to type 'int'
        i = Convert.ToInt32(number);
        Console.WriteLine(i);
        // int j = Convert.ToByte(number); // will result in overflow exception
        // Console.WriteLine(j);
        try
        {
            var stringNumber = "1234";
            b = Convert.ToByte(number);
            Console.WriteLine(b);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception Message Printed: ");
            Console.WriteLine(e.Message);
        }

        try
        {
            string str = "true";
            bool gate = (Convert.ToBoolean(str));
            Console.WriteLine(gate);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception Message Printed: ");
            Console.WriteLine(e.Message);
        }
    }
}
