using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eshop_bookstore.Data;

namespace Eshop_bookstore.Models
{
    public class InvoiceDetailsController : Controller
    {
        private readonly Eshop_bookstoreContext _context;

        public InvoiceDetailsController(Eshop_bookstoreContext context)
        {
            _context = context;
        }

        // GET: InvoiceDetails
        public async Task<IActionResult> Index()
        {
            var eshop_bookstoreContext = _context.InvoiceDetails.Include(i => i.Invoices).Include(i => i.Products);
            return View(await eshop_bookstoreContext.ToListAsync());
        }

        // GET: InvoiceDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceDetails = await _context.InvoiceDetails
                .Include(i => i.Invoices)
                .Include(i => i.Products)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoiceDetails == null)
            {
                return NotFound();
            }

            return View(invoiceDetails);
        }

        // GET: InvoiceDetails/Create
        public IActionResult Create()
        {
            ViewData["InvoiceId"] = new SelectList(_context.Set<Invoices>(), "Id", "Code");
            ViewData["ProductId"] = new SelectList(_context.Set<Products>(), "Id", "Name");
            return View();
        }

        // POST: InvoiceDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,InvoiceId,ProductId,Quantity,UnitPrice")] InvoiceDetails invoiceDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invoiceDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InvoiceId"] = new SelectList(_context.Set<Invoices>(), "Id", "Code", invoiceDetails.InvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Set<Products>(), "Id", "Name", invoiceDetails.ProductId);
            return View(invoiceDetails);
        }

        // GET: InvoiceDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceDetails = await _context.InvoiceDetails.FindAsync(id);
            if (invoiceDetails == null)
            {
                return NotFound();
            }
            ViewData["InvoiceId"] = new SelectList(_context.Set<Invoices>(), "Id", "Code", invoiceDetails.InvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Set<Products>(), "Id", "Name", invoiceDetails.ProductId);
            return View(invoiceDetails);
        }

        // POST: InvoiceDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,InvoiceId,ProductId,Quantity,UnitPrice")] InvoiceDetails invoiceDetails)
        {
            if (id != invoiceDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoiceDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceDetailsExists(invoiceDetails.Id))
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
            ViewData["InvoiceId"] = new SelectList(_context.Set<Invoices>(), "Id", "Code", invoiceDetails.InvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Set<Products>(), "Id", "Name", invoiceDetails.ProductId);
            return View(invoiceDetails);
        }

        // GET: InvoiceDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceDetails = await _context.InvoiceDetails
                .Include(i => i.Invoices)
                .Include(i => i.Products)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoiceDetails == null)
            {
                return NotFound();
            }

            return View(invoiceDetails);
        }

        // POST: InvoiceDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invoiceDetails = await _context.InvoiceDetails.FindAsync(id);
            _context.InvoiceDetails.Remove(invoiceDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceDetailsExists(int id)
        {
            return _context.InvoiceDetails.Any(e => e.Id == id);
        }
    }
}
