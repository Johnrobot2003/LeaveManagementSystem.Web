
namespace LeaveManagementSystem.Web.Data
{
    public class LeaveRequestStatus: BaseEntity
    {
        public string Name { get; set; }

        public static implicit operator LeaveRequestStatus(int v)
        {
            throw new NotImplementedException();
        }
    }
}