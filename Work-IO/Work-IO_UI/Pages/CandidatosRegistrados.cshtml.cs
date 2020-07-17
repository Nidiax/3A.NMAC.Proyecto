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
    public class CandidatosRegistradosModel : PageModel
    {
        public void OnGet()
        {
            Candidatos = repositoryW.GetAll();
        }

        private readonly IRepositoryW<Candidato> repositoryW;
        public IEnumerable<Candidato> Candidatos { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        public CandidatosRegistradosModel(IRepositoryW<Candidato> repositoryW, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repositoryW;
            HostEnvironment = hostEnvironment;
        }

      





    


    }
}