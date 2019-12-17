using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoTarefasIPG.Models;

namespace GestaoTarefasIPG.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly FuncionarioDbContext _context;

        public int TamanhoPagina = 10;

        public FuncionariosController(FuncionarioDbContext context)
        {
            _context = context;
        }

        // GET: Funcionarios
        public async Task<IActionResult> Index(int page = 1, string searchString = "", string sort = "true")
        {
            var funcionarios = from p in _context.Funcionario
                              select p;

            if (!String.IsNullOrEmpty(searchString)) {
                funcionarios = funcionarios.Where(p => p.Nome.Contains(searchString));
            }

            decimal nFuncionarios = funcionarios.Count();

            int NUMERO_PAGINAS_ANTES_DEPOIS = ((int)nFuncionarios / TamanhoPagina);

            if (nFuncionarios % TamanhoPagina == 0) {
                NUMERO_PAGINAS_ANTES_DEPOIS -= 1;
            }

            FuncionariosViewModel vm = new FuncionariosViewModel {
                Sort = sort,
                PaginaAtual = page,
                PrimeiraPagina = Math.Max(1, page - NUMERO_PAGINAS_ANTES_DEPOIS),
                TotalPaginas = (int)Math.Ceiling(nFuncionarios / TamanhoPagina)
            };

            if (sort.Equals("true")) {
                vm.Funcionarios = funcionarios.OrderBy(p => p.Nome).Skip((page - 1) * TamanhoPagina).Take(TamanhoPagina);
            } else {
                vm.Funcionarios = funcionarios.OrderByDescending(p => p.Nome).Skip((page - 1) * TamanhoPagina).Take(TamanhoPagina);
            }

            vm.UltimaPagina = Math.Min(vm.TotalPaginas, page + NUMERO_PAGINAS_ANTES_DEPOIS);
            vm.StringProcura = searchString;

            return View(vm);
        }

        // GET: Funcionarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionario
                .FirstOrDefaultAsync(m => m.FuncionarioId == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // GET: Funcionarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Funcionarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuncionarioId,Nome,Contacto,Email,NumeroFuncionario")] Funcionario funcionario) {
            if (ModelState.IsValid) {

                ViewBag.Email = "";
                ViewBag.Contacto = "";
                ViewBag.NumeroFunc = "";

                bool erro = false;

                var Nome = _context.Funcionario
                .FirstOrDefault(m => m.Nome == funcionario.Nome);

                var Email = _context.Funcionario
                .FirstOrDefault(m => m.Email == funcionario.Email);

                var Contacto = _context.Funcionario
                .FirstOrDefault(m => m.Contacto == funcionario.Contacto);
                
                var NumeroFunc = _context.Funcionario
                .FirstOrDefault(m => m.NumeroFuncionario == funcionario.NumeroFuncionario);

                if (Email != null) {
                    ViewBag.Nome = "O Nome " + funcionario.Nome + " já foi usado";
                    erro = true;
                }

                if (Email != null) {
                    ViewBag.Email = "O Email " + funcionario.Email + " já foi usado";
                    erro = true;
                }
                if (Contacto != null) {
                    ViewBag.Contacto = "O contacto " + funcionario.Contacto + " já foi usado";
                    erro = true;
                }
                if (NumeroFunc != null) {
                    ViewBag.NumeroFunc = "O número de funcionário " + funcionario.NumeroFuncionario + " já foi usado";
                    erro = true;
                }

                if (erro == false) {

                    _context.Add(funcionario);
                    await _context.SaveChangesAsync();
                    ViewBag.Title = "Criação bem sucedida!";
                    ViewBag.Message = "Funcionário criado com sucesso";
                    return View("Success");

                } else {
                    return View("Create");

                }
            }
                return View(funcionario);
        }
        // GET: Funcionarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionario.FindAsync(id);
            if (funcionario == null)
            {
                return NotFound();
            }
            return View(funcionario);
        }

        // POST: Funcionarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FuncionarioId,Nome,Contacto,Email,NumeroFuncionario")] Funcionario funcionario)
        {
            if (id != funcionario.FuncionarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funcionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionarioExists(funcionario.FuncionarioId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
                ViewBag.Title = "Atualização bem sucedida!";
                ViewBag.Message = "Funcionário atualizado com sucesso";
                return View("Success");
            }
            return View(funcionario);
        }

        // GET: Funcionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionario
                .FirstOrDefaultAsync(m => m.FuncionarioId == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // POST: Funcionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funcionario = await _context.Funcionario.FindAsync(id);
            _context.Funcionario.Remove(funcionario);
            await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            ViewBag.Title = "Eliminação bem sucedida!";
            ViewBag.Message = "Funcionário eliminado com sucesso";
            return View("Success");
        }

        private bool FuncionarioExists(int id)
        {
            return _context.Funcionario.Any(e => e.FuncionarioId == id);
        }
    }
}
