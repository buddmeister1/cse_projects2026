using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string input=Console.ReadLine();
        Console.Write("What is your last name?");
        string input2=Console.ReadLine();
        Console.WriteLine($"Your name is {input2}, {input} {input2}");
    }
}