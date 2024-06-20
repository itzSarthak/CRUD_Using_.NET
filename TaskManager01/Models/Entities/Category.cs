using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel.DataAnnotations;

namespace TaskManager01.Models.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }
        public bool IsActive { get; set; }


        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation property
        public ICollection<Task> Tasks{ get; set; }
     }
}
