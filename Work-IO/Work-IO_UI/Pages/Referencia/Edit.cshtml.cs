using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages.Referencia
{
    public class EditModel : PageModel
    {
        private readonly IRepositoryW<Referencias> repositoryW;
        private readonly IRepositoryW<Candidato> repositoryWC;
        [BindProperty]
        public Referencias Referencias { get; set; }
        public Candidato Candidato { get; set; }
        public IEnumerable<Referencias> ListReferencias { get; set; }
        public IEnumerable<Candidato> ListCandidatos { get; set; }
        public EditModel(IRepositoryW<Referencias> repository, IRepositoryW<Candidato> repositoryWC)
        {
            this.repositoryW = repository;
            this.ListCandidatos = repositoryWC.GetAll();
        }
        public IActionResult OnGet(int id)
        {
            Referencias = repositoryW.Get(id);

            if (Referencias.Id == 0)
                return RedirectToPage("/Referencias/Index");
            return Page();
        }

        public IActionResult OnPost(Referencias referencias, string adios)
        {
            if (!ModelState.IsValid)
                return Page();

            if(adios == "Editar")
            {
                repositoryW.Update(referencias);
            }
            if (adios == "Eliminar")
            {
                repositoryW.Delete(referencias);
            }
            return RedirectToPage("/Referencia/Index");
        }
    }
}