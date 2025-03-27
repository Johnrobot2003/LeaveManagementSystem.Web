﻿using AutoMapper;
using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LeaveManagementSystem.Web.Services.LeaveTypes;

public class LeaveTypeService : ILeaveTypeService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public LeaveTypeService(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypesAsync()
    {
        var data = await _context.LeaveTypes.ToListAsync();
        var viewData = _mapper.Map<List<LeaveTypeReadOnlyVM>>(data);
        return viewData;
    }
    public async Task<T?> Get<T>(int id) where T : class
    {
        var data = _context.LeaveTypes.FirstOrDefault(x => x.Id == id);

        if (data == null)
        {
            return null;
        }
        var viewData = _mapper.Map<T>(data);
        return viewData;
    }
    public async Task Remove(int id)
    {
        var data = await _context.LeaveTypes.FirstOrDefaultAsync(x => x.Id == id);
        if (data != null)
        {
            _context.Remove(data);
            await _context.SaveChangesAsync();
        }
    }
    public async Task Edit(LeaveTypeEditVM leaveType)
    {
        var data = _mapper.Map<LeaveType>(leaveType);
        _context.Update(data);
        await _context.SaveChangesAsync();
    }
    public async Task Create(LeaveTypeCreateVM leaveType)
    {
        var data = _mapper.Map<LeaveType>(leaveType);
        _context.Add(data);
        await _context.SaveChangesAsync();
    }
    public bool LeaveTypeExists(int id)
    {
        return _context.LeaveTypes.Any(e => e.Id == id);
    }


    public async Task<bool> NameExistsInCreateAsync(LeaveTypeCreateVM leave)
    {
        var lowercase = leave.Name.ToLower();
        return await _context.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(lowercase));
    }
    public async Task<bool> NameExistsInCreateForEdit(LeaveTypeEditVM leave)
    {
        var lowercaseName = leave.Name.ToLower();
        return await _context.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(lowercaseName)
        && q.Id != leave.Id
         );
    }
}
