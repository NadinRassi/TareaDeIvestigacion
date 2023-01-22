using System;
using System.Collections.Generic;
using System.Text;

namespace TareaDeIvestigacion.Models
{
    public class AvionDeCarga:Avion
    {
        public string TipoCarga { get; set; }

        public double Peso { get; set; }

        public override string Aterrizar()
        {
            return "Avion de carga aterrizando";
        }

        public override string Despegar()
        {
            return "Avion de carga despegando";
        }
    }
}
