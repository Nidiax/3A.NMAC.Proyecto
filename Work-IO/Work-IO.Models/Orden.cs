using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Work_IO.Models
{
    //Hereda la clase BaseEntity
    public class Orden : BaseEntity
   {
       // [Key]
      //  public int OrdenId { get; set; }
        public string TipoVacante { get; set; }
      //  public string Estatus { get; set; }

        //Asociaciones con Empresa
        //Una orden puede estar en una empresa
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

        //Asociones con Candidato
        //Una orden le pertenece a un candidato
        public ICollection<Candidato> Candidatos { get; set; }

        //Asociaciones con Asesor
        public int AsesorId { get; set; } //sirve para identificar
        public Asesor Asesor { get; set; } //sirve para navegar
   }
}
