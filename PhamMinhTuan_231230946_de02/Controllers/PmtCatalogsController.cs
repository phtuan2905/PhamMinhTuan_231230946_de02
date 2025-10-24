using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhamMinhTuan_231230946_de02.Models;

namespace PhamMinhTuan_231230946_de02.Controllers
{
    public class PmtCatalogsController : Controller
    {
        private readonly PhamMinhTuan231230946De02Context _context;

        public PmtCatalogsController(PhamMinhTuan231230946De02Context context)
        {
            _context = context;
        }

        // GET: PmtCatalogs
        public async Task<IActionResult> PmtIndex()
        {
            return View(await _context.PmtCatalogs.ToListAsync());
        }

        // GET: PmtCatalogs/Details/5
        public async Task<IActionResult> PmtDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pmtCatalog = await _context.PmtCatalogs
                .FirstOrDefaultAsync(m => m.PmtId == id);
            if (pmtCatalog == null)
            {
                return NotFound();
            }

            return View(pmtCatalog);
        }

        // GET: PmtCatalogs/Create
        public IActionResult PmtCreate()
        {
            return View();
        }

        // POST: PmtCatalogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PmtCreate([Bind("PmtId,PmtCateName,PmtCatePrice,PmtCateQty,PmtPicture,PmtCateActive")] PmtCatalog pmtCatalog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pmtCatalog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PmtIndex));
            }
            return View(pmtCatalog);
        }

        // GET: PmtCatalogs/Edit/5
        public async Task<IActionResult> PmtEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pmtCatalog = await _context.PmtCatalogs.FindAsync(id);
            if (pmtCatalog == null)
            {
                return NotFound();
            }
            return View(pmtCatalog);
        }

        // POST: PmtCatalogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PmtEdit(int id, [Bind("PmtId,PmtCateName,PmtCatePrice,PmtCateQty,PmtPicture,PmtCateActive")] PmtCatalog pmtCatalog)
        {
            if (id != pmtCatalog.PmtId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pmtCatalog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PmtCatalogExists(pmtCatalog.PmtId))
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
            return View(pmtCatalog);
        }

        // GET: PmtCatalogs/Delete/5
        public async Task<IActionResult> PmtDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pmtCatalog = await _context.PmtCatalogs
                .FirstOrDefaultAsync(m => m.PmtId == id);
            if (pmtCatalog == null)
            {
                return NotFound();
            }

            return View(pmtCatalog);
        }

        // POST: PmtCatalogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PmtDeleteConfirmed(int id)
        {
            var pmtCatalog = await _context.PmtCatalogs.FindAsync(id);
            if (pmtCatalog != null)
            {
                _context.PmtCatalogs.Remove(pmtCatalog);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PmtCatalogExists(int id)
        {
            return _context.PmtCatalogs.Any(e => e.PmtId == id);
        }
    }
}
