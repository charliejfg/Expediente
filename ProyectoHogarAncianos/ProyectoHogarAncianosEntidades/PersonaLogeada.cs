using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HjaContext;

namespace ProyectoHogarAncianosEntidades
{

    public class PersonaLogeada
    {
        private static Persona personaAcargo = null;

        public PersonaLogeada(Persona nuevoEncargado)
        {
            personaAcargo = nuevoEncargado;
        }

        public static Persona GetInstance()
        {
            if (personaAcargo == null)
                personaAcargo = new Persona();

            return personaAcargo;
        }
    }
}
