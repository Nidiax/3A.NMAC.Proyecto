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
       public string Usuario { get; set; }
       public string Contraseña { get; set; }

    }
}
