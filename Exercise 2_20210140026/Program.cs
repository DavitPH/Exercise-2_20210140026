﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2_20210140026
{
    //28
    class Program
    {
        //deklarasi array int ukuran 26
        private int[] davit = new int[26];

        //deklarasi variabel in untuk menyimpan data pada array yg di input user
        private int hartono;

        //method menerima masukan

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
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Masukan Elemen Array");
            Console.WriteLine("--------------------");

            for (int i = 0; i < hartono; i++)  //user memasukan elemen 
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                davit[i] = Int32.Parse(s1);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
