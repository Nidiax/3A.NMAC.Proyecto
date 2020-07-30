using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Models;
using Work_IO.Services;


namespace Work_IO_UI.Pages.Empresas
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Empresa Empresa { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        private readonly IRepositoryW<Empresa> repositoryW;
        public CreateModel(IRepositoryW<Empresa> repository, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repository;
            HostEnvironment = hostEnvironment;

        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var id = repositoryW.Insert(Empresa);
            return RedirectToPage("/Ordenes/Create");
        }
    }
}