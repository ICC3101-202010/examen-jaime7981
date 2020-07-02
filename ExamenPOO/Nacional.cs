using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    class Nacional : Competencia
    {


        public Nacional() : base()
        {

        }

        public void ValidateAllTeams()
        {
            foreach (Equipo equipo in GetEquipos())
            {
                if (equipo.ValidateInternacionalTeam() == false)
                {
                    EliminarEquipo(equipo);
                }
            }
        }

        public void PartidoNacional()
        {
            foreach(Equipo equipo in equiposParticipantes)
            {
                foreach(Equipo equipolocal in equiposParticipantes)
                {
                    if (equipo != null && equipolocal != null)
                    {
                        Partido partido = new Partido(equipo, equipolocal, 90);
                        Equipo ganador = partido.GanadorPartido();
                        if (ganador == equipo)
                        {
                            equiposParticipantes.Remove(equipolocal);
                        }
                        else
                        {
                            equiposParticipantes.Remove(equipo);
                        }
                    }
                }
            }
        }
    }
}
