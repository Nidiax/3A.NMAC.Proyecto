using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages
{
    public class RegistroCandidatoModel : PageModel
    {
        [BindProperty]
        public Candidato Candidato { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        private readonly IRepositoryW<Candidato> repositoryW;
        public RegistroCandidatoModel(IRepositoryW<Candidato> repositoryW, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repositoryW;
            HostEnvironment = hostEnvironment;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var id = repositoryW.Insert(Candidato);

            return RedirectToPage("/RegistroReferencias");
        }

        public void OnGet()
        {

        }

        public string[] Genders = new[] { "Hombre", "Mujer" };
    }
}