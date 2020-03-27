using System;
using System.Collections.Generic;
using System.Text;

namespace SourceControlGit
{
    public class Calculator
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public string typeOperation { get; set; }

        public Calculator(double num1, double num2, string typeOperation)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.typeOperation = typeOperation;
        }
    }
}
