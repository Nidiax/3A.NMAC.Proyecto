using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Services;
using Work_IO.Models;

namespace Work_IO_UI.Pages.Empresas
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositoryW<Empresa> repositoryW;
        public IEnumerable<Empresa> Empresas { get; set; }
        public Empresa Empresa { get; private set; }
        public DetailsModel(IRepositoryW<Empresa> repositoryW)
        {
            this.repositoryW = repositoryW;
        }
        public void OnGet(int id)
        {
            Empresas = repositoryW.GetAll();
        }
    }
}