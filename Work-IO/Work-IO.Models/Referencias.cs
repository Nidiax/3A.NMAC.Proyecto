using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Text;

namespace Work_IO.Models
{
    //Hereda la clase BaseEntity
    public class Referencias : BaseEntity
    {
       // [Key]
      //  public int ReferenciasId { get; set; }
        [Display(Name ="Nombre")]
        [Required(ErrorMessage ="Este campo {0} es obligatorio")]
        public string Nombre { get; set; }
        [Display(Name ="Numero Teléfonico")]
        public int Telefono { get; set; }
        [Display(Name ="Direccion")]
        public string Direccion { get; set; }
        [Display(Name ="Nombre del Informante")]
        [Required(ErrorMessage ="Este campo {0} es obligatorio")]
        public string Nombre_informante { get; set; }
        [Display(Name ="Puesto del Informante")]
        [Required(ErrorMessage ="Este campo {0} es obligatorio")]
        public string Puesto_informante { get; set; }
        [Display(Name ="Puesto del Candidato")]
        public string Puesto_candidato { get; set; }
        [Display(Name ="Sueldo")]
        public int Sueldo { get; set; }
      //  [Display(Name ="Fecha de Inicio Laboral")]
      //  [Required(ErrorMessage ="Este campo {0} es obligatorio")]
       // public DateTime Inicio_laboral { get; set; }
      //  [Display(Name ="Fecha de Separación")]
     //   public DateTime Fecha_separacion { get; set; }
        [Display(Name ="Puestos Anteriores")]
        public string Puestos_anteriores { get; set; }
        [Display(Name ="Tipo de contrato")]
        public string Tipo_contrato { get; set; }
        [Display(Name ="Función del Último Puesto")]
        public string Fun_ultimopuesto { get; set; }
        [Display(Name ="Desempeño")]
        public string Desempeño { get; set; }
        [Display(Name ="Observaciones")]
        public string Observaciones { get; set; }


        //Asociaciones//
        public int CandidatoId { get; set; }
        public Candidato Candidato { get; set; }

    }
}
