using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLibrary.Models
{
    public class Deodorant : Product
    {
        public enum DeoType
        {
            VAPO, 
            STICK
        }
        DeoType soort;
        public Deodorant(int productnummer, string merk, string naam, int volume, double prijs, DeoType soort) : base(productnummer, merk, naam, volume, prijs)
        {
            this.soort = soort;
        }       
        public override string ToString()
        {
            return base.ToString() + DeoType.STICK;
        }
    }
}
