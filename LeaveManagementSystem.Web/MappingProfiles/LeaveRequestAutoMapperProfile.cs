using AutoMapper;
using LeaveManagementSystem.Web.Models.LeaveRequest;

namespace LeaveManagementSystem.Web.MappingProfiles
{
    public class LeaveRequestAutoMapperProfile: Profile
    {
        public LeaveRequestAutoMapperProfile()
        {
            CreateMap<LeaveRequestCreateVM, LeaveRequest>();
        }
    }
}
