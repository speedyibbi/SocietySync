using System.ComponentModel.DataAnnotations.Schema;

namespace SocietySyncLibrary;

public class UserRole
{
    [Column("role_id")]
    public int RoleID { get; set; } = -1;

    [Column("name")]
    public string? Name { get; set; }

    [Column("description")]
    public string? Description { get; set; }
}
