using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Services;
using Work_IO.Models;
using Microsoft.AspNetCore.Hosting;

namespace Work_IO_UI.Pages.Referencia
{
    public class IndexModel : PageModel
    {
        private readonly IRepositoryW<Referencias> repositoryW;
        private readonly IRepositoryW<Candidato> repositoryWC;
        public IEnumerable<Referencias> Referencias { get; set; }
        public IEnumerable<Candidato> Candidatos2 { get; set; }
        public Referencias Referencia { get; set; }
        public Candidato Candidato { get; set; }
        public IWebHostEnvironment HostEnvironment { get; set; }
        public IndexModel (IRepositoryW<Referencias> repositoryW, IRepositoryW<Candidato> repositoryWC, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repositoryW;
            HostEnvironment = hostEnvironment;
            this.repositoryWC = repositoryWC;
        }

        public IActionResult OnGet(int id)
        {
            Referencias = repositoryW.GetAll();
            Candidatos2 = repositoryWC.GetAll();
            return Page();
        }
    }
}