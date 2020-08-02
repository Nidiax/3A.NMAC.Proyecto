using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages.Candidatos
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Candidato Candidato { get; set; }

        public DeleteModel(AppDBContext context)
        {
            _context = context;
        }

        private readonly AppDBContext _context;

        public async Task<IActionResult> OnGetAsync(int ? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Candidato = await _context.Candidatos
                .Include(d => d.Orden).FirstOrDefaultAsync(k => k.Id == id);
            Candidato = await _context.Candidatos
                .Include(d => d.Nacionalidad).FirstOrDefaultAsync(k => k.Id == id);

            if(Candidato == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int ? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidato = await _context.Candidatos.FindAsync(id);

            if(Candidato != null)
            {
                _context.Candidatos.Remove(Candidato);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Candidatos/Index");
        }
        public void OnGet()
        {

        }
    }
}