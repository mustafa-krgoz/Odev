using System;

namespace Odev
{
    class Program
    {
        static void Main(string[]args)
        {
            //Uygulama1

            int a = 48, b = 6, c = 4, e = 24, d = 3, i = 2, g = 1, f = 8, m = 7, n= 5;

            double sonuc1 = (48 / 6 / 4);
            Console.WriteLine("Sonuç1:" + sonuc1);
           // ---------------------------------------------------------
            
            double sonuc2 = (24 / 3 * 2);
            Console.WriteLine("Sonuç2:" + sonuc2);
            // --------------------------------------------------------

            double sonuc3 = ((2 * 2) + 5 - 1 + 4);
            Console.WriteLine("Sonuç3:" + sonuc3);
            //---------------------------------------------------------

            double sonuc4 = ((7 + 4) * 2 - 1 + 8 / 2);
            Console.WriteLine("Sonuç4:" + sonuc4);
            //---------------------------------------------------------

            double sonuc5 = ((5 - 1) * 2 - 1 + (7 * 7) / 2);
            Console.WriteLine("Sonuç5:" + sonuc5);

            Console.WriteLine("-------------------------------------------");

            //_________________________________________________________
            // Uygulama 2:

            int x = 20, y=13, z=42;
            int one = 23, two = 55, three = 76, four = 45, five = 12, six = 18;

            Console.WriteLine((one == two) && (three > four) && (n < five));
            Console.WriteLine((one >= two) && (five != six));
            Console.WriteLine((x > y) && (z == y) && (z < x));
            Console.WriteLine((z > x) && (y < x));
            Console.WriteLine(x!=z||y<=z);

            Console.WriteLine("--------------------------------------");

            //-----------------------------------------------------------
            // Uygulama3:

            Console.Write("1.sayıyı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 % sayi2 == 0)
            {
                Console.WriteLine("Tam bölünebilirler");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Tam bölünemezler");
                Console.ReadLine();
            }

            Console.WriteLine("-----------------------------------");
            // _____________________________________________________________
            // Uygulama5:
            Console.WriteLine(" denklemin a, b ve c değerlerini giriniz: ");

             int sayi3 = int.Parse(Console.ReadLine());
             int sayi4 = int.Parse(Console.ReadLine());
             int sayi5 = int.Parse(Console.ReadLine());

            double sayi6 = sayi4 * sayi4 - (4 * sayi3 * sayi5);
            double x1, x2, sayi7;

            if (sayi6 > 0)
            {
                x1 = (-sayi4 - (Math.Sqrt(sayi6))) / 2 * sayi3;
                x2 = (-sayi4+ (Math.Sqrt(sayi6))) / 2 * sayi3;
                Console.WriteLine("denkleminin 2 ayrı kökü vardır: ");
                Console.WriteLine("x1: " + x1);
                Console.WriteLine("x2: " + x2);
                Console.ReadLine();
            }
            else if (sayi6 == 0)
            {
                sayi7 = -sayi4 / 2 * sayi3;
                Console.WriteLine(" denkleminin 1 kökü vardır : ");
                Console.WriteLine(" x: " + sayi7);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("denkleminin kökü yoktur");
                Console.ReadLine();
            }
        }
    }
}
