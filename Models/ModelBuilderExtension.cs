using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArktosAPI.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "Home" },
                new Project { Id = 2, Name = "Work" },
                new Project { Id = 3, Name = "Exercise" },
                new Project { Id = 4, Name = "Family" }
            );

            modelBuilder.Entity<TaskItem>().HasData(
                new TaskItem { Id = 1, Name = "Task 1", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 1, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 2, Name = "Task 2", IsPriority = true, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 2, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 3, Name = "Task 3", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = true, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 3, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 4, Name = "Task 4", IsPriority = true, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 4, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 5, Name = "Task 5", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 1, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 6, Name = "Task 6", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = true, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 2, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 7, Name = "Task 7", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 3, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 8, Name = "Task 8", IsPriority = true, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 4, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 9, Name = "Task 9", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 1, ReporterId = 1, UserId = 2, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 10, Name = "Task 10", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 2, ReporterId = 1, UserId = 2, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 11, Name = "Task 11", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 3, ReporterId = 1, UserId = 2, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 12, Name = "Task 12", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 4, ReporterId = 1, UserId = 2, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 13, Name = "Task 13", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 1, ReporterId = 1, UserId = 3, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 14, Name = "Task 14", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 2, ReporterId = 1, UserId = 3, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 15, Name = "Task 15", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 3, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 16, Name = "Task 16", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 4, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 17, Name = "Task 17", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 1, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 18, Name = "Task 18", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 2, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 19, Name = "Task 19", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 3, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 20, Name = "Task 20", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 4, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 21, Name = "Task 21", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 1, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 22, Name = "Task 22", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 2, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 },
                new TaskItem { Id = 23, Name = "Task 23", IsPriority = false, createdDate = DateTime.Now, Description = "This is an example task with dummy data.", EstimatedHours = 1, IsBlocked = false, IssueURL = "htttp://www.example.com/issues/foo", ProjectId = 3, ReporterId = 1, UserId = 1, Size = 3, Status = 0, TimeSpent = 0 }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "drew@example.com" },
                new User { Id = 2, Email = "evan@example.com" },
                new User { Id = 3, Email = "mandy@example.com" }
            );
        }
    }
}
