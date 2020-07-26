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
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            
        }

        private readonly IRepositoryW<Empresa> repositoryW;
        public IEnumerable<Empresa> Empresas { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }
        public IndexModel(IRepositoryW<Empresa> repositoryW, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repositoryW;
            HostEnvironment = hostEnvironment;
        }
    }
}