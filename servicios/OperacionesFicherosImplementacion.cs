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
                string rutaLogSinFecha = "C:\\Users\\Usuario\\Desktop\\ARCHIVOS\\log-";
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

            try
            {
                StreamReader sr = new StreamReader(Program.citas);

                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] campos = linea.Split(";");

                    long id = idGenerador();
                    string dni = campos[0];
                    string nombre = campos[1];
                    string apellidos = campos[2];
                    string especialidad = campos[3];
                    string fechaCita = campos[4];
                    bool asistenciaACita = Convert.ToBoolean(campos[5]);

                    paciente = new pacientesDto();

                    paciente.Id = id;
                    paciente.Dni = dni;
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

        public long idGenerador()
        {
            long idNuevo;
            int tamano = Program.listaPacientes.Count;

            if (tamano > 0)
            {
                idNuevo = Program.listaPacientes[tamano -1].Id + 1;
            }
            else
            {
                idNuevo = 1;
            }

            return idNuevo;
        }
    }
}
