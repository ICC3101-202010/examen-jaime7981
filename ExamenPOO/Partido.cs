using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    class Partido
    {

        private Equipo visita;
        private Equipo local;

        public Partido(Equipo visita, Equipo local)
        {
            this.visita = visita;
            this.local = local;
        }

        public string NombrePartido()
        {
            return (visita.GetTeamName() + " VS " + local.GetTeamName());
        }
    }
}
