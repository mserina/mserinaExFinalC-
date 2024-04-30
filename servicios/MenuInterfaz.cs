using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mserinaExFinalC_.servicios
{
    /// <summary>
    /// Contiene las cabezera de los metodos de menu
    /// msm - 300424
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra el menu principal junto a la respuesta del usuario
        /// msm - 300424
        /// </summary>
        /// <returns>Devuelve la respuesta del usuario</returns>
        public int opcionMostrar();

        /// <summary>
        /// Muestra la el menu de listado de consultas 
        /// msm - 300424
        /// </summary>
        /// <returns>Devuelve la respuesta del usuario</returns>
        public void listadoConsultaImplementacion();
    }
}
