using Microsoft.Data.SqlClient;

namespace SocietySyncLibrary;

public sealed class Database
{
    private static Database? _instance;
    private static readonly object _syncRoot = new object();
    private readonly SqlConnection _connection;

    public static Database Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new Database();
                    }
                }
            }
            return _instance;
        }
    }

    public SqlConnection Connection
    {
        get { return _connection; }
    }

    private Database()
    {
        _connection = new SqlConnection("Data Source=LOPTAP\\SQLEXPRESS;Initial Catalog=SocietySyncDB;Integrated Security=True;Trust Server Certificate=True");
        _connection.Open();
    }

    ~Database()
    {
        _connection.Close();
    }
}
