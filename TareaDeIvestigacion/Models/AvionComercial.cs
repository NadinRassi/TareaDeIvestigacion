using System;
using System.Collections.Generic;
using System.Text;

namespace TareaDeIvestigacion.Models
{
    public class AvionComercial:Avion
    {
        public int Capacidad { get; set; }

        public string LineaAerea { get; set;}

        //Aca sobreescribimos los metodos que vienen de la base, esto es polimorfismo, ya que si bien hacen algo, lo realizan de distinta manera

        public override string Aterrizar()
        {
            return "El avion Comercial esta aterrizando lentamente";
        }

        public override string Despegar()
        {
            return "El avion Comercial está despegando";
        }


        public override string ToString()
        {
            return base.Imprimir() + $"Azafata: {Azafata}\n" +
                                            $"Capacidad: {Capacidad}\n" +
                                            $"Linea Aerea: {LineaAerea}";
        }
    }
}
