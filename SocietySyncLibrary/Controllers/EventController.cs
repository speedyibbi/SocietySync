using System.Data;
using Dapper;

namespace SocietySyncLibrary;

public static class EventController
{
    private static readonly IDbConnection _connection = Database.Instance.Connection;

    public static bool Save(Event e)
    {
        try
        {
            const string insertSql = "INSERT INTO Events (society_id, title, description, start_date, end_date, location, created_by, created_at) VALUES (@societyId, @title, @description, @startDate, @endDate, @location, @createdBy, @createdAt)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@societyId", e.SocietyID);
            parameters.Add("@title", e.Title);
            parameters.Add("@description", e.Description);
            parameters.Add("@startDate", e.StartDate);
            parameters.Add("@endDate", e.EndDate);
            parameters.Add("@location", e.Location);
            parameters.Add("@createdBy", e.CreatedBy);
            parameters.Add("@createdAt", DateTime.UtcNow);

            _connection.Execute(insertSql, parameters);

            return true;
        }
        catch
        {
            return false;
        }
    }

    public static Event? Find(int eventId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Events WHERE event_id = @eventId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@eventId", eventId);

        return _connection.QuerySingleOrDefault<Event>(sql, parameters);
    }

    public static IEnumerable<Event> FindAll()
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Events";

        return _connection.Query<Event>(sql);
    }

    public static bool Update(Event e)
    {
        const string sql = "UPDATE Events SET society_id = @societyId, title = @title, description = @description, start_date = @startDate, end_date = @endDate, location = @location, created_by = @createdBy, created_at = @createdAt WHERE event_id = @eventId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@eventId", e.EventID);
        parameters.Add("@societyId", e.SocietyID);
        parameters.Add("@title", e.Title);
        parameters.Add("@description", e.Description);
        parameters.Add("@startDate", e.StartDate);
        parameters.Add("@endDate", e.EndDate);
        parameters.Add("@location", e.Location);
        parameters.Add("@createdBy", e.CreatedBy);
        parameters.Add("@createdAt", e.CreatedAt);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }

    public static bool Delete(int eventId)
    {
        const string sql = "DELETE FROM Events WHERE event_id = @eventId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@eventId", eventId);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }
}
