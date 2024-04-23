using System.Data;
using Dapper;

namespace SocietySyncLibrary;

public static class TeamMemberController
{
    private static readonly IDbConnection _connection = Database.Instance.Connection;

    public static bool Save(TeamMember teamMember)
    {
        try
        {
            const string insertSql = "INSERT INTO TeamMembers (team_id, user_id) VALUES (@teamId, @userId)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@teamId", teamMember.TeamID);
            parameters.Add("@userId", teamMember.UserID);

            _connection.Execute(insertSql, parameters);

            return true;
        }
        catch
        {
            return false;
        }
    }

    public static TeamMember? Find(int teamMemberId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM TeamMembers WHERE team_member_id = @teamMemberId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@teamMemberId", teamMemberId);

        return _connection.QuerySingleOrDefault<TeamMember>(sql, parameters);
    }

    public static IEnumerable<TeamMember> FindAll()
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM TeamMembers";

        return _connection.Query<TeamMember>(sql);
    }

    public static bool Update(TeamMember teamMember)
    {
        const string sql = "UPDATE TeamMembers SET team_id = @teamId, user_id = @userId WHERE team_member_id = @teamMemberId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@teamMemberId", teamMember.TeamMemberID);
        parameters.Add("@teamId", teamMember.TeamID);
        parameters.Add("@userId", teamMember.UserID);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }

    public static bool Delete(int teamMemberId)
    {
        const string sql = "DELETE FROM TeamMembers WHERE team_member_id = @teamMemberId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@teamMemberId", teamMemberId);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }
}
