using catalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace catalogo.Controllers
{
    public class CadastroController : Controller
    {
        private readonly Contexto _contexto;
        public CadastroController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Cadastro.ToListAsync());
        }
        [HttpGet]
        public IActionResult NovoCadastro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NovoCadastro(ControleCadastro cadastro)
        {
            await _contexto.Cadastro.AddAsync(cadastro);
            await _contexto.SaveChangesAsync();
            return RedirectToAction("Index", "Home", new { area = "" });
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ControleCadastro cadastro = await _contexto.Cadastro.FindAsync(id);
            return View(cadastro);
        }

        [HttpPost]
        public async Task<IActionResult> Atualizar(ControleCadastro cadastro)
        {
            _contexto.Cadastro.Update(cadastro);
            await _contexto.SaveChangesAsync();
            return RedirectToAction("Index", "Cadastro", new { area = "" });
        }
        [HttpPost]
        public async Task<IActionResult> Excluir(int id)
        {
            ControleCadastro cadastro = await _contexto.Cadastro.FindAsync(id);
            _contexto.Cadastro.Remove(cadastro);
            await _contexto.SaveChangesAsync();
            return RedirectToAction("Index", "Cadastro", new { area = "" });
        }
    }
}
