namespace LeaveManagementSystem.Web.Services.LeaveAllocations
{
    public class LeaveAllocationService:ILeaveAllocationService
    {
        private readonly ApplicationDbContext _context;

        public LeaveAllocationService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
