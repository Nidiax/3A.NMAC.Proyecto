using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages.Ordenes
{
    public class CreateModel : PageModel
    {
        [BindProperty] 
        public Orden Orden { get; set; }
        public Empresa Empresa { get; set; }
        public Asesor Asesor { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }
        private readonly IRepositoryW<Orden> repositoryW;
        private readonly IRepositoryW<Empresa> repositoryWE;
        private readonly IRepositoryW<Asesor> repositoryWWW;
        public IEnumerable<Empresa> ListEmpresa { get; set; }
        public IEnumerable<Asesor> ListAsesor { get; set; }
        public CreateModel(IRepositoryW<Orden> repository,IRepositoryW<Empresa> repositoryWE, IRepositoryW<Asesor> repositoryWWW, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repository;
            HostEnvironment = hostEnvironment;
            this.ListEmpresa = repositoryWE.GetAll();
            this.ListAsesor = repositoryWWW.GetAll();
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var id = repositoryW.Insert(Orden);
            return RedirectToPage("/Candidatos/Create");
        }
    }
}