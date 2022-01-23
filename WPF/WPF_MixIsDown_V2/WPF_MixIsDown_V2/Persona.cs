using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPF_MixIsDown_V2
{
    internal class Persona
    {
        public string Cognome { get; set; }
        public string Nome { get; set; }

        public BitmapImage Foto { get; set; }
        public string FileVoce { get; set; }

        public Persona() { }

        public Persona(string cognome, string nome, BitmapImage foto, string fileVoce) {
            Cognome = cognome;
            Nome = nome;
            Foto = foto;
            FileVoce = fileVoce;
        }

        public Persona(Persona p) {
            this.Cognome = p.Cognome;
            this.Nome = p.Nome;
            this.Foto = p.Foto;
            this.FileVoce = p.FileVoce;
        }
    }
}
