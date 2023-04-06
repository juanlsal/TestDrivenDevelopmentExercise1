using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        //public int Add(int num1, int num2, int num3) => num1 + num2 + num3;

        public int Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }
        //public int Subtract(int minuend, int subtrhend) => minuend - subtrhend;

        public int Multiply(int num1, int num2) => num1 * num2;

        public int Divide(int num1, int num2) => num1 / num2;
    }
}
