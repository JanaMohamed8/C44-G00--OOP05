using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal static class Maths
    {
        #region Methods 
        //Define Class Maths that has four methods: Add, Subtract,
        //Multiply, and Divide, each of them takes two parameters.
        //Call each method in Main ().
        //Modify the program so that you do not have to create an
        //instance of class to call the four methods.
        public static double Add(double FristValue, double secondValue)
        {
            return FristValue + secondValue;
        }
        public static double Subtract(double FristValue, double secondValue)
        {
            return FristValue - secondValue;
        }
        public static double Multiply(double FristValue, double secondValue)
        {
            return FristValue * secondValue;
        }

        public static double Divide(double FristValue, double secondValue)
        {
            return FristValue / secondValue;
        }
        #endregion
    }
}
