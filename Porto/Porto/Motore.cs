namespace Porto {
    public class Motore : Barca {

        public int Cavalli { get; set; }

        public Motore() { }

        public Motore(string codiceImmatricolazione, int lunghezza, string nome, string nazionalita, int cavalli) :
            base(codiceImmatricolazione, lunghezza, nome, nazionalita) {
            Cavalli = cavalli;
        }

        public override string ToString() {
            return base.ToString() + "Cavalli: " + Cavalli;
        }

    }
}