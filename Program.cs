// See https://aka.ms/new-console-template for more information
using System;
    public class evenoddnumber
{
    public static void Main()
    {
        int i;
        Console.WriteLine("Enter the number");
        i = int.Parse(Console.ReadLine());
        if(i%2==0)
        {
            Console.Write("Entered number is an even Number");
            Console.Read();
        }
        else
        {
            Console.Write("Entered Number is an Odd Number");
            Console.ReadLine();
        }
    }
}