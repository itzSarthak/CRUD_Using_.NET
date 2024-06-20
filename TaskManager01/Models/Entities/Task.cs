using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager01.Models.Entities
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? DueDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Priority { get; set; }

        [MaxLength(255)]
        public string Assignee { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }


        public int CategoryId { get; set; }

        
        public Category Category { get; set; }

        public ICollection<SubTask> subTasks
        {
            get; set;
        }
    }
}
