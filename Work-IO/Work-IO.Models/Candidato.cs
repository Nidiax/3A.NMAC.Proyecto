using System;
using System.Collections.Generic;
using System.Text;

namespace Work_IO.Models
{
    class Candidato
    {
        public int CandidatoId { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public bool Genero { get; set; }
        //Fecha de Nacimiento
        public DateTime Fecha_Nam { get; set; }
        //Lugar de Nacimiento
        public string Lugar_Nam { get; set; }
        public int Edad { get; }
        public string Estado_civil { get; set; }
        public string Curp { get; set; }
        public string NSS { get; set; }
        public string RFC { get; set; }




    }
}
