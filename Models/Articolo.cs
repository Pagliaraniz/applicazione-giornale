using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicazione_giornale.Models
{
    internal class Articolo
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        private List<Commento> commenti;

        public Articolo(string autore, string titolo)
        {
            this.Autore = autore;
            this.Titolo = titolo;
            commenti = new List<Commento>();
        }

        public void AggiungiCommento(Commento commento)
        {
            commenti.Add(commento);
        }

        public override string ToString()
        {
            return $"{this.Titolo} dell'autore{this.Autore} ha questi commenti : {this.commenti}";
        }

        public static bool operator ==(Articolo a, Articolo b)
        {
            if(a.Autore == b.Autore && a.Titolo == b.Titolo)
            {
                return true ;
            }else
                return false ;
        }

        public static bool operator !=(Articolo a, Articolo b)
        {
            if (a.Autore != b.Autore && a.Titolo != b.Titolo)
            {
                return true;
            }
            else
                return false;
        }

    }
}
