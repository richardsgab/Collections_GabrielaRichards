using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLibrary.Models
{
    public class Processes
    {
        public static void WriteToFile(List<Product> products, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true)) 
            {
                for (int i = 0; i < products.Count; i++)
                {
                    sw.WriteLine(products[i].ProductNummer);
                    sw.WriteLine(products[i].Merk);
                    sw.WriteLine(products[i].Naam);
                    sw.WriteLine(products[i].Volume);
                    sw.WriteLine(products[i].Prijs);
                }
            }
        }
        public static List<Product> Populate()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { ProductNummer = 0, Merk = "BVLGARI", Naam = "BLV", Volume = 75, Prijs = 61.52 });
            products.Add(new Product { ProductNummer = 0, Merk = "Cacharel", Naam = "Anais", Volume = 50, Prijs = 24.52 });
            products.Add(new Product { ProductNummer = 0, Merk = "DKNY", Naam = "Be Delicious Woman", Volume = 100, Prijs = 33.65 });
            products.Add(new Product { ProductNummer = 0, Merk = "Dolce & Gabbana", Naam = "Light Blue", Volume = 100, Prijs = 66.52 });
            products.Add(new Product { ProductNummer = 0, Merk = "Giorgio Armani", Naam = "Code Donna", Volume = 50, Prijs = 59.52 });
            products.Add(new Product { ProductNummer = 0, Merk = "Giorgio Armani", Naam = "Code Donna", Volume = 30, Prijs = 39.52 });
            products.Add(new Product { ProductNummer = 0, Merk = "Giorgio Armani", Naam = "Code Donna", Volume = 75, Prijs = 79.52 });
            products.Add(new Product { ProductNummer = 0, Merk = "Givenchy", Naam = "Absolutely Irresistible", Volume = 75, Prijs = 75.52 });
            products.Add(new Product { ProductNummer = 0, Merk = "Ted Lapidus", Naam = "Pour Elle", Volume = 50, Prijs = 44.52 });
            products.Add(new Product { ProductNummer = 0, Merk = "Yves Saint Laurent", Naam = "Jazz", Volume = 50, Prijs = 39.52 });
            products.Add(new Product { ProductNummer = 0, Merk = "Yves Saint Laurent", Naam = "Jazz", Volume = 100, Prijs = 57.52 });

            return products;
        }
    }
}
