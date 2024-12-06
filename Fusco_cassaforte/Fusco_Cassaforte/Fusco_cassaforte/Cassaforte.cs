using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusco_cassaforte
{
    internal class Cassaforte
    {
        /*private double codice;
        public double Codice
        {
            get { return codice; }
            set { codice = value; }
        }*/

        private double numeroMatricola;
        public double NumeroMatricola
        {
            get { return numeroMatricola; }
        }

        private String modello;
        public string Modello
        {
            get { return modello; }
        }
        private String produttore;
        public string Produttore
        {
            get { return produttore; }
        }
        private String codiceSbloccoSegreto;
        public string CodiceSbloccoSegreto
        {
            get { return codiceSbloccoSegreto; }
            set { codiceSbloccoSegreto = value; }
        }

        public Cassaforte(double numeroMatricola, string modello, string produttore, string codiceSbloccoSegreto) //double codice
        {
            //this.codice = codice;
            this.produttore = produttore;
            this.numeroMatricola = numeroMatricola;
            this.modello = modello;
            this.codiceSbloccoSegreto = codiceSbloccoSegreto;
        }


    }
}
