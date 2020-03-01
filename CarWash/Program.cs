using System;

namespace CarWash
{

    

    class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new Voiture("ERH 963");
         
            CW.Traiter(v);
            
        }
    }
}
