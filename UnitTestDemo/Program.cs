using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Calculator
    {
        // Intentional error in Sum method
        public double Sum(double a, double b)
        {
            return a - b;
        }

        // Method works properly
        public double Sub(double a, double b)
        {
            return a - b;
        }

        // Method works properly
        public double Mul(double a, double b)
        {
            return a * b;
        }

        // Method works properly but does not trap divide by zero - requires try catch if used
        public double Div(double a, double b)
        {
            return a / b;
        }
    }
}
