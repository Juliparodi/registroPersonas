using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registroPersonasLibrary
{
   public class Cliente : Persona
    {
        private int _codigo;
        public int Codigo => _codigo;
        public Cliente(int cod, string nombre, string apellido, string tipoDNI, string DNI, bool activo) : base(nombre, apellido, tipoDNI, DNI, activo)
        {
            _codigo = cod;
        }
    }
}
