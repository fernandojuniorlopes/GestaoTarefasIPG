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
    public class ProfessoresController : Controller
    {
        private readonly ProfessorDbContext _context;

        public int TamanhoPagina = 10;

        public ProfessoresController(ProfessorDbContext context)
        {
            _context = context;
        }

        ////public ViewResult Index(int page = 1) => View(
        //    _context.Professor
        //    .OrderBy(p => p.Nome)
        //    .Skip((page - 1) * TamanhoPagina)
        //    .Take(TamanhoPagina)
        //    );

        // GET: Professores
        public IActionResult Index(int page = 1, string searchString = null)
        {
            var professores = from p in _context.Professor
                           select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                professores = professores.Where(p => p.Nome.Contains(searchString));
            }

            decimal nProfessores = _context.Professor.Count();
            int NUMERO_PAGINAS_ANTES_DEPOIS = ((int)nProfessores / TamanhoPagina);

            if (nProfessores % TamanhoPagina == 0)
            {
                NUMERO_PAGINAS_ANTES_DEPOIS -= 1;
            }

            ProfessoresViewModel vm = new ProfessoresViewModel
            {
                Professores = professores.OrderBy(p => p.Nome).Skip((page - 1) * TamanhoPagina).Take(TamanhoPagina),
                PaginaAtual = page,
                PrimeiraPagina = Math.Max(1, page - NUMERO_PAGINAS_ANTES_DEPOIS),
                TotalPaginas = (int)Math.Ceiling(nProfessores / TamanhoPagina)
            };

            vm.UltimaPagina = Math.Min(vm.TotalPaginas, page + NUMERO_PAGINAS_ANTES_DEPOIS);

            return View(vm);
        }

        // GET: Professores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = await _context.Professor
                .FirstOrDefaultAsync(m => m.ProfessorId == id);
            if (professor == null)
            {
                return NotFound();
            }

            return View(professor);
        }

        // GET: Professores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Professores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProfessorId,Nome,NumeroTelemovel,Email,Gabinete")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(professor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(professor);
        }

        // GET: Professores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = await _context.Professor.FindAsync(id);
            if (professor == null)
            {
                return NotFound();
            }
            return View(professor);
        }

        // POST: Professores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProfessorId,Nome,NumeroTelemovel,Email,Gabinete")] Professor professor)
        {
            if (id != professor.ProfessorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(professor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfessorExists(professor.ProfessorId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(professor);
        }

        // GET: Professores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = await _context.Professor
                .FirstOrDefaultAsync(m => m.ProfessorId == id);
            if (professor == null)
            {
                return NotFound();
            }

            return View(professor);
        }

        // POST: Professores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var professor = await _context.Professor.FindAsync(id);
            _context.Professor.Remove(professor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfessorExists(int id)
        {
            return _context.Professor.Any(e => e.ProfessorId == id);
        }
    }
}
