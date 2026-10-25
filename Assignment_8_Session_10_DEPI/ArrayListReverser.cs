using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8_Session_10_DEPI
{
    public static class ArrayListReverser
    {
        public static void Reverse(ArrayList list)
        {
            if (list == null || list.Count <= 1)
                return;

            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
    }
}
