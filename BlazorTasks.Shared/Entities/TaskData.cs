using BlazorTasks.Shared.Data;

namespace BlazorTasks.Shared.Entities
{
    public static class TaskData
    {
        public static List<TaskCourse> GetTasks() => new()
        {
            new TaskCourse { Description = "To Do course", Completed = false, DateCriation = DateTime.Parse("2025-01-25") },
            new TaskCourse { Description = "To study .Net 9", Completed = true, DateCriation = DateTime.Parse("2025-02-20") },
            new TaskCourse { Description = "To read Blazor documentation", Completed = false, DateCriation = DateTime.Parse("2025-03-04") },
            new TaskCourse { Description = "To practice LINQ queries", Completed = true, DateCriation = DateTime.Parse("2025-04-09") },
            new TaskCourse { Description = "To create API with EF Core", Completed = false, DateCriation = DateTime.Parse("2025-05-12") },
            new TaskCourse { Description = "To do unit tests", Completed = true, DateCriation = DateTime.Parse("2025-06-01") },
            new TaskCourse { Description = "To publish in the GitHub", Completed = false, DateCriation = DateTime.Parse("2025-06-15") },
        };
    }
}
