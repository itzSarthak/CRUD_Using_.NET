using Microsoft.EntityFrameworkCore;
using System.Numerics;
using TaskManager01.Models.Entities;

namespace TaskManager01.Models
{
    public class UpdateSubTaskDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string SubTask_Description { get; set; }

        public int TaskId { get; set; }

    }
}
