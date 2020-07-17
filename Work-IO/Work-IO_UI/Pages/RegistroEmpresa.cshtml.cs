using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages
{
    public class RegistroModel : PageModel
    {
   
        [BindProperty]
        public Empresa Empresa { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        private readonly IRepositoryW<Empresa> repositoryW;
        public RegistroModel(IRepositoryW<Empresa>repositoryW, IWebHostEnvironment hostEnvironment )
        {
            this.repositoryW = repositoryW;
            HostEnvironment = hostEnvironment;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var id = repositoryW.Insert(Empresa);

                return RedirectToPage("/RegistroCandidato");
        }

        public void OnGet()
        {

        }



    }
}