using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_TDD.Models
{
    public class Calculator
    {
        public int[] LastValues { get; set; } = new int[3];
        public Calculator() { }

        public int Add(int value1, int value2) { return 0; }
        public int Subtract(int value1, int value2) { return 0; }
        public int Multiply(int value1, int value2) { return 0; }
        public int Divide(int value1, int value2) { return 0; }
        private void AddToLastValueArray(int resultValue) { }
    }
}
