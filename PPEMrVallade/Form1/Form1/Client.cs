using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Client
    {
        public string libele = "Client";
        private int code_c;
        private string nom;
        private string adresse;
        private string cp;
        private string ville;
        private string telephone;

        public int Code_c { get => code_c; set => code_c = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Telephone { get => telephone; set => telephone = value; }
    }
}
