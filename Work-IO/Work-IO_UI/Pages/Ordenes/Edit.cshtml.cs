using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages.Ordenes
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Orden Orden { get; set; }
        public Empresa Empresa { get; set; }
        public Asesor Asesor { get; set; }
        private readonly IRepositoryW<Orden> repositoryW;
        private readonly IRepositoryW<Empresa> repositoryWE;
        private readonly IRepositoryW<Asesor> repositoryWA;
        public IEnumerable<Empresa> ListEmpresa { get; set; }
        public IEnumerable<Asesor> ListAsesor { get; set; }
        public EditModel(IRepositoryW<Orden> repository, IRepositoryW<Empresa> repositoryWE, IRepositoryW<Asesor> repositoryWA)
        {
            this.repositoryW = repository;
            this.ListEmpresa = repositoryWE.GetAll();
            this.ListAsesor = repositoryWA.GetAll();
        }
        public IActionResult OnGet(int id)
        {
            Orden = repositoryW.Get(id);

            if (Orden.Id == 0)
                return RedirectToPage("/Ordenes/Index");
            return Page();
        }

        public IActionResult OnPost(Orden orden, string adios)
        {
            if (!ModelState.IsValid)
                return Page();

            if (adios == "Editar")
            {
                repositoryW.Update(orden);
            }
            if (adios == "Eliminar")
            {
                repositoryW.Delete(orden);
            }
            return RedirectToPage("/Ordenes/Index");
        }
    }
}