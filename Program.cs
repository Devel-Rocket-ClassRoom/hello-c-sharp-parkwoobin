using System;
using System.Reflection.PortableExecutable;

class MainClass
{
    static void Main(string[] args)
    {
        bool boolValue = true;
        int intValue = 10;
        float floatValue = 3.4f;
        char charValue = 'A';

        Console.WriteLine("boolValue: " + boolValue.ToString());
        Console.WriteLine(intValue);
        Console.WriteLine(floatValue);
        Console.WriteLine(charValue);
    }
}