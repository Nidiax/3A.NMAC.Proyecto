using System;
using System.Collections.Generic;
using System.Text;
using Work_IO.Models;

namespace Work_IO.Services
{
    
    public interface IProyecto
    {
        public Asesor GetOrdbyAsesor(int id);
        public Orden GetOrden(int id);
        public IEnumerable<Candidato> GetCandidatosbyOrden(int id);
        public int InicioSesion(Cuenta cuenta);
    }
    
}
