using System;
using System.Collections.Generic;
using System.Text;

namespace Work_IO.Models
{
    //Implementar la interfaz
   public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAT { get; set; } = DateTime.Now;
        public DateTime? UpdatedAT { get; set; }
        public bool Estatus { get; set; } 
   }
}
