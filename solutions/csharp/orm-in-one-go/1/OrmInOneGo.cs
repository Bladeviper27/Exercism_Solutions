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
        using var db = this.database;
        try 
        {
            db.BeginTransaction();
            db.Write(data);
            db.EndTransaction();
        }
        catch (Exception)
        {
            db.Dispose();
            throw;
        }
    }

    public bool WriteSafely(string data)
    {
        using var db = this.database;
        try
        {
            db.BeginTransaction();
            db.Write(data);
            db.EndTransaction();
            return true;
        }
        catch (Exception)
        {
            db.Dispose();
            return false;
        }
    }
}
