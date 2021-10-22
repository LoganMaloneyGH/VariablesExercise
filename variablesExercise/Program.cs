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
            char firstInitial = B;
            bool likesTreats = True;
            Console.WriteLine($"My cat's name is {catName}, He is {catAge}, his first name starts with {firstInitial}");

        }
    }
}
