using System;
using System.Collections.Generic;
using System.Text;

namespace SourceControlGit
{
    public class Calculator
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public string TypeOperation { get; set; }

        public Calculator(double num1, double num2, string typeOperation)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            this.TypeOperation = typeOperation;
        }

        public void executeOperation(string typeOperation)
        {
            switch (typeOperation)
            {
                case "+":
                    Add();
                    break;
                case "-":
                    Subtract();
                    break;
                case "*":
                    Multiply();
                    break;
                case "/":
                    Devide();
                    break;
                default:
                    Console.WriteLine("Invalid operation type.");
                    break;
            }
        }

        public double Add()
        {
            return Num1 + Num2;
        }

        public double Subtract()
        {
            return Num1 - Num2;
        }

        public double Multiply()
        {
            return Num1 * Num2;
        }

        public double Devide()
        {
            return Num1 / Num2;
        }

    }
}
