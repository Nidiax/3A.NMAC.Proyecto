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
        public void OnGet()
        {

        }
    }
}