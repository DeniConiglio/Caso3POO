using LibMedicoPaciente.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedicoPaciente.Models.Derivada
{
    public class Medico:Persona
    {
        public string Especialidad { get; set; }
        public Medico(string nombre, string especialidad):base(nombre)
        {
            Especialidad = especialidad;
        }

        public override string ToString()
        {
            return base.ToString() + Especialidad;
        }
    }
}
