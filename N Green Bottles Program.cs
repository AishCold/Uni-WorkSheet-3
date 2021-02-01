using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ten green bottles");

        int count = 10;

        do
        {
            Console.WriteLine(count + " green bottles standing on a wall.");
            Console.WriteLine(count + " green bottles standing on a wall.");
            Console.WriteLine("but if 1 green bottle should accidently fall");   
            Console.WriteLine("there'd be " + (count - 1)  + " green bottles standing on a wall.");
            count = count - 1;

        } while (count >= 1);
    }
}
       