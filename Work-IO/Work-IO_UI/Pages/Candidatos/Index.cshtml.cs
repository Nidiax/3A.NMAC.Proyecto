﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Work_IO.Models;
using Work_IO.Services;

namespace Work_IO_UI.Pages.Candidatos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositoryW<Candidato> repositoryW;
        public IEnumerable<Candidato> Candidatos { get; set; }
        public Candidato Candidato { get; private set; }
        public IWebHostEnvironment HostEnvironment { get; set; }
        public IndexModel(IRepositoryW<Candidato> repositoryW, IWebHostEnvironment hostEnvironment)
        {
            this.repositoryW = repositoryW;
            HostEnvironment = hostEnvironment;
        }
        public void OnGet()
        {
            Candidatos = repositoryW.GetAll();
        }
    }
}