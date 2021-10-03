using System;
using System.Collections.Generic;

namespace Delegati_Persona {
    public delegate bool CheckEta(int eta); // Delegato per chiamata CheckEta

    public class Program {
        public static bool CheckEta(Persona p, CheckEta check) {
            return check(p.Eta);
        }

        public static bool CheckRagazzo(int eta) { // Check per Ragazzo
            if (eta < 18)
                return true;
            return false;
        }
        
        public static bool CheckAdulto(int eta) { // Check per Adulto
            if (eta >= 18 && eta < 65)
                return true;
            return false;
        }
        
        public static bool CheckAnziano(int eta) { // Check per Ragazzo
            if (eta >= 65)
                return true;
            return false;
        }
        
        static void Main(string[] args) {

            List<Persona> persone = new List<Persona>();
            persone.Add(new Persona("Nicolò", 18));
            persone.Add(new Persona("Silvia", 50));
            persone.Add(new Persona("Matteo", 17));
            persone.Add(new Persona("Franco", 78));

            Console.WriteLine("Nome\t\tRagazzo\tAdulto\tAnziano");

            persone.ForEach(x => 
                    Console.WriteLine(x.Nome + " (" + x.Eta + ")\t" + CheckEta(x, CheckRagazzo) + "\t" + CheckEta(x, CheckAdulto) + "\t" + CheckEta(x, CheckAnziano))
                    );
        }
    }
}