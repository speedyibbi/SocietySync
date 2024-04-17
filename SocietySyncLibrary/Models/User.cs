using System.ComponentModel.DataAnnotations.Schema;

namespace SocietySyncLibrary;

public class User
{
    [Column("user_id")]
    public int UserID { get; set; } = -1;

    [Column("email")]
    public string? Email { get; set; }

    [Column("password_hash")]
    public string? PasswordHash { get; set; }

    [Column("first_name")]
    public string? FirstName { get; set; }

    [Column("last_name")]
    public string? LastName { get; set; }

    [Column("phone_number")]
    public string? PhoneNumber { get; set; }
    
    [Column("admin")]
    public bool Admin { get; set; } = false;
}
