using System.Data;
using System.Text;
using Dapper;

namespace SocietySyncLibrary;

public static class GeneralController
{
    private static readonly IDbConnection _connection = Database.Instance.Connection;

    public static IEnumerable<dynamic> GetAnnouncementsForUser(int userId)
    {
        string[] columns = new string[] { "Users.first_name", "Users.last_name", "Societies.name", "Announcements.text", "Announcements.created_at" };

        StringBuilder columnNames = new StringBuilder();
        foreach (var column in columns)
        {
            if (columnNames.Length > 0)
                columnNames.Append(", ");
            columnNames.Append(column);
        }

        string sql = $@"
            SELECT {columnNames}
            FROM Announcements
            JOIN Users ON Announcements.user_id = Users.user_id
            JOIN Events ON Announcements.event_id = Events.event_id
            JOIN Societies ON Events.society_id = Societies.society_id
            JOIN Memberships ON Societies.society_id = Memberships.society_id
            WHERE Memberships.user_id = @userId;";

        return _connection.Query<dynamic>(sql, new { userId });
    }

    public static IEnumerable<Society> GetJoinedSocietiesForUser(int userId)
    {
        const string sql = @"
            SELECT Societies.*
            FROM Societies
            JOIN Memberships ON Societies.society_id = Memberships.society_id
            WHERE Memberships.user_id = @userId;";

        return _connection.Query<Society>(sql, new { userId });
    }

    public static IEnumerable<Society> GetDiscoverableSocietiesForUser(int userId)
    {
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
        string[] columns = new string[] { "Events.*", "Societies.name" };

        StringBuilder columnNames = new StringBuilder();
        foreach (var column in columns)
        {
            if (columnNames.Length > 0)
                columnNames.Append(", ");
            columnNames.Append(column);
        }

        string sql = $@"
            SELECT {columnNames}
            FROM Events
            JOIN Societies ON Events.society_id = Societies.society_id
            JOIN Teams ON Events.event_id = Teams.event_id
            JOIN TeamMembers ON Teams.team_id = TeamMembers.team_id
            WHERE TeamMembers.user_id = @userId;";

        return _connection.Query<dynamic>(sql, new { userId });
    }

    public static IEnumerable<dynamic> GetOtherEventsForUser(int userId)
    {
        string[] columns = new string[] { "Events.*", "Societies.name" };

        StringBuilder columnNames = new StringBuilder();
        foreach (var column in columns)
        {
            if (columnNames.Length > 0)
                columnNames.Append(", ");
            columnNames.Append(column);
        }

        string sql = $@"
            SELECT {columnNames}
            FROM Events
            JOIN Societies ON Events.society_id = Societies.society_id
            WHERE event_id NOT IN (
                SELECT Events.event_id
                FROM Events
                JOIN Teams ON Events.event_id = Teams.event_id
                JOIN TeamMembers ON Teams.team_id = TeamMembers.team_id
                WHERE TeamMembers.user_id = @userId
            );";

        return _connection.Query<dynamic>(sql, new { userId });
    }
}
