using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8_Session_10_DEPI
{
    public static class EvenNumbersFinder
    {
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0).ToList();
        }
    }
}
