using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string nacionalidad;
        private int sueldo;

        public Persona(string nombre, int edad, string nacionalidad, int sueldo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
            this.sueldo = sueldo;
        }

        public string InfoPersonal()
        {
            return ("Nombre: " + nombre + "\nEdad: " + edad + "\nNacionalidad: " + nacionalidad + "\nSueldo: " + sueldo);
        }
    }
}
