using System;
using System.Collections.Generic;
using System.Text;


namespace CarWash
 
{
    delegate void traitement(Voiture v);

    class CW
    {
        public static void Preparer(Voiture v)
        {
            Console.WriteLine("Je prépare la voiture : " +v.Plaque);
        }
        private static void Laver(Voiture v)
        {
            Console.WriteLine("Je lave la voiture : " + v.Plaque);
        }
        private static void Secher(Voiture v)
        {
            Console.WriteLine("Je sèche la voiture : " + v.Plaque);
        }
        private static void Finaliser(Voiture v)
        {
            Console.WriteLine("Je finalise la voiture : " +v.Plaque);
        }
        public static void Traiter(Voiture v)
        {
            traitement t = Preparer;
            t += Laver;
            t += Secher;
            t += Finaliser;
            t(v);
        }



    }
}
