using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    public class Jugador : Persona
    {

        private int ataque;
        private int defensa;
        private int camiseta;
        private int fatiga;

        public Jugador(string nombre, int edad, string nacionalidad, int sueldo,
                      int ataque, int defensa, int camiseta, int fatiga) : base(nombre, edad, nacionalidad, sueldo)
        {
            this.ataque = ataque;
            this.defensa = defensa;
            this.camiseta = camiseta;
            this.fatiga = 100;
        }

        public void Lesion()
        {

        }
    }
}
