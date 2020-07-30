using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Work_IO.Models
{
    //Hereda la clase BaseEntity
    public class Documento : BaseEntity
    {
       // [Key]
       // public int DocumentoId { get; set; }
        
        //tipo de documento
        [Display(Name ="Tipo de Documentación")]
        public string TipoD { get; set; }

       //Asociacion de candidato
       public int CandidatoId { get; set; }
        public Candidato Candidato { get; set; }
    }
}
