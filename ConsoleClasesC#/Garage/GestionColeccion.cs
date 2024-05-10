using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasesC_.Garage
{
    public class GestionColeccion
    {
        private double Total;
        private List<IAlquilable> Alquileres = new();

        public void Add(IAlquilable elemento)
        {
            this.Alquileres.Add(elemento);
            this.Total += elemento.DameCoste();
        }

        public double DameTotal()
        {
            return Total;
        }
    }
}
