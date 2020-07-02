using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    class Médico : Persona
    {

        private int puntosDeExperiencia;

        public Médico(string nombre, int edad, string nacionalidad, int sueldo, int puntosDeExperiencia) : base(nombre, edad, nacionalidad, sueldo)
        {
            this.puntosDeExperiencia = puntosDeExperiencia;
        }

        public void EvaluarJugador()
        {

        }

        public void CurarJugdor()
        {

        }
    }
}
