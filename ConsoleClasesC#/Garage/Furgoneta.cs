using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasesC_.Garage
{
    internal class Furgoneta : IAlquilable
    {
        public string Identificador { get; set; }
        public double PrecioHora { get; set; } = 6;
        public double Tiempo { get; set; }

        public double DameCoste()
        {
            return PrecioHora + Tiempo;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string? ToString()
        {
            return $"hOLA SOY UNA FURGONETA CON PRECIO HORA: {this.PrecioHora}";
        }
    }
}
