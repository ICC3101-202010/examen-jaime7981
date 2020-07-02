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
        private List<Jugador> equipoTitular = new List<Jugador>();
        private int partidosGanados;
        private string nacionalidad;

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
            partidosGanados = 0;
        }

        public string GetTeamName()
        {
            return nombre;
        }
        public List<Jugador> GetEquipoTitular()
        {
            return equipoTitular;
        }
        public int GetPartidosGanador()
        {
            return partidosGanados;
        }

        public void SetPartidosganados()
        {
            partidosGanados += 1;
        }

        public void SetNacionalidad(string nacionalidad)
        {
            this.nacionalidad = nacionalidad;
        }

        public void AgregarArqueroTitular(Arquero arquero)
        {
            if (arqueros.Contains(arquero))
            {
                foreach(Jugador jugador in equipoTitular)
                {
                    if (jugador.GetTipo() == "Arquero")
                    {
                        equipoTitular.Remove(jugador);
                    }
                }
                equipoTitular.Add(arquero);
            }
        }

        public bool AgregarJugadorTitular(Jugador jugador)
        {
            if (equipoTitular.Count() <= 11 || jugador.GetTipo() == "Arquero")
            {
                foreach (Jugador jugadortitular in equipoTitular)
                {
                    if (jugadortitular == jugador)
                    {
                        return false;
                    }
                }
                equipoTitular.Add(jugador);
                return true;
            }
            return false;
        }

        public void QuitarJugadorTitular(Jugador jugador)
        {
            foreach(Jugador jugadortitular in equipoTitular)
            {
                if (jugadortitular == jugador)
                {
                    equipoTitular.Remove(jugador);
                }
            }
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

        public void QuitarPersona(Persona persona)
        {
            foreach (Arquero arquero in arqueros)
            {
                if (arquero == persona)
                {
                    arqueros.Remove(arquero);
                }
            }
            foreach (Defensa defensa in defensas)
            {
                if (defensa == persona)
                {
                    defensas.Remove(defensa);
                }
            }
            foreach (Mediocampo mediocampo in medioscampo)
            {
                if (mediocampo == persona)
                {
                    medioscampo.Remove(mediocampo);
                }
            }
            foreach (Delantero delantero in delanteros)
            {
                if (delantero == persona)
                {
                    delanteros.Remove(delantero);
                }
            }
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

        public bool ValidateInternacionalTeam()
        {
            if (nacionalidad != null)
            {
                bool internacional = true;
                foreach (Arquero arquero in arqueros)
                {
                    if (arquero.GetNacionalidad() != nacionalidad)
                    {
                        internacional = false;
                    }
                }
                foreach (Defensa defensa in defensas)
                {
                    if (defensa.GetNacionalidad() != nacionalidad)
                    {
                        internacional = false;
                    }
                }
                foreach (Mediocampo mediocampo in medioscampo)
                {
                    if (mediocampo.GetNacionalidad() != nacionalidad)
                    {
                        internacional = false;
                    }
                }
                foreach (Delantero delantero in delanteros)
                {
                    if (delantero.GetNacionalidad() != nacionalidad)
                    {
                        internacional = false;
                    }
                }
                return internacional;
            }
            return false;
        }

    }
}
