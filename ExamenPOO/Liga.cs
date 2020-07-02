using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    class Liga : Competencia
    { 

        private Dictionary<Equipo, int> puntosDeLiga;

        public Liga() : base()
        {
            puntosDeLiga = new Dictionary<Equipo, int>();
            foreach (Equipo equipo in equiposParticipantes)
            {
                puntosDeLiga.Add(equipo, 0);
            }
        }

        public void PartidosLiga()
        {
            foreach(Equipo equipovisita in equiposParticipantes)
            {
                foreach(Equipo equipolocal in equiposParticipantes)
                {
                    if (equipolocal != equipovisita)
                    {
                        Partido partido = new Partido(equipovisita, equipolocal, 90);
                        Equipo ganador = partido.GanadorPartido();
                        foreach (KeyValuePair<Equipo, int> result in puntosDeLiga)
                        {
                            if (ganador == result.Key)
                            {
                                puntosDeLiga[result.Key] += 3;
                            }
                        }
                    }
                }
            }
        }

    }
}
