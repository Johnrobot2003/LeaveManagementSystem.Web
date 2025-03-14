using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class ArchivesLeaveType:BaseLeaveTypeVM
    {
        
            [Column(TypeName = "nvarchar(150)")]
            public string Name { get; set; }

            [Display(Name = "Number of Days")]
            public int NumberOfDays { get; set; }
            public DateTime date { get; set; }
        }
    }

