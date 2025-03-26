using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;
using AutoMapper;
using LeaveManagementSystem.Web.Services;

namespace LeaveManagementSystem.Web.Controllers
{
    [Authorize]
    public class LeaveTypesController(ILeaveTypeService leaveTypesService) : Controller
    {
        
        private readonly ILeaveTypeService _leaveTypesService = leaveTypesService;



        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {

            /*var displayData = data.Select(q => new IndexVM
            {
                Id = q.Id,
                Name = q.Name,
                NumberOfDays = q.NumberOfDays
            });*/
            var viewData = await _leaveTypesService.GetAllLeaveTypesAsync();
            return View(viewData);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveType = await _leaveTypesService.Get<LeaveTypeReadOnlyVM>(id.Value);
            if (leaveType == null)
            {
                return NotFound();
            }
            
            return View(leaveType);
        }

        // GET: LeaveTypes/Create
        [Authorize(Roles = Roles.Adminitrator)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        public async Task<IActionResult> Create(LeaveTypeCreateVM leaveTypeCreate)
        {
            if (leaveTypeCreate.Name.Contains("test"))
            {
                ModelState.AddModelError(nameof(leaveTypeCreate.Name),"Stop!");
            }
            if (leaveTypeCreate.NumberOfDays==69)
            {
                ModelState.AddModelError(nameof(leaveTypeCreate.NumberOfDays), "Wag kang bastos!");
            }
          
            if (await _leaveTypesService.NameExistsInCreateAsync(leaveTypeCreate))
            {
                ModelState.AddModelError(nameof(leaveTypeCreate.Name), "Name already exists!");
            }
            
            if (ModelState.IsValid)
            {
                await _leaveTypesService.Create(leaveTypeCreate);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeCreate);
        }

      


        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveType = await _leaveTypesService.Get<LeaveTypeEditVM>(id.Value);
            if (leaveType == null)
            {
                return NotFound();
            }

            return View(leaveType);
            
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeEditVM leaveTypeEdit)
        {
            if (id != leaveTypeEdit.Id)
            {
                return NotFound();
            }
            if (leaveTypeEdit.NumberOfDays == 69)
            {
                ModelState.AddModelError(nameof(leaveTypeEdit.NumberOfDays), "Wag kang Bastos!");
            }
            if (await _leaveTypesService.NameExistsInCreateForEdit(leaveTypeEdit))
            {
                ModelState.AddModelError(nameof(leaveTypeEdit.Name), "Name already exists!");
            }
            if (ModelState.IsValid)
            {
                try
                {
                    await _leaveTypesService.Edit(leaveTypeEdit);
                   
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_leaveTypesService.LeaveTypeExists(leaveTypeEdit.Id))
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
            return View(leaveTypeEdit);
        }

       

        // GET: LeaveTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveType = await _leaveTypesService.Get<LeaveTypeReadOnlyVM>(id.Value);
            if (leaveType == null)
            {
                return NotFound();
            }

            return View(leaveType);
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _leaveTypesService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

       /* private bool LeaveTypeExists(int id)
        {
            return _context.LeaveTypes.Any(e => e.Id == id);
        }
       

        private async Task<bool> NameExistsInCreateAsync(LeaveTypeCreateVM leave)
        {
            var lowercase = leave.Name.ToLower();
            return await _context.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(lowercase));
        }
        private async Task<bool> NameExistsInCreateForEdit(LeaveTypeEditVM leave)
        {
            var lowercaseName = leave.Name.ToLower();
            return await _context.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(lowercaseName)
            && q.Id != leave.Id
             );
        }*/

    }
}
