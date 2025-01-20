using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCalculator
{
    internal class Calculator
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }

        public dynamic Subtract(dynamic a, dynamic b)
        {
            return a - b;
        }

        public dynamic Multiply(dynamic a, dynamic b)
        {
            return a * b;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            if (b == 0)
            {
                return "Error: Division by zero";
            }
            return a / b;
        }
    }
}

