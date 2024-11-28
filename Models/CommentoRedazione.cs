using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicazione_giornale.Models
{
    internal class CommentoRedazione:Commento    
    {
        public CommentoRedazione(string t):base(t)
        {
            
        }

        public override string ToString()
        {
            return $"*** {this.Testo}";
        }
    }
}
