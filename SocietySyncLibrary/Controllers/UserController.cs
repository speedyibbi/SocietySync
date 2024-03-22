﻿using System.Data;
using Dapper;
using BC = BCrypt.Net.BCrypt;

namespace SocietySyncLibrary;

public class UserController
{
    private static readonly IDbConnection _connection = Database.Instance.Connection;

    public static bool Save(User user)
    {
        try
        {
            const string insertSql = "INSERT INTO Users (email, password_hash, first_name, last_name, phone_number) VALUES (@email, @passwordHash, @firstName, @lastName, @phoneNumber)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@email", user.Email);
            parameters.Add("@passwordHash", HashPassword(user.PasswordHash!));
            parameters.Add("@firstName", user.FirstName);
            parameters.Add("@lastName", user.LastName);
            parameters.Add("@phoneNumber", user.PhoneNumber, DbType.String);

            user.UserID = _connection.ExecuteScalar<int>(insertSql, parameters);

            return true;
        }
        catch
        {
            return false;
        }
    }

    public static User? Find(int userId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Users WHERE user_id = @userId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@userId", userId);

        return _connection.QuerySingleOrDefault<User>(sql, parameters);
    }

    public static User? FindByEmail(string email)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Users WHERE email = @email";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@email", email);

        return _connection.QuerySingleOrDefault<User>(sql, parameters);
    }

    public static IEnumerable<User> FindAll()
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Users";

        return _connection.Query<User>(sql);
    }

    public static bool Update(User user, bool rehash = false)
    {
        const string sql = "UPDATE Users SET email = @email, password_hash = @passwordHash, first_name = @firstName, last_name = @lastName, phone_number = @phoneNumber WHERE user_id = @userId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@userId", user.UserID);
        parameters.Add("@email", user.Email);
        parameters.Add("@passwordHash", rehash ? HashPassword(user.PasswordHash!) : user.PasswordHash);
        parameters.Add("@firstName", user.FirstName);
        parameters.Add("@lastName", user.LastName);
        parameters.Add("@phoneNumber", user.PhoneNumber, DbType.String);

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

    private static string HashPassword(string password)
    {
        string salt = BC.GenerateSalt(12);

        return BC.HashPassword(password, salt);
    }

    private static bool VerifyPassword(string password, string passwordHash)
    {
        return BC.Verify(password, passwordHash);
    }
}