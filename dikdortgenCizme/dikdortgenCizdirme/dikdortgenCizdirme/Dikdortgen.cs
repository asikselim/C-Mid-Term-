using System;

namespace dikdortgenCizdirme
{
    class Program
    {
        static void Main(string[] args)
        {
            dikdortgenCiz();

            Console.ReadKey();


        }

        public static void dikdortgenCiz()//h: height w: width
        {
            Console.Write("Yüksekliği Girin : ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Genişliği Girin : ");
            int w = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1;  j <= w; j++)
                {
                    if (i == 1 || i == h)
                        Console.Write("*");
                    else
                        if (j == 1 || j == w)
                        Console.Write("*");
                    else
                Console.Write(" ");
        }
        Console.WriteLine();
            }
    Console.WriteLine();


        }



    }
        }
    