using System;
using System.Collections.Generic;
using System.Text;

namespace csharpCalculator
{
    public class Calculate
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public string Oper { get; set; }
        public double Result { get; set; }

        public double Evaluation()
        {
            switch (Oper)
            {
                case "+":
                    Result = FirstNumber + SecondNumber;
                    break;
                case "-":
                    Result = FirstNumber - SecondNumber;
                    break;
                case "*":
                    Result = FirstNumber * SecondNumber;
                    break;
                case "/":
                    Result = FirstNumber / SecondNumber;
                    break;
                default:
                    break;
            }

            return Result;
        }
    }
}
