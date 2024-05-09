using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasesC_.Garage
{
    internal class VisionadorConsola : IVisionable
    {
        public string DameCadena(IAlquilable elemento)
        {
            Console.WriteLine($"Hola soy un elemento: {elemento.GetType()} i mi id es: {elemento.Identificador} " +
                $"con un precio hora de: {elemento.PrecioHora} y un tiempo de: {elemento.Tiempo} y un coste de: {elemento.DameCoste()}");
            return "";
        }
    }
}
