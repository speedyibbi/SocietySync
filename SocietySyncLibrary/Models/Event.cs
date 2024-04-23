using System.ComponentModel.DataAnnotations.Schema;

namespace SocietySyncLibrary;

public class Event
{
    [Column("event_id")]
    public int EventID { get; set; } = -1;

    [Column("society_id")]
    public int SocietyID { get; set; } = -1;

    [Column("title")]
    public string? Title { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("start_date")]
    public DateTime StartDate { get; set; }

    [Column("end_date")]
    public DateTime EndDate { get; set; }

    [Column("location")]
    public string? Location { get; set; }

    [Column("created_by")]
    public int CreatedBy { get; set; } = -1;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}
