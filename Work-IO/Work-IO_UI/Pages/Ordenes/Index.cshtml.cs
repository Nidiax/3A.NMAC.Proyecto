using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Services;
using Work_IO.Models;
using Microsoft.AspNetCore.Hosting;

namespace Work_IO_UI.Pages.Ordenes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositoryW<Orden> repositoryW;
        private readonly IRepositoryW<Empresa> repositoryWE;
        private readonly IRepositoryW<Asesor> repositoryWA;
        public IEnumerable<Orden> Ordenes { get; set; }
        public IEnumerable<Empresa> Empresas { get; set; }
        public IEnumerable<Asesor> Asesores { get; set; }
        public Empresa Empresa { get; set; }
        public Asesor Asesor { get; set; }
        public Orden Orden { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }
        public IndexModel(IRepositoryW<Orden> repositoryW, IRepositoryW<Asesor> repositoryWA, IRepositoryW<Empresa> repositoryWE, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repositoryW;
            HostEnvironment = hostEnvironment;
            this.repositoryWE = repositoryWE;
            this.repositoryWA = repositoryWA;
        }
        public IActionResult OnGet(int id)
        {
            Ordenes = repositoryW.GetAll();
            Asesores = repositoryWA.GetAll();
            Empresas = repositoryWE.GetAll();
            return Page();
        }
    }
}