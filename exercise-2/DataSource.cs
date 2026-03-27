using Microsoft.Data.Sqlite;

class DataSource
{
    public SqliteConnection DbHandle { get; set; }
    
    bool newlyCreated()
    {
        // TODO. query for tables, if they don't exist, we'll populate them
    }

    void populateWithExampleData()
    {
        // TODO.
    }

    public DataSource(string connectionString) {
        DbHandle = new SqliteConnection(connectionString);
        DbHandle.Open();

        if (newlyCreated()) populateWithExampleData();
    }
}