using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Services;
using Work_IO.Models;
using Microsoft.AspNetCore.Hosting;

namespace Work_IO_UI.Pages.Ordenes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositoryW<Orden> repositoryW;
        public IEnumerable<Orden> Ordenes { get; set; }
        public Empresa Empresa { get; private set; }
        public IWebHostEnvironment HostEnvironment { get; }
        public IndexModel(IRepositoryW<Orden> repositoryW, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repositoryW;
            HostEnvironment = hostEnvironment;
        }
        public void OnGet()
        {
            Ordenes = repositoryW.GetAll();
        }
    }
}