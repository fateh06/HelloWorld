using System;

namespace BilgeAdam.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            string isim = "can";
            isim = "cem";
            //class oluştururken new anahtar kelimesi şart
            Car renaultMegane = new Car();
            renaultMegane.doorCount = 4;
            renaultMegane.model = "Megane 3";
            renaultMegane.transmission = Transmission.Automatic;
            renaultMegane.engine = new Engine
            {
                cylinderCount = 8,
                horsePower = 125,
                volume = 1.6,
                oilType = OilType.Diesel
            };

            //YUKARIDAKİNİN AYNISI
            renaultMegane.engine = new Engine();
            renaultMegane.engine.cylinderCount = 8;
            renaultMegane.engine.horsePower = 125;
            renaultMegane.engine.volume = 1.6;

            Console.WriteLine(renaultMegane.model);
            Console.ReadLine();
        }
    }

    class Car //arabanın tanımı ve veri modeli
    {
        public byte doorCount;
        public string model;
        public bool hasSecurity;
        public Engine engine;
        private string serialNumber;
        public Transmission transmission;
    }

    class Engine //motorun tanımı, yaspısı ve veri modeli
    {
        public int cylinderCount;
        public int horsePower;
        public double volume;
        public OilType oilType;
    }

    enum Transmission
    {
        Manual = 0,
        Automatic = 1
    }

    enum OilType
    {
        Gas = 0,
        Diesel = 1,
        LPG = 2
    }
}

/*
    TYPES:
        NUMERIC TYPES: long, int, short, byte
        RATIONAL TYPES: decimal, double, float
        TEXT TYPES: char, string
        LOGICAL TYPES: bool
        CUSTOM TYPES: class, enum
     
    TYPES:
        primitives : (struct) => int, long, bool, string (*?*)
        complexes : enum*, class () => ???

    ACCESS MODIFIERS :
        public: dış scope'lardan erişilebilir
        private: yalnızca kendi scope'undan erişilebilir
*/
