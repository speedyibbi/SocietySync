using System.ComponentModel.DataAnnotations.Schema;

namespace SocietySyncLibrary;

public class TeamMember
{
    [Column("team_member_id")]
    public int TeamMemberID { get; set; } = -1;

    [Column("team_id")]
    public int TeamID { get; set; } = -1;

    [Column("user_id")]
    public int UserID { get; set; } = -1;
}
