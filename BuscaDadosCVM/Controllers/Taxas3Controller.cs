using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuscaDadosCVM.Data;
using BuscaDadosCVM.Models;

namespace BuscaDadosCVM.Controllers
{
    public class Taxas3Controller : Controller
    {
        private readonly BuscaDadosCVMContext _context;

        public Taxas3Controller(BuscaDadosCVMContext context)
        {
            _context = context;
        }   

        // GET: Taxas1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Taxa.ToListAsync());
        }

        // GET: Taxas1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taxa = await _context.Taxa
                .FirstOrDefaultAsync(m => m.id == id);
            if (taxa == null)
            {
                return NotFound();
            }

            return View(taxa);
        }

        // GET: Taxas1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Taxas1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,AnoMesDivulgacao,DataImportacao,CNPJ_FUNDO,DT_COMPTC,VL_TOTAL,VL_QUOTA,VL_PATRIM_LIQ,CAPTC_DIA,RESG_DIA,NR_COTST")] Taxa taxa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taxa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taxa);
        }

        // GET: Taxas1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taxa = await _context.Taxa.FindAsync(id);
            if (taxa == null)
            {
                return NotFound();
            }
            return View(taxa);
        }

        // POST: Taxas1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,AnoMesDivulgacao,DataImportacao,CNPJ_FUNDO,DT_COMPTC,VL_TOTAL,VL_QUOTA,VL_PATRIM_LIQ,CAPTC_DIA,RESG_DIA,NR_COTST")] Taxa taxa)
        {
            if (id != taxa.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taxa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaxaExists(taxa.id))
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
            return View(taxa);
        }

        // GET: Taxas1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taxa = await _context.Taxa
                .FirstOrDefaultAsync(m => m.id == id);
            if (taxa == null)
            {
                return NotFound();
            }

            return View(taxa);
        }

        // POST: Taxas1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taxa = await _context.Taxa.FindAsync(id);
            _context.Taxa.Remove(taxa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaxaExists(int id)
        {
            return _context.Taxa.Any(e => e.id == id);
        }
    }
}
