using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicazione_giornale.Models
{
    internal class Commento
    {
        public string Testo {  get; set; }

        public Commento(string testo)
        {
            this.Testo = testo;
        }

        public override string ToString()
        {
            return $"Commenti : {this.Testo}";
        }
    }
}
