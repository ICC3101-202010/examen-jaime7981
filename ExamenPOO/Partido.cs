using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    class Partido
    {
        private readonly Random _random = new Random();
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private Equipo visita;
        private Equipo local;
        private int tiempo;

        public Partido(Equipo visita, Equipo local, int tiempo)
        {
            this.visita = visita;
            this.local = local;
            this.tiempo = tiempo;
        }

        public int GetDuracionPartido()
        {
            return tiempo;
        }


        public string NombrePartido()
        {
            return (visita.GetTeamName() + " VS " + local.GetTeamName() + "\n");
        }

        public string JugadoresDelPartido()
        {
            string equipolocal = "";
            string equipovisita = "";

            foreach(Jugador jugador in local.GetEquipoTitular())
            {
                equipolocal += jugador.GetCamiseta() + ".- " + jugador.GetPersonName() + "\n";
            }
            foreach (Jugador jugador in visita.GetEquipoTitular())
            {
                equipovisita += jugador.GetCamiseta() + ".- " + jugador.GetPersonName() + "\n";
            }

            return "Jugadores:\n" + equipolocal + "\n" + equipovisita;
        }

        public Equipo GanadorPartido()
        {
            if (RandomNumber(0,2) == 1)
            {
                local.SetPartidosganados();
                return local;
            }
            else
            {
                visita.SetPartidosganados();
                return visita;
            }
        }

    }
}
