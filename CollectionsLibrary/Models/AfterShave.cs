using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLibrary.Models
{
    public enum Soort
    {
        VAPO,
        GEL
    }
    public class AfterShave : Product
    {
        public Soort soort;
        public AfterShave(int productnummer, string merk, string naam, int volume, double prijs,Soort soort) : base(productnummer, merk, naam, volume, prijs)
        {
            this.soort = soort;
        }
        public override string ToString()
        {
            return base.ToString() + Soort.VAPO;
        }
       
    }
}
