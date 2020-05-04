using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Ligne_Commande
    {
        private int numero;
        private int numero_ligne;
        private string reference;
        private int quantite_demande;

        public int Numero { get => numero; set => numero = value; }
        public int Numero_ligne { get => numero_ligne; set => numero_ligne = value; }
        public string Reference { get => reference; set => reference = value; }
        public int Quantite_demande { get => quantite_demande; set => quantite_demande = value; }
    }
}
