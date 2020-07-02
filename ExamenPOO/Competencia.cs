using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    class Competencia
    {
        protected List<Equipo> equiposParticipantes;
        private string nombre;


        public Competencia()
        {
            this.equiposParticipantes = new List<Equipo>();
        }

        public List<Equipo> GetEquipos()
        {
            return equiposParticipantes;
        }

        public bool AgregarEquipo(Equipo equipo)
        {
            foreach(Equipo equipos in equiposParticipantes)
            {
                if (equipo == equipos)
                {
                    return false;
                }
            }
            equiposParticipantes.Add(equipo);
            return true;
        }

        public void EliminarEquipo(Equipo equipo)
        {
            equiposParticipantes.Remove(equipo);
        }

        public string MostrarEquipos()
        {
            string participantes = "";
            int count = 1;
            foreach (Equipo equipos in equiposParticipantes)
            {
                participantes += count + ".- " + nombre + "\n";
                count += 1;
            }
            return participantes;
        }
    }
}
