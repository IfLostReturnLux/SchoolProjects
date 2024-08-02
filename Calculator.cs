using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculator
    {
        public Calculator()
        {

        }
        public float Add(float first, float second)
        {
            float result = first + second;
            return result;
        }
        public float Subtract(float first, float second)
        {
            float result = first - second;
            return result;
        }
        public float Multiply(float first, float second)
        {
            float result = first * second;
            return result;
        }
    }
}
