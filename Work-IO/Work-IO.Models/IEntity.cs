using System;
using System.Collections.Generic;
using System.Text;

namespace Work_IO.Models
{
    //Clases genéricas
    public interface IEntity
    {
        public int Id { get; set; }
        public bool Estatus { get; set; }
        public DateTime CreatedAT { get; set; }
        public DateTime? UpdatedAT { get; set; }

    }
}
