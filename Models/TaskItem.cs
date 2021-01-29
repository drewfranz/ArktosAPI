using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ArktosAPI.Models
{
    public class TaskItem : BaseEntity
    {
        public int Id { get; set; }
        public int ReporterId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string IssueURL { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsPriority { get; set; }
        public int Size { get; set; }
        public decimal EstimatedHours { get; set; }
        public decimal TimeSpent { get; set; }
        [Required]
        public TaskStatus Status { get; set; }
        public DateTime? DueDate { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }
        public virtual Project Project { get; set; }
    }

    public class BaseEntity
    {
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
    }

    public enum TaskStatus
    {
        open,
        active,
        review,
        solved,
        closed
    }
}
