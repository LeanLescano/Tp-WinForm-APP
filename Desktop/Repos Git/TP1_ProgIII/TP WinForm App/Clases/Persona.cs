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
        public string estilosMusicales { get; set; }
        public string[] estilosList { get; set; }
        public string colorFavorito { get; set; }
        
        public Persona() { }

        public Persona(string nom, string ape, string fechNac, string sexo, string estilos, string[] lista, string color)
        {
            Nombre = nom;
            Apellido = ape;
            fechaNacimiento = fechNac;
            Sexo = sexo;
            estilosList = lista;
            estilosMusicales = estilos;
            colorFavorito = color;
        }
    }
}
