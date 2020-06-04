using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethos
{

    class Program
    {
        int Power(int input)
        {
            return (int)(Math.Pow(input, 2));
        }
        int Power(int input, int count)
        {
            return (int)(Math.Pow((double)input, (double)count));
        }

        int SumAll(int end)
        {
            int sum = 0;
            for (int i = 0; i <= end; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        int SumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
        }
    }
}
