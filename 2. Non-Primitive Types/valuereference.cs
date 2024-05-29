// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class MyFirstApp
{

    public class Person
    {
        public int Age;
    }
    static void Main(string[] args)
    {
        // Value Types
        var a = 10;
        var b = a;
        b++;
        Console.WriteLine($"Value of a: {a}, Value of b: {b}");
        Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

        // Reference Types
        int[] array1 = new int[3] { 1, 2, 3 };
        int[] array2 = array1;
        array2[0] = 0;
        array1[1] = 5;

        Console.WriteLine($"Value of array1[0]: {array1[0]}\nValue of array2[0]: {array2[0]}");
        Console.WriteLine($"Value of array1[1]: {array1[1]}\nValue of array2[1]: {array2[1]}");

        var number = 1;
        Increment(number);
        Console.WriteLine(number);

        var person = new Person() { Age = 20 };
        Console.WriteLine(person.Age);
    }
    static void Increment(int number)
    {
        number += 10;
    }

    public static void MakeOld(Person person)
    {
        person.Age += 10;
    }
}
