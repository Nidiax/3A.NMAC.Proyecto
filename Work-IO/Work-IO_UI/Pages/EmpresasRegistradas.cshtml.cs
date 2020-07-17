using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages
{
    public class EmpresasRegistradasModel : PageModel
    {
        public void OnGet()
        {
            Empresas = repositoryW.GetAll();
        }

        private readonly IRepositoryW<Empresa> repositoryW;
        public IEnumerable<Empresa> Empresas { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }
        
        public EmpresasRegistradasModel(IRepositoryW<Empresa> repositoryW, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repositoryW;
            HostEnvironment = hostEnvironment;
        }

    }
}