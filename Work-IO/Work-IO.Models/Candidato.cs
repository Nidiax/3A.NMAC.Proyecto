using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Work_IO.Models
{
    //Hereda la clase BaseEntity
    public class Candidato : BaseEntity
    {
       // [Display(Name = "Id")]  //muestra el nombre la propiedad//
       // [Key]
       // public int CandidatoId { get; set; }
        [Display(Name = "Nombre")] //prompt es una marca de agua, parecido al placeholder//
        public string Nombre { get; set; }
        [Display(Name = "Genero")] //, Prompt ="Seleccione una opcion"//
        public bool Genero { get; set; }
        //Fecha de Nacimiento
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime Fecha_Nam { get; set; }
        //Lugar de Nacimiento
        [Display(Name = "Lugar de Nacimiento")]
        public string Lugar_Nam { get; set; }
        public int Edad { get; }
        public string Estado_civil { get; set; }
        [Display(Name = "CURP")]
        [Required(ErrorMessage = "Este campo {0} es obligatorio")] //mostrando un mensaje//
        public string Curp { get; set; }
        [Display(Name = "Numero de Seguro Social")]
        [Required(ErrorMessage = "Este campo {0} es obligatorio")]
        public int NSS { get; set; }
        [Display(Name = "RFC")]
        [Required(ErrorMessage = "Este campo {0} es obligatorio")]
        public int RFC { get; set; }

        //Asociaciones 
        //Asociaciones para orden
        public int OrdenId { get; set; }
        public Orden Orden { get; set; }
      //  public string TipoVacante { get; set; }

        //Asociaones para nacionalidad
        public int NacionalidadId { get; set; }
        public Nacionalidad Nacionalidad { get; set; }

        //Asociaciones para documentos
        public ICollection<Documento> Documentos { get; set; }

        //Asociaciones para referencias
        public ICollection<Referencias> Referencias { get; set; }
       
    }
}
