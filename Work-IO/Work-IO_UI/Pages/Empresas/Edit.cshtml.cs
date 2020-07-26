using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages.Empresas
{
    public class EditModel : PageModel
    {
        private readonly AppDBContext _context;
        public void OnGet()
        {

        }

        public EditModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Empresa Empresa { get; set; }

        public async Task<IActionResult> OnGetAsync (int ? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Empresa = await _context.Empresas
                .Include(d => d.OrdenId).FirstOrDefaultAsync(k => k.OrdenId == id);

            if (Empresa == null)
            {
                return NotFound();
            }

            ViewData["OrdenId"] = new SelectList(_context.Ordenes, "OrdenId", "Nombre");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Empresa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaExists(Empresa.OrdenId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }

               
            }

            return RedirectToPage("/Empresas/Index");
        }
        private bool EmpresaExists(int id)
        {
            return _context.Empresas.Any(a => a.OrdenId == id);
        }
    }
}