using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    class Entrenador : Persona
    {
        private int puntosDeTactica;

        public Entrenador(string nombre, int edad, string nacionalidad, int sueldo, int puntosDeTactica) : base(nombre, edad, nacionalidad, sueldo)
        {
            this.puntosDeTactica = puntosDeTactica;
        }

        public void CambiarJugador(string nombreSaliente, string nombreEntrante)
        {

        }
    }
}
