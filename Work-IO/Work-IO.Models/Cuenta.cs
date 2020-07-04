using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Work_IO.Models
{
    //Hereda la clase BaseEntity
    public class Cuenta : BaseEntity
    {
       // [Key]
       // public int CuentaId { get; set; }
       [Display(Name ="Usuario")]
       public string Usuario { get; set; }
        [Display(Name ="Contraseña")]
       public string Contraseña { get; set; }

    }
}
