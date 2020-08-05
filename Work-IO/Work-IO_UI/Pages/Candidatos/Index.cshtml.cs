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
    public class IndexModel : PageModel
    {
        private readonly IRepositoryW<Candidato> repositoryW;
        private readonly IRepositoryW<Nacionalidad> repositoryWN;
        private readonly IRepositoryW<Orden> repositoryWO;
        public IEnumerable<Candidato> Candidatos { get; set; }
        public IEnumerable<Nacionalidad> Nacionalidades { get; set; } 
        public IEnumerable<Orden> Ordens { get; set; }
        public Candidato Candidato { get; set; }
        public Nacionalidad Nacionalidad { get; set; }
        public Orden Orden { get; set; }
        public IWebHostEnvironment HostEnvironment { get; set; }
        public IndexModel(IRepositoryW<Candidato> repositoryW, IRepositoryW<Nacionalidad> repositoryWN, IRepositoryW<Orden> repositoryWO, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repositoryW;
            HostEnvironment = hostEnvironment;
            this.repositoryWN = repositoryWN;
            this.repositoryWO = repositoryWO;
        }
        public IActionResult OnGet(int id)
        {
            Candidatos = repositoryW.GetAll();
            Nacionalidades = repositoryWN.GetAll();
            Ordens = repositoryWO.GetAll();
            return Page();
        }
    }
}