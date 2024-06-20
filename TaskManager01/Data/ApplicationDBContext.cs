using Microsoft.EntityFrameworkCore;
using TaskEntity = TaskManager01.Models.Entities.Task;
using TaskManager01.Models.Entities;

namespace TaskManager01.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<TaskEntity> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<SubTask> SubTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaskEntity>()
                .HasOne(t => t.Category)
                .WithMany(c => c.Tasks)
                .HasForeignKey(t => t.CategoryId);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SubTask>()
            .HasOne(t => t.task)
            .WithMany(c => c.subTasks)
            .HasForeignKey(t => t.TaskId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
