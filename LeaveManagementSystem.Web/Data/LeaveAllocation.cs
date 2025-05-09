﻿namespace LeaveManagementSystem.Web.Data
{
    public class LeaveAllocation:BaseEntity
    {
        public int Id { get; set; }
        public LeaveType? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public ApplicationUser? Employee { get; set; }
        public string EmployeeId { get; set; } = string.Empty;
        public Period? Period { get; set; }
        public int PeriodId { get; set; }
        public int Days { get; set; }
    }
}
