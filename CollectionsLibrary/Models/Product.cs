using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLibrary.Models
{
    public class Product : IComparable<Product>, IProduct
    {
        public int ProductNummer { get; set; }
        public string Merk { get; set; }
        public string Naam { get; set;}
        public int Volume { get; set; }
        public double Prijs { get; set; }

        public Product(int productnummer, string merk, string naam,int volume,double prijs)
        {
            ProductNummer = productnummer;
            Merk = merk;
            Naam = naam;
            Volume = volume;
            Prijs = prijs;
        }

        public Product()
        {
        }

        /*public List<Product> CompareTo(List<Product> products)
        {
            List<Product> prods = new List<Product>();
            for (int i = 0;i<prods.Count;i++) 
            {
                var product = products[i];
            }

           return List<Product> result = new List<Product>();
        }*/

        public int CompareTo(Product other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            Product prod = new Product();
            return $"{prod.ProductNummer} Merk: {prod.Merk.PadRight(20)}Naam: {prod.Naam.PadRight(26)}Volume: {prod.Volume.ToString()}ml      Prijs: €{Prijs},-    Code: {prod.GetProductCode()}";
        }
        public string GetProductCode()
        {             
            string merkSS = Merk.Substring(0,3);
            string naamSS = Naam.Substring(0,3);
            string concat = merkSS + naamSS;
            string vervang = Naam.Replace(" ", "_");
            string stringresult1 = concat + vervang;

            string volumSS = Volume.ToString();
            if (volumSS.Length > 3)
            { 
                volumSS = volumSS + "_";
            }

            string stringresult2 = stringresult1 + volumSS;
            return stringresult2.ToUpper();
        }
    }
}
