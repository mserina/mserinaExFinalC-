using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace mserinaExFinalC_.servicios
{
    /// <summary>
    /// Contiene la implementacion de los metodos de menu
    /// msm - 300424
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        public int opcionMostrar()
        {
            try
            {
                int opcion;

                Console.WriteLine(" ");
                Console.WriteLine("--SALA DE ESPERA--");
                Console.WriteLine("0[] CERRAR");
                Console.WriteLine("1[] REGISTRO LLEGADA");
                Console.WriteLine("2[] LISTADO DE CONSULTAS");
                Console.WriteLine(" ");

                opcion = Convert.ToInt32(Console.ReadLine());
                return opcion;
            } 
            catch (Exception e)
            {
                throw;
            }

        }

        private int opcionMostrarListadoConsulta()
        {
            try
            {
                int opcion;

                Console.WriteLine(" ");
                Console.WriteLine("--LISTADOS DE CONSULTA--");
                Console.WriteLine("0[] VOLVER ATRAS");
                Console.WriteLine("1[] MOSTRAR CONSULTAS");
                Console.WriteLine("2[] IMPRIMIR CONSULTA");
                Console.WriteLine(" ");

                opcion = Convert.ToInt32(Console.ReadLine());
                return opcion;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private int opcionMostrarEspecialidades()
        {
            try
            {
                int opcion;

                Console.WriteLine(" ");
                Console.WriteLine("--LISTADOS DE CONSULTA--");
                Console.WriteLine("0[] VOLVER ATRAS");
                Console.WriteLine("1[] PSICOLOGIA");
                Console.WriteLine("2[] TRAUMATOLOGIA");
                Console.WriteLine("3[] FISIOTERAPEUTA");
                Console.WriteLine(" ");

                opcion = Convert.ToInt32(Console.ReadLine());
                return opcion;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public  void listadoConsultaImplementacion()
        {

            bool cerrarMenu = false;
            int opcionSeleccionada;

            try
            {
                while (!cerrarMenu)
                {
                    opcionSeleccionada = opcionMostrarListadoConsulta();

                    switch (opcionSeleccionada)
                    {
                        case 0:
                            using (StreamWriter sw = new StreamWriter(Program.rutaLog, true))
                            {
                                sw.WriteLine("Se abrio la opcion volver al menu anteror");
                            }
                            cerrarMenu = true;
                            break;
                        case 1:
                            using (StreamWriter sw = new StreamWriter(Program.rutaLog, true))
                            {
                                sw.WriteLine("Se abrio la opcion mostrar consulta");
                            }

                            cerrarMenu = true;
                            break;
                        case 2:
                            using (StreamWriter sw = new StreamWriter(Program.rutaLog, true))
                            {
                                sw.WriteLine("Se abrio la opcion imprimir consulta");
                            }
                            mostrarEspecialidadesImplementacion();
                            cerrarMenu = true;
                            break;

                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void mostrarEspecialidadesImplementacion()
        {

            bool cerrarMenu = false;
            int opcionSeleccionada;

            try
            {
                while (!cerrarMenu)
                {
                    opcionSeleccionada = opcionMostrarEspecialidades();

                    switch (opcionSeleccionada)
                    {
                        case 0:
                            using (StreamWriter sw = new StreamWriter(Program.rutaLog, true))
                            {
                                sw.WriteLine("Se abrio la opcion volver al menu anteror");
                            }
                            cerrarMenu = true;
                            break;
                        case 1:
                            using (StreamWriter sw = new StreamWriter(Program.rutaLog, true))
                            {
                                sw.WriteLine("Se abrio la opcion psicologia");
                            }
                            cerrarMenu = true;
                            break;
                        case 2:
                            using (StreamWriter sw = new StreamWriter(Program.rutaLog, true))
                            {
                                sw.WriteLine("Se abrio la opcion traumatologia");
                            }
                            cerrarMenu = true;
                            break;
                        case 3:
                            using (StreamWriter sw = new StreamWriter(Program.rutaLog, true))
                            {
                                sw.WriteLine("Se abrio la opcion fisioterapeuta");
                            }
                            cerrarMenu = true;
                            break;

                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }






    }
}
