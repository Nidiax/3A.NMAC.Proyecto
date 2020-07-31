using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages.Referencia
{
    public class CreateModel : PageModel
    {
        public Referencias Referencias { get; set; }
        public Candidato Candidato { get; set; }
        public IWebHostEnvironment HostEnvironment { get; set; }
        private readonly IRepositoryW<Referencias> repositoryW;
        private readonly IRepositoryW<Candidato> repositoryWC;
        public IEnumerable<Candidato> ListCandi { get; set; }

        public CreateModel(IRepositoryW<Referencias>repository, IRepositoryW<Candidato> repositoryWC, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repository;
            HostEnvironment = hostEnvironment;
            this.ListCandi = repositoryWC.GetAll();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var id = repositoryW.Insert(Referencias);
            return RedirectToPage("/Menu");
        }
        public void OnGet()
        {

        }
    }
}