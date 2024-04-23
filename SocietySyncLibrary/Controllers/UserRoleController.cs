using System.Data;
using Dapper;

namespace SocietySyncLibrary;

public static class UserRoleController
{
    private static readonly IDbConnection _connection = Database.Instance.Connection;

    public static bool Save(UserRole userRole)
    {
        try
        {
            const string insertSql = "INSERT INTO UserRoles (name, description) VALUES (@name, @description)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@name", userRole.Name);
            parameters.Add("@description", userRole.Description);

            _connection.Execute(insertSql, parameters);

            return true;
        }
        catch
        {
            return false;
        }
    }

    public static UserRole? Find(int roleId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM UserRoles WHERE role_id = @roleId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@roleId", roleId);

        return _connection.QuerySingleOrDefault<UserRole>(sql, parameters);
    }

    public static IEnumerable<UserRole> FindAll()
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM UserRoles";

        return _connection.Query<UserRole>(sql);
    }

    public static bool Update(UserRole userRole)
    {
        const string sql = "UPDATE UserRoles SET name = @name, description = @description WHERE role_id = @roleId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@roleId", userRole.RoleID);
        parameters.Add("@name", userRole.Name);
        parameters.Add("@description", userRole.Description);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }

    public static bool Delete(int roleId)
    {
        const string sql = "DELETE FROM UserRoles WHERE role_id = @roleId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@roleId", roleId);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }
}
