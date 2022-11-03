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
        //deklarasi array int ukuran 28
        private int[] batas = new int[28];

        //deklarasi variabel in untuk menyimpan data pada array yg di input user
        private int numbers;

        //method menerima masukan

        public void read()
        {
            //bentuk perulangan dan menerima data yang disimpan di array
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                numbers = Int32.Parse(s);
                if (numbers <= 28)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Masukan Elemen Array");
            Console.WriteLine("--------------------");

            for (int i = 0; i < numbers; i++)  //user memasukan elemen 
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                batas[i] = Int32.Parse(s1);
            }
        }

        public void display()
        {
            //menampilkan array yang telas disusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Elemental Array yang Telah Tersusun");
            Console.WriteLine("-----------------------------------");

            for (int DH = 0; DH < numbers; DH++)
            {
                Console.WriteLine(batas[DH]);
            }
            Console.WriteLine("");
        }

        public void margesort(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }





        static void Main(string[] args)
        {
        }
    }
}
