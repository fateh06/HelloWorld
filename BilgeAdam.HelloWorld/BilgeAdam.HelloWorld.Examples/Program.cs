using System;

namespace BilgeAdam.HelloWorld.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //DERS 1
            //int amountOfUnit = 8 + 7;
            //Console.Write("İsminizi Giriniz....: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Merhaba " + name);
            //Console.WriteLine("Ana sayfaya yönlendiriliyorsunuz");

            //DERS 2
            //Console.Write("Birinci Kenarı Giriniz...: ");
            //double kenar1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("İkinci Kenarı Giriniz....: ");
            //double kenar2 = Convert.ToDouble(Console.ReadLine());

            //double alan = kenar1 * kenar2;
            //double cevre = 2 * (kenar1 + kenar2);
            //Console.WriteLine("Dikdörtgenin Alanı.....: " + alan);
            //Console.WriteLine("Dikdörtgenin Çevresi...: " + cevre);


            //DERS 3
            //var name = "Can";
            //var amount = 9;
            //var exists = true;

            var a = 8;
            {
                var b = 3;

                {
                    var c = 2;
                    var t = a + b + c;
                    Console.WriteLine("Hepsinin Toplamı : " + t);
                }
                var d = a + b;
            }
            Console.ReadKey();
        }
    }
}
