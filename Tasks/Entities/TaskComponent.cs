namespace Tasks.Entities
{
    public class TaskComponent
    {
        public Guid ID { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool Completed { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
