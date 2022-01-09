using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecodeMvc.Models;

namespace RecodeMvc
{
    public class TradutorsController : Controller
    {
        private readonly TradutorContext _context;

        public TradutorsController(TradutorContext context)
        {
            _context = context;
        }

        // GET: Tradutors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tradutores.ToListAsync());
        }

        // GET: Tradutors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tradutor = await _context.Tradutores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tradutor == null)
            {
                return NotFound();
            }

            return View(tradutor);
        }

        // GET: Tradutors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tradutors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Telefone,Idade,NivelEspanhol")] Tradutor tradutor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tradutor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tradutor);
        }

        // GET: Tradutors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tradutor = await _context.Tradutores.FindAsync(id);
            if (tradutor == null)
            {
                return NotFound();
            }
            return View(tradutor);
        }

        // POST: Tradutors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Telefone,Idade,NivelEspanhol")] Tradutor tradutor)
        {
            if (id != tradutor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tradutor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TradutorExists(tradutor.Id))
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
            return View(tradutor);
        }

        // GET: Tradutors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tradutor = await _context.Tradutores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tradutor == null)
            {
                return NotFound();
            }

            return View(tradutor);
        }

        // POST: Tradutors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tradutor = await _context.Tradutores.FindAsync(id);
            _context.Tradutores.Remove(tradutor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TradutorExists(int id)
        {
            return _context.Tradutores.Any(e => e.Id == id);
        }
    }
}
