using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registroPersonasLibrary
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        string tipoDNI;
        string DNI;
        bool activo;

        protected Persona(string nombre, string apellido, string tipoDNI, string dNI, bool activo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoDNI = tipoDNI;
            DNI1 = dNI;
            this.Activo = activo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string TipoDNI { get => tipoDNI; set => tipoDNI = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public bool Activo { get => activo; set => activo = value; }

        public override string ToString()
        {
            string act = "ACTIVO";
            if (!activo)
            {
                 act = "INACTIVO";
            }
            return nombre + apellido + " con DNI: " + DNI + " en estado: " + act;
        }
    }
}
