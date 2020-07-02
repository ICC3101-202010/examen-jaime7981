using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO.Tipo_de_Jugadores
{
    class Delantero : Jugador
    {
        
        public Delantero(string nombre, int edad, string nacionalidad, int sueldo, int ataque, int defensa, int camiseta, int fatiga) :
            base(nombre, edad, nacionalidad, sueldo, ataque, defensa, camiseta, fatiga)
        {

        }
    }
}
