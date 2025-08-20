namespace BlazorTasks.Shared.Data
{
    public class TaskCourse
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string? Description { get; set; }
        public bool Completed { get; set; }
        public DateTime DateCriation { get; set; }
    }
}
