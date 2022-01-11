using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus1auto
{
    class Ajoneuvo
    {
        public string nimi { get; set; }
        public int nopeus { get; set; }
        public int renkaat { get; set; }

        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvo: ");
            Console.WriteLine("--- nimi: " + nimi);
            Console.WriteLine("--- nopeus: " + nopeus);
            Console.WriteLine("--- renkaat: " + renkaat);
        }
    }
}