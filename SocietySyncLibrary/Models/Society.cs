using System.ComponentModel.DataAnnotations.Schema;

namespace SocietySyncLibrary;

public class Society
{
    [Column("society_id")]
    public int SocietyID { get; set; } = -1;

    [Column("name")]
    public string? Name { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("president")]
    public int? President { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}
