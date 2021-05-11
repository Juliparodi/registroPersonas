using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registroPersonasLibrary
{
    public static class tipoDNIHelper
    {

        public static List<CodigoDescripcion> getListaTipoDni()
        {
            List<CodigoDescripcion> codigoDescripcions = new List<CodigoDescripcion>();

            codigoDescripcions.Add(new CodigoDescripcion(0, "SELECCIONE"));
            codigoDescripcions.Add(new CodigoDescripcion(1, "DNI"));
            codigoDescripcions.Add(new CodigoDescripcion(2, "PASAPORTE"));
            codigoDescripcions.Add(new CodigoDescripcion(3, "REGISTRO CIVIL"));

            return codigoDescripcions;

        }
    }
}
