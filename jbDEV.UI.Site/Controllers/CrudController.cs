using jbDEV.UI.Site.Data;
using jbDEV.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace jbDEV.UI.Site.Controllers
{
    public class CrudController : Controller
    {
        private readonly PrimaryDbContext _context;

        public CrudController(PrimaryDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno() 
            {
                Nome = "Júlio",
                DataNascimento = DateTime.Now,
                Email = "julio@juliobomfim.net.br"
            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            var aluno2 = _context.Alunos.Find(aluno.Id);

            var aluno3 = _context.Alunos.FirstOrDefault(a => a.Email == "julio@juliobomfim.net.br");

            var aluno4 = _context.Alunos.Where(a => a.Nome == "Júlio");

            aluno.Nome = "Júlio Cezar Bomfim";

            _context.Alunos.Update(aluno);
            _context.SaveChanges();

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
            return View();
        }
    }
}
