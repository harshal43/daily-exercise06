using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDailyExercise02
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        static int i = 2;
        public bool isPrime(int x)
        {
            if (x == 0 || x == 1) return false;
            if (x == i) return true;
            if (x % i == 0) return false;
            i++;
            return isPrime(x);
        }
    }
}
