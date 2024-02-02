using CollectionsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_GabrielaRichards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string path = @"c:\temptest\collections.txt";
            
            /*Product product = new Product();*/
            List<Product> products = new List<Product>();

            Bestelling bb = new Bestelling(products);
            bb.VoegProductToe(new Perfume(0, "BVLGARI", "BLV", 75, 61.52));
            bb.VoegProductToe(new Perfume(0, "Cacharel", "Anais", 50, 24.52));
            bb.VoegProductToe(new Perfume(0, "DKNY", "Be Delicious Woman", 100, 33.65));
            bb.VoegProductToe(new Perfume(0, "Dolce & Gabbana", "Light Blue", 100, 66.52));
            bb.VoegProductToe(new Perfume(0, "Giorgio Armani", "Code Donna", 50, 59.52));
            bb.VoegProductToe(new Perfume(0, "Giorgio Armani", "Code Donna", 30, 39.52));
            bb.VoegProductToe(new Perfume(0, "Giorgio Armani", "Code Donna", 75, 79.52));
            bb.VoegProductToe(new Perfume(0, "Givenchy", "Absolutely Irresistible", 75, 75.52));
            bb.VoegProductToe(new Perfume(0, "Ted Lapidus", "Pour Elle", 50, 44.52));
            bb.VoegProductToe(new Perfume(0, "Yves Saint Laurent", "Jazz", 50, 39.52));
            bb.VoegProductToe(new Perfume(0, "Yves Saint Laurent", "Jazz", 100, 57.52));
            bb.ToonLijst();
            bb.ToonPerMerk("Giorgio Armani");

            products = Processes.Populate();
            Processes.WriteToFile(products, path);
        }
    }
}
