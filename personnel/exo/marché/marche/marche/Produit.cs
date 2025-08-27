using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marche
{
    public class Produit
    {
        public Produit(int emplacement, string producteur, string produit, int quantite, string unite, double prix)
        {
            Emplacement = emplacement;
            Producteur = producteur;
            Product = produit;
            Quantite = quantite;
            Unite = unite;
            Prix = prix;
        }

        public int Emplacement
        {
            get;
            set;
        }
        public string Producteur
        {
            get;
            set;
        }
        public string Product
        {
            get;
            set;
        }
        public int Quantite
        {
            get;
            set;
        }
        public string Unite
        {
            get;
            set;
        }
        public double Prix
        {
            get;
            set;
        }
    }
}
