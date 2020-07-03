using System;
using System.Collections.Generic;
using System.Text;

namespace Work_IO.Models
{
    //Hereda la clase BaseEntity
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
