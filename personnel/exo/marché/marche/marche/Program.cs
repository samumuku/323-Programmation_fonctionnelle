using LinqToExcel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace marche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produit> produits = new List<Produit>() {
                new Produit(1, "Bornand", "Pommes", 20, "kg", 6.9),
            new Produit(1, "Bornand", "Poires", 16, "kg", 3.5),
            new Produit(1, "Bornand", "Pastèques", 14, "pièce", 6),
            new Produit(1, "Bornand", "Melons", 5, "kg", 7),
            new Produit(2, "Dumont", "Noix", 20, "sac", 8.6),
            new Produit(2, "Dumont", "Raisin", 6, "kg", 5.6),
            new Produit(2, "Dumont", "Pruneaux", 13, "kg", 8.1),
            new Produit(2, "Dumont", "Myrtilles", 12, "kg", 8.9),
            new Produit(2, "Dumont", "Groseilles", 12, "kg", 5.2),
            new Produit(3, "Vonlanthen", "Pêches", 8, "kg", 8.7),
            new Produit(3, "Vonlanthen", "Haricots", 6, "kg", 6.9),
            new Produit(3, "Vonlanthen", "Courges", 18, "pièce", 4.3),
            new Produit(3, "Vonlanthen", "Tomates", 12, "kg", 9.4),
            new Produit(3, "Vonlanthen", "Pommes", 20, "kg", 3.9),
            new Produit(4, "Barizzi", "Poires", 5, "kg", 6.3),
            new Produit(4, "Barizzi", "Pastèques", 6, "pièce", 2.5),
            new Produit(4, "Barizzi", "Melons", 14, "kg", 4.2),
            new Produit(4, "Barizzi", "Noix", 20, "sac", 7.5),
            new Produit(4, "Barizzi", "Raisin", 15, "kg", 7.2),
            new Produit(5, "Blanc", "Pruneaux", 5, "kg", 9),
            new Produit(5, "Blanc", "Myrtilles", 18, "kg", 5.6),
            new Produit(5, "Blanc", "Groseilles", 10, "kg", 2.1),
            new Produit(5, "Blanc", "Pêches", 20, "kg", 6.4),
            new Produit(5, "Blanc", "Haricots", 9, "kg", 2.9),
            new Produit(6, "Repond", "Courges", 12, "pièce", 7.4),
            new Produit(6, "Repond", "Tomates", 12, "kg", 4.2),
            new Produit(6, "Repond", "Pommes", 15, "kg", 6.5),
            new Produit(6, "Repond", "Poires", 18, "kg", 2.4),
            new Produit(6, "Repond", "Pastèques", 7, "pièce", 5.7),
            new Produit(7, "Mancini", "Pêches", 10, "kg", 2.9),
            new Produit(7, "Mancini", "Haricots", 11, "kg", 6.7),
            new Produit(7, "Mancini", "Courges", 10, "pièce", 6.4),
            new Produit(7, "Mancini", "Tomates", 13, "kg", 1.5),
            new Produit(7, "Mancini", "Pommes", 14, "kg", 7),
            new Produit(8, "Favre", "Poires", 5, "kg", 8.4),
            new Produit(8, "Favre", "Pastèques", 5, "pièce", 1.7),
            new Produit(8, "Favre", "Haricots", 5, "kg", 3),
            new Produit(8, "Favre", "Courges", 17, "pièce", 2),
            new Produit(8, "Favre", "Tomates", 9, "kg", 5.2),
            new Produit(9, "Bovay", "Pommes", 13, "kg", 7.7),
            new Produit(9, "Bovay", "Poires", 5, "kg", 3.8),
            new Produit(9, "Bovay", "Pastèques", 20, "pièce", 2.1),
            new Produit(9, "Bovay", "Melons", 20, "kg", 6.4),
            new Produit(9, "Bovay", "Noix", 13, "sac", 8.8),
            new Produit(10, "Cherix", "Raisin", 8, "kg", 7.1),
            new Produit(10, "Cherix", "Pruneaux", 19, "kg", 7.9),
            new Produit(10, "Cherix", "Myrtilles", 9, "kg", 4.2),
            new Produit(10, "Cherix", "Groseilles", 10, "kg", 4.4),
            new Produit(10, "Cherix", "Pêches", 9, "kg", 4.4),
            new Produit(11, "Beaud", "Haricots", 19, "kg", 8.4),
            new Produit(11, "Beaud", "Courges", 16, "pièce", 8.7),
            new Produit(11, "Beaud", "Tomates", 18, "kg", 5.3),
            new Produit(11, "Beaud", "Pommes", 8, "kg", 7.3),
            new Produit(11, "Beaud", "Poires", 13, "kg", 9.2),
            new Produit(12, "Corbaz", "Pastèques", 15, "pièce", 7.4),
            new Produit(12, "Corbaz", "Melons", 12, "kg", 1.6),
            new Produit(12, "Corbaz", "Noix", 11, "sac", 7.5),
            new Produit(12, "Corbaz", "Raisin", 16, "kg", 4.5),
            new Produit(12, "Corbaz", "Pruneaux", 20, "kg", 3.3),
            new Produit(13, "Amaudruz", "Myrtilles", 18, "kg", 5.7),
            new Produit(13, "Amaudruz", "Groseilles", 19, "kg", 8),
            new Produit(13, "Amaudruz", "Pêches", 12, "kg", 5.5),
            new Produit(13, "Amaudruz", "Haricots", 13, "kg", 5.2),
            new Produit(13, "Amaudruz", "Courges", 7, "pièce", 9.6),
            new Produit(14, "Bühlmann", "Tomates", 12, "kg", 7.7),
            new Produit(14, "Bühlmann", "Pommes", 17, "kg", 1.9),
            new Produit(14, "Bühlmann", "Poires", 7, "kg", 3),
            new Produit(14, "Bühlmann", "Pastèques", 11, "pièce", 6.9),
            new Produit(14, "Bühlmann", "Melons", 7, "kg", 4.7),
            new Produit(15, "Crizzi", "Noix", 10, "sac", 1.6),
            new Produit(15, "Crizzi", "Raisin", 17, "kg", 7.8),
            new Produit(15, "Crizzi", "Pruneaux", 18, "kg", 9),
            new Produit(15, "Crizzi", "Myrtilles", 12, "kg", 3),
            new Produit(15, "Crizzi", "Groseilles", 12, "kg", 3.5)

        };

            var queryPeche = produits.Where(p => p.Product == "Pêches");
            var maxQuantite = produits.Max(p => p.Quantite);
            var queryProducteur = produits.Where(x => x.Quantite >= maxQuantite).Select(x => new { x.Producteur, x.Emplacement, x.Quantite });

            Console.WriteLine(maxQuantite);
            Console.WriteLine(queryProducteur);
            Console.ReadKey();

        }
    }


}
