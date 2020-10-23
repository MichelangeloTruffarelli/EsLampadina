using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLampadina
{
    public class Lampadina
    {
        private int maxClick;
        private String stato;
        private int nclick;

        public Lampadina(string s, int m)
        {
            maxClick = m;
            stato = s;
        }

        public string Click()
        {
            nclick++;
            if (nclick > maxClick)
            {
                stato = "rotta";
            }
            else if (stato == "accesa")
            {
                stato = "spenta";
            }
            else if (stato == "spenta")
            {
                stato = "accesa";
            }
            return stato;
        }

        public string Descrizione()
        {
            return stato;
        }
    }
}
