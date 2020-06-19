using System;

namespace girilenYazıyıTerstenYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metin giriniz: ");
            string metin = Console.ReadLine();

            string[] kelimeler = metin.Split(' ');
            string tersi = "";
            for (int i = kelimeler.Length - 1; i >= 0; i--)
            {
                tersi += kelimeler[i] + ' ';
            }

            Console.WriteLine("Metinin tersi: " + tersi);
        }
    }
}
