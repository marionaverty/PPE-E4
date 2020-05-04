using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Commande
    {
        public string libele = "Commande";
        private int numero;
        private int code_v;
        private int code_c;
        private DateTime date_livraison;
        private DateTime date_commande;
        private float total_ht;
        private float total_tva;
        private char etat;

        public int Numero { get => numero; set => numero = value; }
        public int Code_v { get => code_v; set => code_v = value; }
        public int Code_c { get => code_c; set => code_c = value; }
        public DateTime Date_livraison { get => date_livraison; set => date_livraison = value; }
        public DateTime Date_commande { get => date_commande; set => date_commande = value; }
        public float Total_ht { get => total_ht; set => total_ht = value; }
        public float Total_tva { get => total_tva; set => total_tva = value; }
        public char Etat { get => etat; set => etat = value; }
    }
}
