using System.Data;
using Dapper;

namespace SocietySyncLibrary;

public class SocietyController
{
    private static readonly IDbConnection _connection = Database.Instance.Connection;

    public static bool Save(Society society)
    {
        try
        {
            const string insertSql = "INSERT INTO Societies (name, description, president, created_at) VALUES (@name, @description, @president, @createdAt)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@name", society.Name);
            parameters.Add("@description", society.Description);
            parameters.Add("@president", society.PresidentUserID);
            parameters.Add("@createdAt", DateTime.UtcNow);

            _connection.Execute(insertSql, parameters);

            return true;
        }
        catch
        {
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
        const string sql = "UPDATE Societies SET name = @name, description = @description, president = @president, created_at = @createdAt WHERE society_id = @societyId";
        var parameters = new DynamicParameters();
        parameters.Add("@societyId", society.SocietyID);
        parameters.Add("@name", society.Name);
        parameters.Add("@description", society.Description);
        parameters.Add("@president", society.PresidentUserID);
        parameters.Add("@createdAt", society.CreatedAt);

        int rowsAffected = _connection.Execute(sql, parameters);
        
        return rowsAffected > 0;
    }

    public static bool Delete(int userId)
    {
        const string sql = "DELETE FROM Users WHERE user_id = @userId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@userId", userId);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }

    public static bool SeedSocieties()
    {
        try
        {
            const string insertSql = "INSERT INTO Societies (name, description, president, created_at) VALUES (@name, @description, null, @createdAt)";

            List<Society> societies = new List<Society>()
            {
              new Society { Name = "Programming Society", Description = "A society for students interested in programming." },
              new Society { Name = "Art Society", Description = "A society for students interested in visual arts." },
              new Society { Name = "Debating Society", Description = "A society for students interested in honing their debating skills." },
              new Society { Name = "Music Society", Description = "A society for students interested in music and performance." },
              new Society { Name = "Environmental Society", Description = "A society for students passionate about environmental issues." },
              new Society { Name = "Film Society", Description = "A society for students interested in films and filmmaking." },
              new Society { Name = "Gaming Society", Description = "A society for students interested in video games and esports." }
            };

            foreach (Society society in societies)
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@name", society.Name);
                parameters.Add("@description", society.Description);
                parameters.Add("@createdAt", DateTime.UtcNow);

                _connection.Execute(insertSql, parameters);
            }

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
