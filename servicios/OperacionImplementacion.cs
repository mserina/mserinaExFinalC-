using mserinaExFinalC_.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace mserinaExFinalC_.servicios
{
    /// <summary>
    /// Clase que contiene la implemetacion de los metodos del servicio operacion
    /// msm - 020524
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {

        public void verPacientes()
        {
            foreach (pacientesDto paciente in Program.listaPacientes)
            {
                Console.WriteLine(" ");
                Console.WriteLine(paciente.Dni);
                Console.WriteLine(" ");
            }
        }
        
        public void registroDeLlegada()
        {
            try
            {
                Console.WriteLine("Inserte su DNI");
                string dni = Console.ReadLine();
                DateTime ahora = DateTime.Today;
                bool dniEncontrado = false;
                foreach (pacientesDto paciente in Program.listaPacientes)
                {
                    DateTime fechaPaciente = Convert.ToDateTime(paciente.FechaCita);
                    if (dni.Equals(paciente.Dni))
                    {
                        if (fechaPaciente.ToString("dd-MM-yyyy").Equals(ahora.ToString("dd-MM-yyyy")))
                        {
                            if (paciente.Especialidad.Equals("Psicología"))
                            {
                                dniEncontrado = true;
                                Console.WriteLine(" ");
                                Console.WriteLine("Espere su turno para la consulta de Psicología en la sala de espera. Su especialista le avisará.");
                                paciente.AsistenciaACita = true;
                                Console.WriteLine(" ");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No dispone de cita previa para hoy");
                                break;
                            }
                            if (paciente.Especialidad.Equals("Fisioterapia"))
                            {
                                dniEncontrado = true;
                                Console.WriteLine(" ");
                                Console.WriteLine("Espere su turno para la consulta de Fisioterapia en la sala de espera. Su especialista le avisará.");
                                paciente.AsistenciaACita = true;
                                Console.WriteLine(" ");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No dispone de cita previa para hoy");
                                break;
                            }
                            if (paciente.Especialidad.Equals("Traumatologia"))
                            {
                                dniEncontrado = true;
                                Console.WriteLine(" ");
                                Console.WriteLine("Espere su turno para la consulta de Traumatologia en la sala de espera. Su especialista le avisará.");
                                paciente.AsistenciaACita = true;
                                Console.WriteLine(" ");
                                break;  
                            }
                            else
                            {
                                Console.WriteLine("No dispone de cita previa para hoy");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No dispone de cita previa para hoy");
                            break;
                        }

                    }
                }

                if (!dniEncontrado)
                {
                    Console.WriteLine("El DNI no existe");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
    }
}
