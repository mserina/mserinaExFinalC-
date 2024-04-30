using mserinaExFinalC_.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace mserinaExFinalC_.servicios
{
    /// <summary>
    /// Contiene la implementacion de los metodos de operacionFicheros
    /// msm - 300424
    /// </summary>
    internal class OperacionesFicherosImplementacion : OperacionesFicherosInterfaz
    {
        public string creacionFicheroLog()
        {
            string rutaLog = "";

            try
            {
                DateTime fechaActual = DateTime.Today;
                string fechaString = fechaActual.ToString("ddMMyyyy");
                string extensionArchivo = ".txt";
                string rutaLogSinFecha = "C:\\Users\\csi23-mserina\\Desktop\\FICHEROS\\log-";
                rutaLog = string.Concat(rutaLogSinFecha, fechaString, extensionArchivo);

                
            }
            catch (IOException ex)
            {
                using (StreamWriter sw = new StreamWriter(Program.rutaLog, true))
                {
                    sw.WriteLine(ex.Message);
                }
            }
            return rutaLog; 
        }


        
        public void citas()
        {
            pacientesDto paciente;

            long idNuevo;
            int tamano = Program.listaPacientes.Count;

            if (tamano > 0)
            {
                idNuevo = Program.listaPacientes[tamano - 1].Id;
            }
            else
            {
                idNuevo = 1;
            }

            try
            {
                StreamReader sr = new StreamReader(Program.citas);

                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] campos = linea.Split(";");

                    long id = idNuevo;
                    string dni = campos[1];
                    string nombre = campos[2];
                    string apellidos = campos[3];
                    string especialidad = campos[4];
                    string fechaCita = campos[5];
                    bool asistenciaACita = Convert.ToBoolean(campos[6]);

                    paciente = new pacientesDto();

                    paciente.Id = id;
                    paciente.Nombre = nombre;
                    paciente.Apellidos =  apellidos;
                    paciente.Especialidad = especialidad;
                    paciente.FechaCita = fechaCita;
                    paciente.AsistenciaACita = asistenciaACita;

                    Program.listaPacientes.Add(paciente);
                }

            }
            catch (IOException ex)
            {
                using (StreamWriter sw = new StreamWriter(Program.rutaLog, true))
                {
                    sw.WriteLine(ex.Message);
                }
            }
        }
    }
}
