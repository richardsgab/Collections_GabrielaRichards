using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLibrary
{
    public interface IProduct
    {
        int ProductNummer { get; set; }
        string Merk { get; set; }
        string Naam { get; set; }
        int Volume { get; set; }
        double Prijs { get; set; }
    }
}
