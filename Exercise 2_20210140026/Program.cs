using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2_20210140026
{
    //28 : Maksimum Number
    class Program
    {

       

        static public void margesort(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, DH, num, PH;
            DH = (mid - 1);
            PH = left;
            num = (right - left + 1);


            //Fungsi Swap
            while ((left <= DH) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[PH++] = numbers[left++];
                else
                    temp[PH++] = numbers[mid++];
            }
            while (left <= DH)
                temp[PH++] = numbers[left++];
            while (mid <= right)
                temp[PH++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }


        static public void SortMerge(int[] numbers, int left, int right)
        {//perulangan method marge
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                margesort(numbers, left, (mid + 1), right);
            }
        }



        static void Main(string[] args)
        {
        }
    }
}
