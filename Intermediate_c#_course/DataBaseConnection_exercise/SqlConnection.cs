using System;

namespace DataBaseConnection_exercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string ConnectionString) : base(ConnectionString)
        {
        }

        public override void closeConnection()
        {
            System.Console.WriteLine("Closing Connection from Sql");
        }

        public override void openConnection()
        {
            System.Console.WriteLine("Opening Connection from Sql");
        }
    }
}
