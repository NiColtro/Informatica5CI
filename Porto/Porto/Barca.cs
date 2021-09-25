namespace Porto {
    public abstract class Barca {
        public string CodiceImmatricolazione { get; set; }
        public int Lunghezza { get; set; }
        public string Nome { get; set; }
        public string Nazionalita { get; set; }

        public Barca() { }

        public Barca(string codiceImmatricolazione, int lunghezza, string nome, string nazionalita) {
            CodiceImmatricolazione = codiceImmatricolazione;
            Lunghezza = lunghezza;
            Nome = nome;
            Nazionalita = nazionalita;
        }

        public override string ToString() {
            return "> Barca:\nCodice di immatricolazione: " + CodiceImmatricolazione + "\nLunghezza: " + Lunghezza +
                   "\nNome: " + Nome + "\nNazionalità: " + Nazionalita + "\n";
        }

    }
}