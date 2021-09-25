using System;

namespace Porto {
    class Program {
        static void Main(string[] args) {

            string select = "";

            int lunghezza, altezzaAlbero, numeroAlberi, cavalli;
            string codiceImmatricolazione, nome, nazionalita;
            
            Porto p = new Porto();
            p = XMLUtils.ReadXML();

            while (select != "4") {

                Console.WriteLine("*** Porto ***\n1) Entrata barca\n2) Uscita barca\n3) Visualizza barche\n4) Esci.");
                select = Console.ReadLine();

                switch (select) {

                    case "1":
                        Console.WriteLine("> Inserimento barche.");
                        p.entrataBarca(new Vela("IMM1", 10, "BarcaVela1", "IT", 10, 1));
                        p.entrataBarca(new Vela("IMM2", 10, "BarcaVela2", "IT", 10, 1));
                        p.entrataBarca(new Vela("IMM3", 10, "BarcaVela3", "IT", 10, 1));
                        p.entrataBarca(new Motore("IMM4", 10, "BarcaMotore1", "IT", 45));
                        p.entrataBarca(new Motore("IMM5", 10, "BarcaMotore2", "IT", 50));
                        p.entrataBarca(new Motore("IMM6", 10, "BarcaMotore3", "IT", 10));
                        break;

                    case "2":
                        Console.WriteLine("> Uscita barca");
                        p.uscitaBarca("IMM6");
                        break;

                    case "3":
                        Console.WriteLine("> Visualizza porto");
                        p.stampaPorto();
                        break;
                    
                    case "4":
                        Console.WriteLine("> Uscita...");
                        break;
                }
            }

        }
    }
}