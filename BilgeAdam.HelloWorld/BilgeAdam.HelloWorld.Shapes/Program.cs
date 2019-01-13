using System;

namespace BilgeAdam.HelloWorld.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            GetScreenData();
            GetScreenData();
            Console.ReadKey();
        }

        static void GetScreenData()
        {
            var r1 = new Rectangle();
            Console.Write("Kısa kenarı giriniz.....: ");
            r1.shortEdge = Convert.ToDouble(Console.ReadLine());
            Console.Write("Uzun kenarı giriniz.....: ");
            r1.longEdge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Alan ...: " + r1.GetArea());
            Console.WriteLine("Çevre...: " + r1.GetPerimeter());
            Console.WriteLine("========================================");
        }
    }
    class Rectangle
    {
        public double shortEdge;
        public double longEdge;
        //alanı hesapla
        public double GetArea()
        {
            CheckValues();
            //geriye kenar çarpımlarını dön
            return shortEdge * longEdge;
        }
        //çevresini hesapla
        public double GetPerimeter()
        {
            CheckValues();
            //geriye kenar hesabı fomülünün sonucunu dön
            return (shortEdge + longEdge) * 2;
        }

        //dışarıdan erişime kapalı
        private void CheckValues()
        {
            if (shortEdge < 0) //-> içerideki ifade bool olmak zorunda
            {
                //üstteki ifade true ise bu scope çalışacak
                shortEdge = shortEdge * -1;
            }

            if (longEdge < 0)
            {
                //üstteki ifade true ise bu scope çalışacak
                longEdge = longEdge * -1;
            }
        }
    }

}

/*
 *  Method: Kendisine verilen paket işi yapmakla yükümlü parçacık
    Method Türleri
        void Type   : 
        return Type :


    Rectangle class'ı 4 üyeden(members) oluşuyor 
        2 field
        2 method
*/
