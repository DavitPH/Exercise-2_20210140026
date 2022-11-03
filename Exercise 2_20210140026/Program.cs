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
        //deklarasi array int ukuran 46
        private int[] davit = new int[46];

        //deklarasi variabel in untuk menyimpan data pada array yg di input user
        private int hartono;
        public void read()
        {
            //bentuk perulangan dan menerima data yang disimpan di array
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                hartono = Int32.Parse(s);
                if (hartono <= 46)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
        }
        public void display()
        {
            //menampilkan array yang telas disusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Elemental Array yang Telah Tersusun");
            Console.WriteLine("-----------------------------------");

            for (int DH = 0; DH < hartono; DH++)
            {
                Console.WriteLine(davit[DH]);
            }
            Console.WriteLine("");
        }

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
                Console.Write("\n");
            }
            Console.WriteLine("Element yang telah tersusun"); //Hasilnya
            SortMerge(hartono, 0, davit - 1);
            for (int i = 0; i < davit; i++)
                Console.WriteLine(hartono[i]);


        }
    }
}
