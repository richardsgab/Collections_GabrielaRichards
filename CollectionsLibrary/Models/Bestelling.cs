using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLibrary.Models
{
    public class Bestelling
    {
        static int productNummer = 1000;
        public List<Product> Bestellingen { get; set; }

        public Bestelling(List<Product> bestellingen)
        {            
            Bestellingen = bestellingen;
        }

        public Bestelling()
        {
        }

        public void VoegProductToe(Product prod)
        {
            Product product = new Product(); 
            product.ProductNummer = productNummer;
            product.Merk = prod.Merk;
            product.Naam = prod.Naam;
            product.Volume = prod.Volume;
            product.Prijs = prod.Prijs;
            prod.ProductNummer++;
            
            List<Product> bestellingen = new List<Product>();
            bestellingen.Add(product);
        }
        public override string ToString()
        {
            Product prod = new Product();
            return $"{prod.ProductNummer} Merk: {prod.Merk.PadRight(20)}Naam: {prod.Naam.PadRight(26)}Volume: {prod.Volume.ToString()}ml      Prijs: €{prod.Prijs},-    Code: {prod.GetProductCode()}";
        }

        public void ToonLijst()
        {
            List<Product> list = new List<Product>();
            Bestellingen = list;
            foreach (var item in Bestellingen) 
            {
                item.ToString();
            }
        }
        public void ToonPerMerk(string merk)
        {
            List<Product> bestellingen = new List<Product>();
            List<Product> sortedByMerk = new List<Product>();
            Product pr = new Product();
            for(int i = 0; i < bestellingen.Count; i++) 
            {
                pr = bestellingen[i];
                if(pr.Merk == merk) 
                {
                    sortedByMerk.Add(pr);
                }                
            }
            sortedByMerk.ToString();
        }
        public Product ZoekDuursteProduct()
        {
            List<Product> bestellingen = new List<Product>();
            Product pr = new Product();
            double prijsvalue = double.MinValue;
            for (int i = 0; i < bestellingen.Count; i++)
            {
                double hoogsteprijs = bestellingen[i].Prijs;
                if (hoogsteprijs > prijsvalue)
                { 
                    prijsvalue = hoogsteprijs;
                    pr = bestellingen[i];
                }
            }
            pr.ToString();

            return pr;
        }

        public void ToonParfums()
        {
            List<Product> products = new List<Product>();
                Console.WriteLine("Alle parfums");
            foreach (var pp in products)
            {               
                products.ToString();
            }
        }

    }
}
