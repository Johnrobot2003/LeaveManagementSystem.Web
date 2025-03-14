using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.Controllers
{
    public class ArchivesLeaveTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArchivesLeaveTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ArchivesLeaveTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ArchivesLeaveType.ToListAsync());
        }

        // GET: ArchivesLeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archivesLeaveType = await _context.ArchivesLeaveType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (archivesLeaveType == null)
            {
                return NotFound();
            }

            return View(archivesLeaveType);
        }

        // GET: ArchivesLeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArchivesLeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,NumberOfDays,date,Id")] ArchivesLeaveType archivesLeaveType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(archivesLeaveType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(archivesLeaveType);
        }

        // GET: ArchivesLeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archivesLeaveType = await _context.ArchivesLeaveType.FindAsync(id);
            if (archivesLeaveType == null)
            {
                return NotFound();
            }
            return View(archivesLeaveType);
        }

        // POST: ArchivesLeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,NumberOfDays,date,Id")] ArchivesLeaveType archivesLeaveType)
        {
            if (id != archivesLeaveType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(archivesLeaveType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArchivesLeaveTypeExists(archivesLeaveType.Id))
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
            return View(archivesLeaveType);
        }

        // GET: ArchivesLeaveTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archivesLeaveType = await _context.ArchivesLeaveType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (archivesLeaveType == null)
            {
                return NotFound();
            }

            return View(archivesLeaveType);
        }

        // POST: ArchivesLeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var archivesLeaveType = await _context.ArchivesLeaveType.FindAsync(id);
            if (archivesLeaveType != null)
            {
                _context.ArchivesLeaveType.Remove(archivesLeaveType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArchivesLeaveTypeExists(int id)
        {
            return _context.ArchivesLeaveType.Any(e => e.Id == id);
        }
    }
}
