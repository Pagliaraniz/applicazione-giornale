using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace applicazione_giornale.Models
{
    internal class Giornale
    {
        private List<Articolo> articoli;

        public Giornale()
        {
            articoli = new List<Articolo>();
        }
        public void Aggiungi(Articolo articolo)
        {
            articoli.Add(articolo);
        }

        public int TrovaArticolo(Articolo articolo)
        {
            int index = 0;
            for (int i = 0; i < articoli.Count; i++) 
            {
                if(articolo == articoli[i])
                {
                    index = i;
                }
            }

            return index;
        }

        public void CreaCommentoRedazione(int index, string text)
        {
            Commento c = new CommentoRedazione(text);
            articoli[index].AggiungiCommento(c);
        }

        public void CreaCommentoNormale(int index, string text)
        {
            Commento c = new Commento(text);
            articoli[index].AggiungiCommento(c);
        }

        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0;i < articoli.Count; i++)
            {
                sb.Append(articoli[i].ToString());
            }

            return sb.ToString();
        }
        

    }
}
