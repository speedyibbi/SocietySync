using System.Data;
using Dapper;

namespace SocietySyncLibrary;

public static class TeamController
{
    private static readonly IDbConnection _connection = Database.Instance.Connection;

    public static bool Save(Team team)
    {
        try
        {
            const string insertSql = "INSERT INTO Teams (event_id, name, description, team_head_id, created_at) VALUES (@eventId, @name, @description, @teamHeadId, @createdAt)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@eventId", team.EventID);
            parameters.Add("@name", team.Name);
            parameters.Add("@description", team.Description);
            parameters.Add("@teamHeadId", team.TeamHeadID);
            parameters.Add("@createdAt", DateTime.UtcNow);

            _connection.Execute(insertSql, parameters);

            return true;
        }
        catch
        {
            return false;
        }
    }

    public static Team? Find(int teamId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Teams WHERE team_id = @teamId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@teamId", teamId);

        return _connection.QuerySingleOrDefault<Team>(sql, parameters);
    }

    public static IEnumerable<Team> FindAll()
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Teams";

        return _connection.Query<Team>(sql);
    }

    public static bool Update(Team team)
    {
        const string sql = "UPDATE Teams SET event_id = @eventId, name = @name, description = @description, team_head_id = @teamHeadId, created_at = @createdAt WHERE team_id = @teamId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@teamId", team.TeamID);
        parameters.Add("@eventId", team.EventID);
        parameters.Add("@name", team.Name);
        parameters.Add("@description", team.Description);
        parameters.Add("@teamHeadId", team.TeamHeadID);
        parameters.Add("@createdAt", team.CreatedAt);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }

    public static bool Delete(int teamId)
    {
        const string sql = "DELETE FROM Teams WHERE team_id = @teamId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@teamId", teamId);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }
}
