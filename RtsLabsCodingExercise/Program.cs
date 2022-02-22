using System;

namespace RtsLabsCodingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorter sorter = new Sorter();
            Dictionary<string,int> sorted = sorter.AboveBelow(new List<int>() { 1, 5, 2, 1, 10 }, 6);
            Console.WriteLine("above: " + sorted["above"] + ", below: " + sorted["below"]);
            string rotated = sorter.StringRotation("MyString", 2);
            Console.WriteLine(rotated);
        }
    }
}
