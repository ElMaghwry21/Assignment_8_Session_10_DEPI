using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8_Session_10_DEPI
{
    public class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        // 2. Constructor to define minimum and maximum values
        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public double Length()
        {
            dynamic minVal = Min;
            dynamic maxVal = Max;
            return maxVal - minVal;
        }
    }
}
