using ExamenPOO.Tipo_de_Jugadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    class Equipo
    {
        private string nombre;
        private int tamañoEquipo;
        private List<Arquero> arqueros;
        private List<Defensa> defensas;
        private List<Mediocampo> medioscampo;
        private List<Delantero> delanteros;
        private Entrenador entrenador;
        private Médico medico;

        public Equipo(string nombre, Entrenador entrenador, Médico medico)
        {
            this.nombre = nombre;
            this.tamañoEquipo = 0;
            this.arqueros = new List<Arquero>();
            this.defensas = new List<Defensa>();
            this.medioscampo = new List<Mediocampo>();
            this.delanteros = new List<Delantero>();
            this.entrenador = entrenador;
            this.medico = medico;
        }

        public string GetTeamName()
        {
            return nombre;
        }

        public void AgregarArquero(Arquero arquero)
        {
            if (tamañoEquipo <= 15)
            {
                tamañoEquipo += 1;
                arqueros.Add(arquero);
            }
        }

        public void AgregarDefensa(Defensa defensa)
        {
            if (tamañoEquipo <= 15)
            {
                tamañoEquipo += 1;
                defensas.Add(defensa);
            }
        }

        public void AgregarMedioCampo(Mediocampo mediocampo)
        {
            if (tamañoEquipo <= 15)
            {
                tamañoEquipo += 1;
                medioscampo.Add(mediocampo);
            }
        }

        public void AgregarDelantero(Delantero delantero)
        {
            if (tamañoEquipo <= 15)
            {
                tamañoEquipo += 1;
                delanteros.Add(delantero);
            }
        }

        public void CambiarEntrenador(Entrenador entrenador)
        {
            this.entrenador = entrenador;
        }

        public void CambiarMedico(Médico medico)
        {
            this.medico = medico;
        }

        public int CantidadDeJugadores()
        {
            int numerodejugadores = 0;
            foreach(Arquero arquero in arqueros)
            {
                numerodejugadores += 1;
            }
            foreach(Defensa defensa in defensas)
            {
                numerodejugadores += 1;
            }
            foreach(Mediocampo mediocampo in medioscampo)
            {
                numerodejugadores += 1;
            }
            foreach(Delantero delantero in delanteros)
            {
                numerodejugadores += 1;
            }
            return numerodejugadores;
        }
    }
}
