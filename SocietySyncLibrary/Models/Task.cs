using System.ComponentModel.DataAnnotations.Schema;

namespace SocietySyncLibrary;

public class Task
{
    [Column("task_id")]
    public int TaskID { get; set; } = -1;

    [Column("team_id")]
    public int TeamID { get; set; } = -1;

    [Column("title")]
    public string? Title { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("assigned_to")]
    public int AssignedTo { get; set; } = -1;

    [Column("due_date")]
    public DateTime DueDate { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("completed")]
    public bool Completed { get; set; }
}
