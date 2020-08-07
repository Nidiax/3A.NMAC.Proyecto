using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages.Candidatos
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Candidato Candidato { get; set; }
        public Nacionalidad Nacionalidad { get; set; }
        [BindProperty]
        public IFormFile Foto { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }
        private readonly IRepositoryW<Candidato> repositoryW;
        private readonly IRepositoryW<Nacionalidad> repositoryWN;
        private readonly IRepositoryW<Orden> repositoryWO;
        public IEnumerable<Nacionalidad> ListNacionalidad { get; set; }
        public IEnumerable<Orden> ListOrden { get; set; }
        public CreateModel(IRepositoryW<Candidato> repository, IRepositoryW<Nacionalidad> repositoryWN, IRepositoryW<Orden> repositoryWO, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repository;
            HostEnvironment = hostEnvironment;
            this.ListNacionalidad = repositoryWN.GetAll();
            this.ListOrden = repositoryWO.GetAll();
        }
        public void OnGet()
        {
            
        }

        public string[] Genders = new[] { "Hombre", "Mujer" };

        public IActionResult OnPost(Candidato candidato)
        {
            if (!ModelState.IsValid)
                return Page();

            if (Foto != null)
            {
                if (!string.IsNullOrEmpty(candidato.Foto))
                {
                    var filePath = Path.Combine(HostEnvironment.WebRootPath, "imagenes", candidato.Foto);
                    System.IO.File.Delete(filePath);
                }
                candidato.Foto = ProcessUploadFile();
            }
            var id = repositoryW.Insert(candidato);

            return RedirectToPage($"/Referencia/Create");
        }
        private string ProcessUploadFile()
        {
            if (Foto == null)
                return string.Empty;
            var uploadFolder = Path.Combine(HostEnvironment.WebRootPath, "imagenes");
            var fileName = $"{Guid.NewGuid()}_{Foto.FileName}";
            var filePath = Path.Combine(uploadFolder, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                Foto.CopyTo(stream);
            }
            return fileName;
        }
    }
}