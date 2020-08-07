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
    public class EditModel : PageModel
    {
        private readonly IRepositoryW<Candidato> repositoryW;
        private readonly IRepositoryW<Nacionalidad> repositoryWN;
        private readonly IRepositoryW<Orden> repositoryWO;
        [BindProperty]
        public Candidato Candidato { get; set; }
        public Nacionalidad Nacionalidad { get; set; }
        public Orden Orden { get; set; }
        [BindProperty]
        public IFormFile Foto { get; set; }
        public IWebHostEnvironment HostEnvironment { get; set; }
        public IEnumerable<Nacionalidad> ListNacionalidad { get; set; }
        public IEnumerable<Orden> ListOrden { get; set; }
        public EditModel(IRepositoryW<Candidato> repository, IRepositoryW<Nacionalidad> repositoryW, IRepositoryW<Orden> repositoryWO, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repository;
            HostEnvironment = hostEnvironment;
            this.ListNacionalidad = repositoryW.GetAll();
            this.ListOrden = repositoryWO.GetAll();
        }

        public IActionResult OnGet(int id)
        {
            Candidato = repositoryW.Get(id);

            if (Candidato.Id == 0)
                return RedirectToPage("/Candidatos/Index");
            return Page();
        }

        public IActionResult OnPost(Candidato candidato, string adios)
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
            repositoryW.Update(candidato);

            if (adios == "Editar")
            {
                repositoryW.Update(candidato);
            }
            if (adios == "Eliminar")
            {
                repositoryW.Delete(candidato);
            }

            return RedirectToPage("/Candidatos/Index");
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