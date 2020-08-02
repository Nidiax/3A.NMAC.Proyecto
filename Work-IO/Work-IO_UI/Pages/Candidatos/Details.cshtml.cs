using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages.Candidatos
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositoryW<Candidato> repositoryW;
        public IEnumerable<Candidato> Candidatos { get; set; }
        public Candidato Candidato { get; private set; }
        public DetailsModel(IRepositoryW<Candidato> repository)
        {
            this.repositoryW = repository;
        }
        public void OnGet(int id)
        {
            Candidatos = repositoryW.GetAll();
        }
    }
}