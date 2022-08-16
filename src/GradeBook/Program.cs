using System;
using System.Collections.Generic;

namespace GradeBook // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var x = 34.1;
            //var y = 12.1;
            //var sum = x + y;

            //array definition = var numbers = new[] {12.7, 10.3, 6.11, 4.1};

            var book = new Book("Scott's grade book");
            var done = false;
            // var grade = double.Parse(input);

            while(!done)
            {   
                System.Console.WriteLine("Enter a grade or 'q' to quit this program:" );
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }

                var grade = double.Parse(input);
                book.AddGrade(grade);
                
            }

            var stats = book.GetStats();

            System.Console.WriteLine($"Grades average is: {stats.Average:N2}");
            System.Console.WriteLine($"Lowest grade is: {stats.Low:N2}");
            System.Console.WriteLine($"Highest grade is: {stats.High:N2}");
            System.Console.WriteLine($"The Letter grade is: {stats.Letter}");

            //var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            
            //result += numbers[1];
            //result += numbers[2];
            //System.Console.WriteLine(result);
            //average calculation

        }
    }
}