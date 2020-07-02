using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO.Tipo_de_Jugadores
{
    class Mediocampo : Jugador
    {


        public Mediocampo(string nombre, int edad, string nacionalidad, int sueldo, int ataque, int defensa, int camiseta, int fatiga, string tipo) :
            base(nombre, edad, nacionalidad, sueldo, ataque, defensa, camiseta, fatiga, tipo)
        {
            tipo = "Mediocampo";
        }
    }
}
