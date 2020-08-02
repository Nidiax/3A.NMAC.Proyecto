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
        public IEnumerable<Referencias> Referencias { get; set; }
        public Referencias Referencia { get; private set; }
        public IWebHostEnvironment HostEnvironment { get; set; }
        public IndexModel (IRepositoryW<Referencias> repositoryW, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repositoryW;
            HostEnvironment = hostEnvironment;
        }

        public void OnGet()
        {
            Referencias = repositoryW.GetAll();
        }
    }
}