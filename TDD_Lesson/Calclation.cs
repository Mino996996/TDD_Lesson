using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Lesson
{
    public static class Calclation
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Average(List<int> list)
        {
            int values = 0;
            foreach(var val in list)
            {
                values += val;
            }
            return values / list.Count;
        }
    }
}
