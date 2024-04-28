using System.Data;
using System.Text;
using Dapper;

namespace SocietySyncLibrary;

public static class GeneralController
{
    private static readonly IDbConnection _connection = Database.Instance.Connection;

    public static IEnumerable<dynamic> GetAnnouncementsForUser(int userId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;
        
        string sql = @"
            SELECT Announcements.*, Users.first_name, Users.last_name, Societies.name
            FROM Announcements
            JOIN Users ON Announcements.user_id = Users.user_id
            JOIN Societies ON Announcements.society_id = Societies.society_id
            JOIN Memberships ON Societies.society_id = Memberships.society_id
            WHERE Memberships.user_id = @userId;";

        return _connection.Query<dynamic>(sql, new { userId });
    }

    public static IEnumerable<Society> GetJoinedSocietiesForUser(int userId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = @"
            SELECT Societies.*
            FROM Societies
            JOIN Memberships ON Societies.society_id = Memberships.society_id
            WHERE Memberships.user_id = @userId;";

        return _connection.Query<Society>(sql, new { userId });
    }

    public static IEnumerable<Society> GetDiscoverableSocietiesForUser(int userId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = @"
            SELECT *
            FROM Societies
            WHERE society_id NOT IN (
                SELECT society_id
                FROM Memberships
                WHERE user_id = @userId
            );";

        return _connection.Query<Society>(sql, new { userId });
    }

    public static IEnumerable<dynamic> GetParticipatingEventsForUser(int userId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        string sql = @"
            SELECT Events.*, Societies.name as society_name
            FROM Events
            JOIN Societies ON Events.society_id = Societies.society_id
            JOIN Memberships ON Societies.society_id = Memberships.society_id
            WHERE Memberships.user_id = @userId;";

        return _connection.Query<dynamic>(sql, new { userId });
    }

    public static IEnumerable<dynamic> GetOtherEventsForUser(int userId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        string sql = @"
            SELECT Events.*, Societies.name as society_name
            FROM Events
            JOIN Societies ON Events.society_id = Societies.society_id
            WHERE event_id NOT IN (
                SELECT Events.event_id
                FROM Events
                JOIN Societies ON Events.society_id = Societies.society_id
                JOIN Memberships ON Societies.society_id = Memberships.society_id
                WHERE Memberships.user_id = @userId
            );";

        return _connection.Query<dynamic>(sql, new { userId });
    }

    public static IEnumerable<dynamic> GetMembersBySocietyId(int societyId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = @"
            SELECT Users.*, Memberships.membership_id, Memberships.joined_at, UserRoles.name as role_name
            FROM Users
            JOIN Memberships ON Users.user_id = Memberships.user_id
            JOIN UserRoles ON Memberships.role_id = UserRoles.role_id
            WHERE Memberships.society_id = @societyId;";

        return _connection.Query<dynamic>(sql, new { societyId });
    }

    public static IEnumerable<dynamic> GetAnnouncementsBySocietyId(int societyId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = @"
            SELECT Announcements.*, Users.user_id, Users.first_name, Users.last_name
            FROM Announcements
            JOIN Users ON Announcements.user_id = Users.user_id
            JOIN Societies ON Announcements.society_id = Societies.society_id
            WHERE Societies.society_id = @societyId;";

        return _connection.Query<dynamic>(sql, new { societyId });
    }

    public static User? GetPresidentBySocietyId(int societyId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = @"
            SELECT Users.*
            FROM Users
            JOIN Societies ON Users.user_id = Societies.president
            WHERE Societies.society_id = @societyId;";

        return _connection.QuerySingleOrDefault<User>(sql, new { societyId });
    }

    public static UserRole? GetUserRoleInSociety(int userId, int societyId)
    {
        const string sql = @"
            SELECT UserRoles.*
            FROM Memberships
            JOIN UserRoles ON Memberships.role_id = UserRoles.role_id
            WHERE Memberships.user_id = @userId AND Memberships.society_id = @societyId;";

        return _connection.QuerySingleOrDefault<UserRole>(sql, new { userId, societyId });
    }
}
