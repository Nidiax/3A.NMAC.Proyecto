using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Services;
using Work_IO.Models;
using Microsoft.Extensions.Logging;

namespace Work_IO_UI.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;
        public IProyecto repository;

        [BindProperty]
        public Cuenta Cuenta { get; set; }

        public int cont;
        public void OnGet()
        {
        }
        public LoginModel(ILogger<LoginModel> logger, IProyecto repository)
        {
            _logger = logger;
            this.repository = repository;
        }

        public IActionResult OnPost()
        {
            cont = repository.InicioSesion(Cuenta);

            return Redirect("/Menu/?Id=" + cont);
        }

    }
}