using System.ComponentModel.DataAnnotations;

namespace Attendance_System.Models
{
    public class Department
    {
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}
