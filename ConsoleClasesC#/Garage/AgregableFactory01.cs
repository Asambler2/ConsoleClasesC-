using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasesC_.Garage
{
    internal class AgregableFactory01 : IFactoryAlquilable
    {
        public IAlquilable DameElemento(EnumTipos tipo, string id, double tiempo)
        {
            switch(tipo)
            {
                case EnumTipos.Coche: return new Coche { Identificador = id, Tiempo = tiempo };
                case EnumTipos.Furgoneta: return new Furgoneta { Identificador = id, Tiempo = tiempo };
                default: return null;
            }
        }
    }
}
