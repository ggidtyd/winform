using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal class Calculator
    {
        public float plus(float x, float y)
        { 
            return x + y; 
        }

        public float minus(float x, float y) 
        {
            return x - y; 
        }

        public float multiple(float x, float y)
        {
            return x * y;
        }

        public float divide(float x, float y)
        {
            return x / y;
        }
    }
}
