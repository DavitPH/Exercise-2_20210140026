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
            Console.Write("\n\nMasukan jumlah element: ");
            int davit = Convert.ToInt32(Console.ReadLine()); //jumlah array yang dimasukan user
            int[] hartono = new int[davit];
            for (int i = 0; i < davit; i++) //menampung array yang dimasukan user
            {
                Console.Write("\nMasukan [" + (i + 1).ToString() + "] element: ");
                hartono[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Element belum tersusun: "); //menampilkan element array oleh user
            Console.Write("\n");
            for (int k = 0; k < davit; k++)
            {
                Console.Write(hartono[k] + " ");
                Console.Write(", ");
                Console.Write("\n");
            }
            Console.WriteLine("Element yang telah urut"); //Hasilnya
            SortMerge(hartono, 0, davit - 1);
            for (int i = 0; i < davit; i++)
                Console.Write(hartono[i] + ", ");
            Console.ReadLine();
        }
    }
}
