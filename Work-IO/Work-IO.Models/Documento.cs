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
        public string TipoD { get; set; }

        //A un candidato le pertenece los documentos
    }
}
