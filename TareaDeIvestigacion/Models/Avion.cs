using System;
using System.Collections.Generic;
using System.Text;

namespace TareaDeIvestigacion.Models
{
    //esta será la clase base
    public abstract class Avion
    {
        //Propiedades de la clase base
        public string Azafata { get; set; }

        public string Copiloto { get; set; }

        public string Piloto { get; set; }

        //Metodos abstractos:

        public abstract string Despegar();

        public abstract string Aterrizar();

        //Metodo virtual que imprime o retorna lo que pide

        public virtual string Imprimir()
        {

            return $"Detalles del Avion:\n" +
                  $"\nEl piloto es: {Piloto}\n" +
                  $"El copiloto es: {Copiloto}\n";

        }



    }
}
