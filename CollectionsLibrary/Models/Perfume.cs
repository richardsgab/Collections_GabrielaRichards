using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLibrary.Models
{
    public class Perfume : Product
    {
        public Perfume(int productnummer, string merk, string naam, int volume, double prijs) : base(productnummer,merk, naam, volume, prijs)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
