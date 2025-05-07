using AutoMapper;
using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.Employees;
using LeaveManagementSystem.Web.Models.LeaveTypes;
namespace LeaveManagementSystem.Web.MappingProfiles
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            //.ForMember(dest => dest.Days, opt =>opt.MapFrom(src => src.NumberOfDays));

            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<ApplicationUser, AllEmployeesVM>();
            CreateMap<ApplicationUser, ResetPasswordVM>();

            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
        }
    }
}
