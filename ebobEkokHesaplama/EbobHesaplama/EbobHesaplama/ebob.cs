using System;

namespace EbobHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.WriteLine("Ilk sayıyı giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikıncı sayıyı giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            int cevap = EbobBul(sayi1, sayi2);
            Console.WriteLine("Bu sayının {0} ve bu sayının {1} EBOB'u:{2}", sayi1, sayi2, cevap);
            Console.ReadLine();




            Console.ReadKey();

        }
        static int EbobBul(int sayi1, int sayi2)
        {
            if (sayi2 == 0)
            {
                return sayi1;
            }
            else
            {
                return EbobBul(sayi2, sayi1 % sayi2);
            }
        }
    }
    }

