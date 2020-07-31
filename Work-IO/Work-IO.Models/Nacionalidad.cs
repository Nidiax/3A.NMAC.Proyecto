using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Work_IO.Models
{
    //Hereda la clase BaseEntity
    public class Nacionalidad : BaseEntity
    {
      //  [Key]
       // public int NacionalidadId { get; set; }
        //Tipo de nacionalidad
        [Display(Name ="Tipo de Nacionalidad")]
        public string TipoNa { get; set; }

    }
}
