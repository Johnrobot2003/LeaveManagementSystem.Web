using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagementSystem.Web.Models.LeaveRequest
{
    public class LeaveRequestCreateVM:IValidatableObject
    {
        [Display(Name = "Start Date")]
        [Required]
        public DateOnly StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required]
        public DateOnly EndDate { get; set; }

        [Display(Name = "Desired Leave type")]
        [Required]
        public int LeaveTypeId { get; set; }

        [Display(Name = "Additional Information")]
        public string? RequestComments { get; set; }

        public SelectList? LeaveTypes { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate > EndDate)
            {
                yield return new ValidationResult(
                    "Start date must be before end date",
                    new[] { nameof(StartDate), nameof(EndDate) });
            }
        }
    }
}