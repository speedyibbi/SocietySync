using System.ComponentModel.DataAnnotations.Schema;

namespace SocietySyncLibrary;

public class Membership
{
    [Column("membership_id")]
    public int MembershipID { get; set; } = -1;

    [Column("user_id")]
    public int UserID { get; set; } = -1;

    [Column("society_id")]
    public int SocietyID { get; set; } = -1;

    [Column("role_id")]
    public int RoleID { get; set; } = -1;

    [Column("joined_at")]
    public DateTime JoinedAt { get; set; }
}
