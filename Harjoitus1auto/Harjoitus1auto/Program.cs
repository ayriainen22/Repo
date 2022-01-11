using System;

namespace Harjoitus1auto

{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo auto = new Ajoneuvo();
            auto.nimi = "Toyota";
            auto.nopeus = 160;
            auto.renkaat = 4;


            auto.TulostaData();

        }
    }
}

