using System.Data;
using Dapper;

namespace SocietySyncLibrary;

public static class AnnouncementController
{
    private static readonly IDbConnection _connection = Database.Instance.Connection;

    public static bool Save(Announcement announcement)
    {
        try
        {
            const string insertSql = "INSERT INTO Announcements (user_id, event_id, text, created_at) VALUES (@userId, @eventId, @text, @createdAt)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@userId", announcement.UserID);
            parameters.Add("@eventId", announcement.EventID);
            parameters.Add("@text", announcement.Text);
            parameters.Add("@createdAt", DateTime.UtcNow);

            _connection.Execute(insertSql, parameters);

            return true;
        }
        catch
        {
            return false;
        }
    }

    public static Announcement? Find(int announcementId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Announcements WHERE announcement_id = @announcementId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@announcementId", announcementId);

        return _connection.QuerySingleOrDefault<Announcement>(sql, parameters);
    }

    public static IEnumerable<Announcement> FindAll()
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Announcements";

        return _connection.Query<Announcement>(sql);
    }

    public static bool Update(Announcement announcement)
    {
        const string sql = "UPDATE Announcements SET user_id = @userId, event_id = @eventId, text = @text, created_at = @createdAt WHERE announcement_id = @announcementId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@announcementId", announcement.AnnouncementID);
        parameters.Add("@userId", announcement.UserID);
        parameters.Add("@eventId", announcement.EventID);
        parameters.Add("@text", announcement.Text);
        parameters.Add("@createdAt", announcement.CreatedAt);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }

    public static bool Delete(int announcementId)
    {
        const string sql = "DELETE FROM Announcements WHERE announcement_id = @announcementId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@announcementId", announcementId);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }
}
