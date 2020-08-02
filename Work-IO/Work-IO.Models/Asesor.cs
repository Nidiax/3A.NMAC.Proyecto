using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace Work_IO.Models
{
    //Hereda la clase BaseEntity
    public class Asesor : BaseEntity
    {
       // [Key]
      //  public int AsesorId { get; set; }
        [Display(Name ="Nombre")]
        public string Nombre { get; set; }
        [Display(Name ="Correo Electronico")]
        [EmailAddress(ErrorMessage = "Este campo {0} debe ser un correo electrónico válido")]
        public string Correo { get; set; }

        public ICollection<Orden> Ordenes { get; set; }
    }
}
