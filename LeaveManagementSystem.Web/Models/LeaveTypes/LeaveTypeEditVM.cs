using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeEditVM : BaseLeaveTypeVM
    {
        [Required]
        [Length(4, 150, ErrorMessage = "You have violated the length requirement")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 90, ErrorMessage = "The maximum number of days should be atleast 90 days!")]
       
        public int NumberOfDays { get; set; }
    }
}
