using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mserinaExFinalC_.servicios
{
    /// <summary>
    /// Contiene la cabezera de los metodos de operacionFicheros
    /// msm - 300424
    /// </summary>
    internal interface OperacionesFicherosInterfaz
    {
        /// <summary>
        /// Crea el nombre del fichero log
        /// msm - 300424
        /// </summary>
        /// <returns></returns>
        public string creacionFicheroLog();

        /// <summary>
        /// Saca los clientes del reigistro y los añade a las listas
        /// msm - 300424
        /// </summary>
        public void citas();
    }
}
