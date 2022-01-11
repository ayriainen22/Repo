using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus2
{
    class opiskelija
    {
        private string Nimi { get; set; }
        private string OpiskelijaID { get; set; }
        private int Opintopisteet { get; set; }
        public opiskelija(string Nimi, string OpiskelijaID, int Opintopisteet)
        {
            this.Nimi = Nimi;
           this.OpiskelijaID = OpiskelijaID;
            this.Opintopisteet = Opintopisteet;
            
        }
        public void Tulostadata()
        {
            Console.WriteLine("");
            Console.WriteLine("Opiskelija");
            Console.WriteLine("--- Nimi: " + Nimi);
            Console.WriteLine("Opiskelijan ID: " + OpiskelijaID);
            Console.WriteLine("Opintopisteet: " + Opintopisteet);
            Console.WriteLine("");
        }
        public void MuokkaaOpintopisteitä(int i)
        {
            Opintopisteet += i;
            if (Opintopisteet < 0)
            {
                Opintopisteet = 0;
            }
        }
    }
}
