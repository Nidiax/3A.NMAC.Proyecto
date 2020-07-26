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
    public class DetailsModel : PageModel
    {
        private readonly AppDBContext _context;
        public Empresa Empresa { get; set; }
        public DetailsModel(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
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
       
    }
}