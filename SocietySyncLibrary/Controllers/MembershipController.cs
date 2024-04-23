using System.Data;
using Dapper;

namespace SocietySyncLibrary;

public static class MembershipController
{
    private static readonly IDbConnection _connection = Database.Instance.Connection;

    public static bool Save(Membership membership)
    {
        try
        {
            const string insertSql = "INSERT INTO Memberships (user_id, society_id, role_id, joined_at) VALUES (@userId, @societyId, @roleId, @joinedAt)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@userId", membership.UserID);
            parameters.Add("@societyId", membership.SocietyID);
            parameters.Add("@roleId", membership.RoleID);
            parameters.Add("@joinedAt", DateTime.UtcNow);

            _connection.Execute(insertSql, parameters);

            return true;
        }
        catch
        {
            return false;
        }
    }

    public static Membership? Find(int membershipId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Memberships WHERE membership_id = @membershipId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@membershipId", membershipId);

        return _connection.QuerySingleOrDefault<Membership>(sql, parameters);
    }

    public static IEnumerable<Membership> FindAll()
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Memberships";

        return _connection.Query<Membership>(sql);
    }

    public static bool Update(Membership membership)
    {
        const string sql = "UPDATE Memberships SET user_id = @userId, society_id = @societyId, role_id = @roleId, joined_at = @joinedAt WHERE membership_id = @membershipId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@membershipId", membership.MembershipID);
        parameters.Add("@userId", membership.UserID);
        parameters.Add("@societyId", membership.SocietyID);
        parameters.Add("@roleId", membership.RoleID);
        parameters.Add("@joinedAt", membership.JoinedAt);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }

    public static bool Delete(int membershipId)
    {
        const string sql = "DELETE FROM Memberships WHERE membership_id = @membershipId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@membershipId", membershipId);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }
}
