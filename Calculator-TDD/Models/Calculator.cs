using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_TDD.Models
{
    public class Calculator
    {
        public List<int> LastValues { get; set; } = new List<int>();
        public Calculator() { }

        public int Add(int value1, int value2) { 
            var res = value1 + value2;
            AddToLastValueArray(res);
            return res;
        }
        public int Subtract(int value1, int value2) { 
            var res = value1 - value2;
            AddToLastValueArray(res);
            return res;
        }
        public int Multiply(int value1, int value2) { 
            var res = value1 * value2;
            AddToLastValueArray(res);
            return res;
        }
        public int Divide(int value1, int value2) { 
            var res = value1 / value2;
            AddToLastValueArray(res);
            return res;
        }
        private void AddToLastValueArray(int resultValue) 
        {
            if (LastValues.Count == 3) { LastValues.Remove(0); LastValues.Add(resultValue); }
            else { LastValues.Add(resultValue);}
        }
    }
}
