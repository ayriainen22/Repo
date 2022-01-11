using System;

namespace harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            opiskelija opiskelija1 = new opiskelija("Matti", "TVT123",0);

            opiskelija1.Tulostadata();

            opiskelija1.MuokkaaOpintopisteitä(5);
            opiskelija1.Tulostadata();
        }
    }
}
