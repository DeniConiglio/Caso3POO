using LibMedicoPaciente.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibMedicoPaciente;

namespace LibMedicoPaciente.Models.Derivada
{
    public class Paciente:Persona
    {
            public override string ToString()
            {
                return Nombre;
            }
        
    }
}
