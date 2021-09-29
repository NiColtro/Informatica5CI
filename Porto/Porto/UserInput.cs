using System;

namespace Porto {
    public static class UserInput {

        public static Motore newBarcaMotore() {

            Console.WriteLine("> Nuova barca\nCodice immatricolazione: ");
            string codiceImmatricolazione = Console.ReadLine();
            
            Console.WriteLine("\nLunghezza: ");
            int lunghezza = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("\nNome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("\nNazionalità: ");
            string nazionalita = Console.ReadLine();
            
            Console.WriteLine("\nCavalli: ");
            int cavalli = Int32.Parse(Console.ReadLine());
            
            return new Motore(codiceImmatricolazione, lunghezza, nome, nazionalita, cavalli);
        }
        
        public static Vela newBarcaVela() {

            Console.WriteLine("> Nuova barca\nCodice immatricolazione: ");
            string codiceImmatricolazione = Console.ReadLine();
            
            Console.WriteLine("\nLunghezza: ");
            int lunghezza = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("\nNome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("\nNazionalità: ");
            string nazionalita = Console.ReadLine();
            
            Console.WriteLine("\nAltezza: ");
            int altezza = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("\nNumero alberi: ");
            int numeroAlberi = Int32.Parse(Console.ReadLine());
            
            return new Vela(codiceImmatricolazione, lunghezza, nome, nazionalita, altezza, numeroAlberi);
        }
        
        
    }
}