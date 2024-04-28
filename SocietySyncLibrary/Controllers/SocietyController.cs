using System.Data;
using System.Net.Sockets;
using Dapper;

namespace SocietySyncLibrary;

public static class SocietyController
{
    private static readonly IDbConnection _connection = Database.Instance.Connection;

    public static bool Save(Society society)
    {
        IDbTransaction dbTransaction = _connection.BeginTransaction();

        try
        {
            const string insertSocietySql = "INSERT INTO Societies (name, description, president, created_at) VALUES (@name, @description, @president, @createdAt); SELECT CAST(SCOPE_IDENTITY() as int);";
            DynamicParameters societyParams = new DynamicParameters();
            societyParams.Add("@name", society.Name);
            societyParams.Add("@description", society.Description);
            societyParams.Add("@president", society.President);
            societyParams.Add("@createdAt", DateTime.UtcNow);

            int societyId = _connection.Query<int>(insertSocietySql, societyParams, transaction: dbTransaction).Single();

            const string roleSql = "SELECT role_id FROM UserRoles WHERE name = 'President'";
            int roleId = _connection.Query<int>(roleSql, transaction: dbTransaction).FirstOrDefault();

            const string insertMembershipSql = "INSERT INTO Memberships (user_id, society_id, role_id, joined_at) VALUES (@userId, @societyId, @roleId, @joinedAt)";
            DynamicParameters membershipParams = new DynamicParameters();
            membershipParams.Add("@userId", society.President);
            membershipParams.Add("@societyId", societyId);
            membershipParams.Add("@roleId", roleId);
            membershipParams.Add("@joinedAt", DateTime.UtcNow);

            _connection.Execute(insertMembershipSql, membershipParams, transaction: dbTransaction);

            dbTransaction.Commit();

            return true;
        }
        catch
        {
            dbTransaction.Rollback();

            return false;
        }
    }

    public static Society? Find(int societyId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Societies WHERE society_id = @societyId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@societyId", societyId);

        return _connection.QuerySingleOrDefault<Society>(sql, parameters);
    }

    public static Society? FindByName(string name)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Societies WHERE name = @name";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@name", name);

        return _connection.QuerySingleOrDefault<Society>(sql, parameters);
    }

    public static IEnumerable<Society> FindAll()
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Societies";
        
        return _connection.Query<Society>(sql);
    }

    public static bool Update(Society society)
    {
        using (var transaction = _connection.BeginTransaction())
        {
            try
            {
                const string getOldPresidentSql = "SELECT president FROM Societies WHERE society_id = @societyId";
                var oldPresidentId = _connection.QuerySingleOrDefault<int?>(getOldPresidentSql, new { societyId = society.SocietyID }, transaction);

                const string updateSocietySql = "UPDATE Societies SET name = @name, description = @description, president = @president, created_at = @createdAt WHERE society_id = @societyId";
                DynamicParameters societyParams = new DynamicParameters();
                societyParams.Add("@societyId", society.SocietyID);
                societyParams.Add("@name", society.Name);
                societyParams.Add("@description", society.Description);
                societyParams.Add("@president", society.President);
                societyParams.Add("@createdAt", society.CreatedAt);

                _connection.Execute(updateSocietySql, societyParams, transaction);

                if (oldPresidentId != society.President)
                {
                    if (oldPresidentId.HasValue && oldPresidentId.Value != 0)
                    {
                        const string removeOldPresidentSql = "UPDATE Memberships SET role_id = (SELECT role_id FROM UserRoles WHERE name = 'Pending') WHERE user_id = @userId AND society_id = @societyId";
                        _connection.Execute(removeOldPresidentSql, new { userId = oldPresidentId.Value, societyId = society.SocietyID }, transaction);
                    }

                    if (society.President.HasValue && society.President.Value != 0)
                    {
                        const string assignNewPresidentSql = "UPDATE Memberships SET role_id = (SELECT role_id FROM UserRoles WHERE name = 'President') WHERE user_id = @userId AND society_id = @societyId";
                        _connection.Execute(assignNewPresidentSql, new { userId = society.President.Value, societyId = society.SocietyID }, transaction);
                    }
                }

                transaction.Commit();

                return true;
            }
            catch
            {
                transaction.Rollback();

                return false;
            }
        }
    }

    public static bool Delete(int societyId)
    {
        const string sql = "DELETE FROM Societies WHERE society_id = @societyId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@societyId", societyId);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }

    public static bool AddUserToSociety(int societyId, int userId)
    {
        IDbTransaction dbTransaction = _connection.BeginTransaction();

        try
        {
            const string roleSql = "SELECT role_id FROM UserRoles WHERE name = 'Pending'";
            int roleId = _connection.Query<int>(roleSql, transaction: dbTransaction).FirstOrDefault();

            const string insertMembershipSql = "INSERT INTO Memberships (user_id, society_id, role_id, joined_at) VALUES (@userId, @societyId, @roleId, @joinedAt)";
            DynamicParameters membershipParams = new DynamicParameters();
            membershipParams.Add("@userId", userId);
            membershipParams.Add("@societyId", societyId);
            membershipParams.Add("@roleId", roleId);
            membershipParams.Add("@joinedAt", DateTime.UtcNow);

            _connection.Execute(insertMembershipSql, membershipParams, transaction: dbTransaction);

            dbTransaction.Commit();

            return true;
        }
        catch
        {
            dbTransaction.Rollback();

            return false;
        }
    }
}
