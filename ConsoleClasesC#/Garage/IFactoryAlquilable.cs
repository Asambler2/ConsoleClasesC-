﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasesC_.Garage
{
    public interface IFactoryAlquilable
    {
        public IAlquilable DameElemento(EnumTipos tipo, string id, double tiempo);
    }
}
