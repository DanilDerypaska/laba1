using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Class1
    {
        // Завдання 1
        public static double Sk(double R, double r)
        {
            double result = Math.PI* R *R - Math.PI * r * r;
            return result;
        }
        // Завдання 2
        public static double S(double n, double x)
        {
            double result = x-(x*x*x)/3+ Math.Pow(x, 5)/5+ Math.Pow(-1, n)*((Math.Pow(x, 2*n+1)) / (2*n + 1));
            return result;
        }
        // Завдання 3
        public static double st(double x, double n)
        {
            double st = x - (x * x * x) / 3 + Math.Pow(x, 5) / 5 - Math.Pow(x, 7) / 7 + Math.Pow(-1, n) * ((Math.Pow(x, 2 * n + 1)) / (2 * n + 1));
            double arcctg = Math.PI / 2 - Math.Atan(x);
            double t = st / arcctg;
            return t;
        }        
    }
}
