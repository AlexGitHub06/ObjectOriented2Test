using System;

namespace ObjectOriented2Test
{
    internal class Program
    {
        static void Main()
        {
            Homework homework = new Homework("Computing", 5, DateTime.Today.AddDays(11));
            Console.WriteLine(homework.Subject);
            Console.WriteLine(homework.GetUrgency());
            Console.WriteLine(homework.ChangeDifficulty(8));
            Console.WriteLine($"Due date: {homework.DueDate}");
            Console.WriteLine(homework.GetUrgency());
            
        }
    }
}