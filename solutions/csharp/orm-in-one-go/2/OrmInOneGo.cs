using System.Net.WebSockets;

public class Orm
{
    private Database database;

    public Orm(Database database)
    {
        this.database = database;
    }

    public void Write(string data)
    {
        using (database)
        {
            database.BeginTransaction();
            database.Write(data);
            database.EndTransaction();
        }
    }

    public bool WriteSafely(string data)
    {
        using var db = database;
        try
        {
            Write(data);
            return true;
        }
        catch (Exception)
        {
            db.Dispose();
            return false;
        }
    }
}
