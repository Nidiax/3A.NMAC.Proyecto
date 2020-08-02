using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Services;
using Work_IO.Models;
using Microsoft.EntityFrameworkCore;

namespace Work_IO_UI.Pages.Empresas
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Empresa Empresa { get; set; }
        private readonly IRepositoryW<Empresa> repositoryW;
        public EditModel(IRepositoryW<Empresa> repository)
        {
            this.repositoryW = repository;
        }
        public IActionResult OnGet(int id)
        {
            Empresa = repositoryW.Get(id);

            if (Empresa.Id == 0)
                return RedirectToPage("/Empresas/Index");
            return Page();
        }

        public IActionResult OnPost(Empresa empresa, string adios)
        {
            if (!ModelState.IsValid)
                return Page();

            if(adios == "Editar")
            {
                repositoryW.Update(empresa);
            }
            if (adios == "Eliminar")
            {
                repositoryW.Delete(empresa);
            }
            return RedirectToPage("/Empresas/Index");
        }
        
    }
}