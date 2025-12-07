using tyuiu.cources.programming.interfaces.Sprint2;
using System;

namespace Tyuiu.ReutovZA.Sprint2.Task4.V16.Lib
{
    public class DataService : ISprint2Task4V16
    {
        public double Calculate(double x, double y)
        {
            double z = 0;

            
            z = (x == 2 && y > 2) ? Math.Pow((1 + 1 / y), x) : (y - 1 / x);

            return Math.Round(z, 3);
        }
    }
}