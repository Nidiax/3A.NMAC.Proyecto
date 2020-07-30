using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages.Candidatos
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Candidato Candidato { get; set; }
        public Nacionalidad Nacionalidad { get; set; }
        public Orden Orden { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }
        private readonly IRepositoryW<Candidato> repositoryW;
        private readonly IRepositoryW<Nacionalidad> repositoryWN;
        private readonly IRepositoryW<Orden> repositoryWO;
        public IEnumerable<Nacionalidad> ListNaci { get; set; }
        public IEnumerable<Orden> ListOrden { get; set; }
        public CreateModel(IRepositoryW<Candidato> repository, IRepositoryW<Nacionalidad> repositoryWN, IRepositoryW<Orden> repositoryWO, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repository;
            HostEnvironment = hostEnvironment;
            this.ListNaci = repositoryWN.GetAll();
            this.ListOrden = repositoryWO.GetAll();
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var id = repositoryW.Insert(Candidato);
            return RedirectToPage("/Referencias/Create");
        }
    }
}