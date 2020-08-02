using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Work_IO.Models;


namespace Work_IO.Services
{
    /*
    public class ContainerRepository : IProyecto
    {
        AppDBContext context;
        public ContainerRepository(AppDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Candidato> GetCandidatosbyOrden(int id)
        {
            throw new NotImplementedException();
        }

        public Empresa GetOrdbyEmpresa(int id)
        {
            throw new NotImplementedException();
        }

        public Orden GetOrden(int id)
        {
            throw new NotImplementedException();
        }

        public int InicioSesion(Cuenta cuenta)
        {
            var empresas = context.Empresas.Include(x => x.Cuenta).ToList();
            int numero = 0;

            foreach(var item in empresas)
            {
                if(cuenta.Contrasenia == item.Cuenta.Contrasenia && cuenta.Correo == item.Cuenta.Correo)
                {
                    numero = item.Id;
                }

               
            }

            return numero;
        }

    }
    */
    


}
