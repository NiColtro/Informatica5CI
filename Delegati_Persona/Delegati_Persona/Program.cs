using System;

namespace Delegati_Persona {
    public delegate bool CheckEta(int eta); // Delegato per chiamata CheckEta

    public class Program {
        public static bool CheckEta(Persona p, CheckEta check) {
            return check(p.Eta);
        }

        public static bool CheckAdulto(int eta) { // Check per Adulto
            if (eta >= 18 && eta < 65)
                return true;
            return false;
        }

        public static bool CheckRagazzo(int eta) { // Check per Ragazzo
            if (eta < 18)
                return true;
            return false;
        }

        static void Main(string[] args) {
            Persona p1 = new Persona("Nicolò", 18);
            Console.WriteLine("Check Ragazzo: " + CheckEta(p1, CheckRagazzo));
            Console.WriteLine("Check Adulto: " + CheckEta(p1, CheckAdulto));
        }
    }
}