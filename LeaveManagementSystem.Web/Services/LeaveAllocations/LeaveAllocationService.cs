// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using AutoMapper;
using LeaveManagementSystem.Web.Models.LeaveAllocations;
using LeaveManagementSystem.Web.Services.Periods;
using LeaveManagementSystem.Web.Services.Users;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Services.LeaveAllocations
{
    public class LeaveAllocationService (ApplicationDbContext _context, IUserService _userService, IMapper _mapper, IPeriodService _periodService) :ILeaveAllocationService
    {
        

        public async Task AllocateLeave(string employeeId)
        {
            var leaveTypes = await _context.LeaveTypes
                .Where(q => !q.LeaveAllocations.Any(x => x.EmployeeId == employeeId))
                .ToListAsync();
         var period = await _periodService.GetCurrentPeriod();
            var monthsRemaining = period.EndDate.Month - DateTime.Now.Month;

            foreach (var item in leaveTypes)
            {
                //var allocationExists = await AllocateExists(employeeId, period.Id, item.Id);
              
                var accuralRate = decimal.Divide(item.NumberOfDays, 12);
                var leaveAllocation = new LeaveAllocation
                {
                    EmployeeId = employeeId,
                    LeaveTypeId = item.Id,
                    PeriodId = period.Id,
                    Days = (int)Math.Ceiling(accuralRate * monthsRemaining)
                };

                _context.Add(leaveAllocation);
            }
            await _context.SaveChangesAsync();

        }

     
      public async Task <EmployeeAllocationVM> GetEmployeeAllocation(string? userid)
        {
            var user = string.IsNullOrEmpty(userid) 
                ? await _userService.GetLoggedInUser()
                : await _userService.GetUserById(userid);


            var allocations =  await GetAllocation(user.Id);
            var allocationVmList = _mapper.Map<List<LeaveAllocation>, List<LeaveAllocationVM>>(allocations);
            var leaveTypes = await _context.LeaveTypes.CountAsync();
           // var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
            var employeeVm = new EmployeeAllocationVM
            {
               
                DateOfBirth = user.DateOfBirth,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Id = user.Id,
                LeaveAllocations = allocationVmList,
                IsCompletedAllocation = leaveTypes == allocations.Count

            };
            return employeeVm;
        }
        public async Task<List<EmployeeListVM>> GetEmployees()
        {
            var users = await _userService.GetEmployees();
            var employees = _mapper.Map<List<ApplicationUser>,List<EmployeeListVM>>(users.ToList());

            return employees;
        }
        public async Task<LeaveAllocationEditVM> GetEmployeeAllocations(int allocationid)
        {
            var allocation = await _context.LeaveAllocations
                .Include(q => q.LeaveType)
                .Include(q => q.Employee)
                .FirstOrDefaultAsync(q => q.Id == allocationid);

            var model = _mapper.Map<LeaveAllocationEditVM>(allocation);

            return model;
        }
        public async Task EditAllocation(LeaveAllocationEditVM allocationEditVm)
        {
            /*var leaveAllocation = await GetEmployeeAllocations(allocationEditVm.Id);

            if (leaveAllocation == null)
            {
                throw new Exception("Leave Allocation record does not exist.");
            }
            leaveAllocation.Days = allocationEditVm.Days;

            //_context.Update(leaveAllocation);

            //await _context.SaveChangesAsync();*/
            await _context.LeaveAllocations
                .Where(q => q.Id == allocationEditVm.Id)
                .ExecuteUpdateAsync(s => s.SetProperty(e => e.Days, allocationEditVm.Days));
        }
        private async Task<List<LeaveAllocation>> GetAllocation(string? userid)
        {


            var currentDate = DateTime.Now;
            var period = await _context.Periods.SingleAsync(q => q.EndDate.Year == currentDate.Year);
            var leaveAllocation = await _context.LeaveAllocations
                .Include(q => q.LeaveType)
                .Include(q => q.Period)
                .Where(q => q.EmployeeId == userid && q.PeriodId == period.Id)
                .ToListAsync();

            return leaveAllocation;
        }
        private async Task<bool>AllocateExists(string userId, int periodId, int leaveTypeId)
        {
            var exists = await _context.LeaveAllocations.AnyAsync(q =>
            q.EmployeeId == userId
            && q.LeaveTypeId == leaveTypeId
            && q.PeriodId == periodId

            );
            return exists;
        }

      
    }
}
