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
            List<Produit> products = new List<Produit>
            {
                new Produit { Location = 1, Producer = "Bornand", ProductName = "Pommes", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
                new Produit { Location = 1, Producer = "Bornand", ProductName = "Poires", Quantity = 16,Unit = "kg", PricePerUnit = 5.50 },
                new Produit { Location = 1, Producer = "Bornand", ProductName = "Pastèques", Quantity = 14,Unit = "pièce", PricePerUnit = 5.50 },
                new Produit { Location = 1, Producer = "Bornand", ProductName = "Melons", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
                new Produit { Location = 2, Producer = "Dumont", ProductName = "Noix", Quantity = 20,Unit = "sac", PricePerUnit = 5.50 },
                new Produit { Location = 2, Producer = "Dumont", ProductName = "Raisin", Quantity = 6,Unit = "kg", PricePerUnit = 5.50 },
                new Produit { Location = 2, Producer = "Dumont", ProductName = "Pruneaux", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
                new Produit { Location = 2, Producer = "Dumont", ProductName = "Myrtilles", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
            };

            var i18n = new Dictionary<string, string>()
            {
                { "Pommes","Apples"},
                { "Poires","Pears"},
                { "Pastèques","Watermelons"},
                { "Melons","Melons"},
                { "Noix","Nuts"},
                { "Raisin","Grapes"},
                { "Pruneaux","Plums"},
                { "Myrtilles","Blueberries"},
                { "Groseilles","Berries"},
                { "Tomates","Tomatoes"},
                { "Courges","Pumpkins"},
                { "Pêches","Peaches"},
                { "Haricots","Beans"}
            };

            products.Select(product => product.Producer.Substring(0, 3) + "..." + product.Producer.Last())
                .ToList()
                .ForEach(p => Console.WriteLine(p));

            products.Select(product => product.ProductName = i18n[product.ProductName])
                .ToList()
                .ForEach(p => Console.WriteLine(p));

            products.Select(product => product.Quantity * product.PricePerUnit)
                .ToList()
                .ForEach(p => Console.WriteLine(p));

            //partie faite par chatgpt pour l'alignement (sans utilisation de Select)
            /*products.ForEach(product =>
            {
                string producerName = product.Producer.Substring(0, 3) + "..." + product.Producer.Last();

                string productName = i18n[product.ProductName];

                double CA = product.Quantity * product.PricePerUnit;

                Console.WriteLine("{0,-10} | {1,-15} | {2,10:0.00}", producerName, productName, CA);
            });*/
        }
    }


}
