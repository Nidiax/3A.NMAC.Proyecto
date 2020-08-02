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
    public class EditModel : PageModel
    {
        private readonly IRepositoryW<Candidato> repositoryW;
        public Candidato Candidato { get; set; }
        public EditModel(IRepositoryW<Candidato> repository)
        {
            this.repositoryW = repository;
        }

        public void OnGet()
        {
            

        }
    }
}