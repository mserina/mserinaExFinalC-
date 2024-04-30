using mserinaExFinalC_.dtos;
using mserinaExFinalC_.servicios;

namespace mserinaExFinalC_
{
    /// <summary>
    /// Clase principal
    /// msm - 300424
    /// </summary>
    class Program
    {
        //log
        public static string rutaLog;

        //citas
        public static string citas = "C:\\Users\\csi23-mserina\\Desktop\\FICHEROS\\citas.txt";

        //lista
        public static List<pacientesDto> listaPacientes = new List<pacientesDto>();


        /// <summary>
        /// Metodo que contiene el procedimiento del programa
        /// msm - 300424
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            OperacionesFicherosInterfaz opf = new OperacionesFicherosImplementacion(); 
           

            bool cerrarMenu = false;
            int opcionSeleccionada;

            MenuInterfaz mi = new MenuImplementacion();
            OperacionesFicherosInterfaz op = new OperacionesFicherosImplementacion();
            rutaLog = op.creacionFicheroLog();
            
            try
            {
                while (!cerrarMenu)
                {
                    opcionSeleccionada = mi.opcionMostrar();

                    switch (opcionSeleccionada)
                    {
                        case 0:
                            using (StreamWriter sw = new StreamWriter(rutaLog ,true))
                            {
                                sw.WriteLine("Se cerro el menu");
                            }
                            cerrarMenu = true;
                            break;

                        case 1:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {
                                sw.WriteLine("Se abrio de registro llegada");
                            }
                            break;

                        case 2:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {
                                sw.WriteLine("Se abrio listado de consultas");
                            }
                            mi.listadoConsultaImplementacion();
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter(rutaLog, true))
                {
                    sw.WriteLine(ex.Message);
                }

            }
        }
    }
}