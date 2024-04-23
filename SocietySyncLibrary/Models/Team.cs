using System.ComponentModel.DataAnnotations.Schema;

namespace SocietySyncLibrary;

public class Team
{
    [Column("team_id")]
    public int TeamID { get; set; } = -1;

    [Column("event_id")]
    public int EventID { get; set; } = -1;

    [Column("name")]
    public string? Name { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("team_head_id")]
    public int TeamHeadID { get; set; } = -1;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}
