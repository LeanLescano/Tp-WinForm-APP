using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string fechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public List<string> estilosMusicales = new List<string>();
        public string colorFavorito { get; set; }

        public Persona() { }

        public Persona(string nombre, string apellido, string fechNac, string sexo, List<string> estilos, string color)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.fechaNacimiento = fechNac;
            this.Sexo = sexo;
            this.estilosMusicales = estilos;
            this.colorFavorito = color;
        }
    }
}
