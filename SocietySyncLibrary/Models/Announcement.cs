using System.ComponentModel.DataAnnotations.Schema;

namespace SocietySyncLibrary;

public class Announcement
{
    [Column("announcement_id")]
    public int AnnouncementID { get; set; } = -1;

    [Column("user_id")]
    public int UserID { get; set; } = -1;

    [Column("event_id")]
    public int EventID { get; set; } = -1;

    [Column("text")]
    public string? Text { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}
