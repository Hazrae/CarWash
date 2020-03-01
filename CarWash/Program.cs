using System;

namespace CarWash
{

    delegate void traitement(Voiture v);

    class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new Voiture("ERH 963");
         
            CW.Traiter(v);

            traitement tr = delegate (Voiture v)
            {
                Console.WriteLine("Je prépare la voiture : " + v.Plaque);
            };
            tr += delegate (Voiture v)
            {
                Console.WriteLine("Je lave la voiture : " + v.Plaque);
            };
            tr += delegate (Voiture v)
            {
                Console.WriteLine("Je sècche la voiture : " + v.Plaque);
            };
            tr += delegate (Voiture v)
            {
                Console.WriteLine("Je finalise la voiture : " + v.Plaque);
            };

            tr(v);



        }
    }
}
