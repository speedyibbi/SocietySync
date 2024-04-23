using System.Data;
using Dapper;

namespace SocietySyncLibrary;

public static class TaskController
{
    private static readonly IDbConnection _connection = Database.Instance.Connection;

    public static bool Save(Task task)
    {
        try
        {
            const string insertSql = "INSERT INTO Tasks (team_id, title, description, assigned_to, due_date, created_at, completed) VALUES (@teamId, @title, @description, @assignedTo, @dueDate, @createdAt, @completed)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@teamId", task.TeamID);
            parameters.Add("@title", task.Title);
            parameters.Add("@description", task.Description);
            parameters.Add("@assignedTo", task.AssignedTo);
            parameters.Add("@dueDate", task.DueDate);
            parameters.Add("@createdAt", DateTime.UtcNow);
            parameters.Add("@completed", task.Completed);

            _connection.Execute(insertSql, parameters);

            return true;
        }
        catch
        {
            return false;
        }
    }

    public static Task? Find(int taskId)
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Tasks WHERE task_id = @taskId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@taskId", taskId);

        return _connection.QuerySingleOrDefault<Task>(sql, parameters);
    }

    public static IEnumerable<Task> FindAll()
    {
        DefaultTypeMap.MatchNamesWithUnderscores = true;

        const string sql = "SELECT * FROM Tasks";

        return _connection.Query<Task>(sql);
    }

    public static bool Update(Task task)
    {
        const string sql = "UPDATE Tasks SET team_id = @teamId, title = @title, description = @description, assigned_to = @assignedTo, due_date = @dueDate, created_at = @createdAt, completed = @completed WHERE task_id = @taskId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@taskId", task.TaskID);
        parameters.Add("@teamId", task.TeamID);
        parameters.Add("@title", task.Title);
        parameters.Add("@description", task.Description);
        parameters.Add("@assignedTo", task.AssignedTo);
        parameters.Add("@dueDate", task.DueDate);
        parameters.Add("@createdAt", task.CreatedAt);
        parameters.Add("@completed", task.Completed);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }

    public static bool Delete(int taskId)
    {
        const string sql = "DELETE FROM Tasks WHERE task_id = @taskId";
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@taskId", taskId);

        int rowsAffected = _connection.Execute(sql, parameters);

        return rowsAffected > 0;
    }
}
