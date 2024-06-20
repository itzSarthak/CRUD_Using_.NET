namespace TaskManager01.Models.Entities
{
    public class SubTask
    {
        public int Id { get; set; } 

        public string Title { get; set; }

        public  string SubTask_Description { get; set; } 
        
        public int TaskId {  get; set; }

        public Task task { get; set; }
    }
}
