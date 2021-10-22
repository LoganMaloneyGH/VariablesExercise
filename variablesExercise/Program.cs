using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesExercise
{
    class Program
    {
        private static bool True;
        private static char B;

        static void Main(string[] args)
        {
            string catName ="Baker";
            int catAge = 2; 
            char firstInitial = 'B';
            bool likesTreats = True;
            double catHeight = 1.3;
            decimal catWeight = 10.2m; 
            Console.WriteLine($"My cat's name is {catName}, He is {catAge}, his first name starts with {firstInitial}, My cat's height is {catHeight} feet tall, My cat weighs {catWeight} pounds.");

        }
    }
}
