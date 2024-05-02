namespace mserinaExFinalC_.dtos
{
    /// <summary>
    /// Clase que contiene los atributos y metodos de pacienteDto
    /// msm - 30042024
    /// </summary>
    internal class pacientesDto
    {
        //campos
        long id;
        string dni = "ddfdfdf";
        string nombre = "dffd";
        string apellidos = "sdfdfdfd";
        string especialidad = "fdffd";
        string fechaCita = "fdffdfd";
        bool asistenciaACita = false;

       


        //getters setters

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string FechaCita { get => fechaCita; set => fechaCita = value; }
        public bool AsistenciaACita { get => asistenciaACita; set => asistenciaACita = value; }


        //constructores

        public pacientesDto(long id, string dni, string nombre, string apellidos, string especialidad, string fechaCita, bool asistenciaACita)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            string[] apellidosSeparados = apellidos.Split(" ");
            string apellido1 = apellidosSeparados[0];
            string apellido2 = apellidosSeparados[1];
            string apellidoDefinitivo = string.Concat(apellido1, " ", apellido2);
            this.apellidos = apellidoDefinitivo;
            this.especialidad = especialidad;
            this.fechaCita = fechaCita;
            this.asistenciaACita = asistenciaACita;
        }

        public pacientesDto()
        {
            
        }

        //toSring
        
        override
        public string ToString()
        {
            string texto =
                id + ";" + dni + ";" +nombre + ";" + apellidos + ";" + especialidad + ";" + fechaCita + ";" +asistenciaACita;
            return texto;
            
        }
        
    }
}
