namespace Porto {
    public class Vela : Barca {

        public int Altezza { get; set; }
        public int NumeroAlberi { get; set; }

        public Vela() { }

        public Vela(string codiceImmatricolazione, int lunghezza, string nome, string nazionalita, int altezza,
            int numeroAlberi) : base(codiceImmatricolazione, lunghezza, nome, nazionalita) {
            Altezza = altezza;
            NumeroAlberi = numeroAlberi;
        }

        public override string ToString() {
            return base.ToString() + "Altezza: " + Altezza + "\nNumero di alberi: " + NumeroAlberi;
        }

    }
}