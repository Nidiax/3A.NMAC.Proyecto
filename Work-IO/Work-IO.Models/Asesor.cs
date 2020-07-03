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
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }


    }
}
