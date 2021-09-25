using System;
using System.Collections.Generic;

namespace Porto {
    public class Porto {

        public List<Barca> porto;

        public Porto() {
            porto = new List<Barca>();
        }

        public void entrataBarca(Barca b) {
            porto.Add(b);
            
            XMLUtils.WriteXML(this);
        }

        public void uscitaBarca(string CodiceImmatricolazione) {
            porto.Remove(porto.Find(x => x.CodiceImmatricolazione == CodiceImmatricolazione));
            
            XMLUtils.WriteXML(this);
        }

        public void stampaPorto() {
            
            porto.ForEach(x =>
            {
                if (x is Vela)
                    Console.WriteLine(x as Vela + "\n");
                else if (x is Motore)
                    Console.WriteLine(x as Motore + "\n");
                else
                    Console.WriteLine(x + "\n");
            });
        }
    }
}