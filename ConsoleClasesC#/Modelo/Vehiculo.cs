using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasesC_.Modelo
{
    internal class Vehiculo
    {
        public double Potencia;
        public int NumRuedas;
        public double Velocidad;

        public double VelocidadMedia()
        {
            return Velocidad / NumRuedas;
        }

        public override string ToString()
        {
            return "Potencia: " + Potencia + ", Número de ruedas: " + NumRuedas + ", Velocidad: " + Velocidad + ", Velocidad Media: " + VelocidadMedia();
        }
    }
}
