using System.ComponentModel.DataAnnotations;

namespace TaskManager01.Models
{
    public class AddCatDto
    {
        [Required]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
