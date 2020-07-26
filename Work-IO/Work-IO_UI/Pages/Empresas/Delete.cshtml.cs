using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages.Empresas
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Empresa Empresa { get; set; }
        private readonly AppDBContext _context;
        public DeleteModel (AppDBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnGetAysnc(int ? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Empresa = await _context.Empresas
                .Include(d => d.OrdenId).FirstOrDefaultAsync(k => k.Id == id);

            if (Empresa == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync( int ? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Empresa = await _context.Empresas.FindAsync(id);

            if (Empresa != null)
            {
                _context.Empresas.Remove(Empresa);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Empresas/Index");
        }
    }
}