using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Services;
using Work_IO.Models;
using Microsoft.AspNetCore.Hosting;

namespace Work_IO_UI.Pages.Empresas
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositoryW<Empresa> repositoryW;
        public IEnumerable<Empresa> Empresas { get; set; }
       // public IWebHostEnvironment HostEnvironment { get; }
        [BindProperty]
        public Empresa Empresa { get; set; }
        public DetailsModel(IRepositoryW<Empresa> repository)
        {
            this.repositoryW = repository;
        }
        public IActionResult Get(int id)
        {
            Empresa = repositoryW.Get(id);
            return Page();
        }
    }
}