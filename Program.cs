using System;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Hello world!");
        Console.WriteLine("My name is Dylan Bruner.");

        int age = 17;
        string greeting = "Hello, world!";
        string firstname = "Dylan";
        string lastname = "Bruner";
        double money = 2.79;

        Console.WriteLine($"{greeting}! My name is {firstname} {lastname}. I am {age} years old. I just spent ${money} on an Energy Drink.");
    }
}