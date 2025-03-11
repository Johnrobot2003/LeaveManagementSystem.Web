using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Web.Data
{
    public class DogBreeds
    {
        public int Id { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string Breed { get; set; }
        public int Age { get; set; }
    }
}
