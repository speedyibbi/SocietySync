using System.ComponentModel.DataAnnotations.Schema;

namespace SocietySyncLibrary;

public class User
{
    [Column("user_id")]
    public int UserID { get; set; } = -1;

    [Column("email")]
    public string Email { get; set; } = string.Empty;

    [Column("password_hash")]
    public string PasswordHash { get; set; } = string.Empty;
    
    [Column("first_name")]
    public string FirstName { get; set; } = string.Empty;
    
    [Column("last_name")]
    public string LastName { get; set; } = string.Empty;
    
    [Column("phone_number")]
    public string PhoneNumber { get; set; } = string.Empty;   
}