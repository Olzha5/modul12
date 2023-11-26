using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul12DopolnitlnieWork
{
    internal class Program
    {
        public delegate double MathOperation(double x, double y);

        public static double PerformOperation(double x, double y, MathOperation operation)
        {
            return operation(x, y);
        }


        static void Main(string[] args)
        {
            MathOperation add = Operations.Add;
            MathOperation subtract = Operations.Subtract;
            MathOperation multiply = Operations.Multiply;
            MathOperation divide = Operations.Divide;

            double x = 10;
            double y = 5;

            Console.WriteLine($"Add: {PerformOperation(x, y, add)}");
            Console.WriteLine($"Subtract: {PerformOperation(x, y, subtract)}");
            Console.WriteLine($"Multiply: {PerformOperation(x, y, multiply)}");
            Console.WriteLine($"Divide: {PerformOperation(x, y, divide)}");
        }

        private static object PerformOperation(double x, double y, MathOperation add)
        {
            throw new NotImplementedException();
        }
    }
}
