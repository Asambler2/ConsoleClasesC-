using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasesC_.Modelo
{   // El coche debía ser Coche con mayúscula:
    public class coche
    {
        public coche(string matricula, bool cabe = false)
        {
            this.matricula = matricula;
            this.cabe = cabe;
        }
        public coche()
        {
        
        }


        //Lectura y escritura
        public string matricula { get; set; }
        
        public bool cabe {  get; set; } 

        public override string ToString()
        {
            return "Matricula: " + this.matricula + ", Cabe: " + this.cabe;        
        }

        public override bool Equals(object? obj)
        {
            return obj is coche coche && matricula == coche.matricula && cabe == coche.cabe;
        }

        public int CompareTo(coche other)
        {
            return this.matricula.CompareTo(other.matricula);   
        }
    }
}
