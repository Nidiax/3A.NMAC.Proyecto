using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Work_IO.Models
{
    //Hereda la clase BaseEntity
    public class Empresa : BaseEntity
    {

        //por seguridad sería bien que yo misma registre a la empresa, y le asigne un usuario//

        // [Display(Name ="Id")] //
        // [Key]
        // public int EmpresaId { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Este campo {0} es obligatorio")]
        public string Nombre { get; set; }
        [Display(Name = "Correo electrónico")]
        [EmailAddress(ErrorMessage = "Este campo {0} debe ser un correo electrónico válido")]
        public string Correo { get; set; }
        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Este campo {0} debe ser obligatorio")]
        public string Direccion { get; set; }
        [Display(Name = "Número teléfonico")]
        public int Numero { get; set; }

        //Asociaciones
        public ICollection<Orden> Ordenes { get; set; }
        

        
    }
}
