using System;

namespace Assignment_5_Student_scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toysScores = { 7, 6, 5, 4, 5 };
            Student Toy = new Student("Toy", 12, toysScores);
            Console.WriteLine(Toy.GetAverage());
        }
}
