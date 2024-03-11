using System;

namespace DataBaseConnection_exercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string ConnectionString) : base(ConnectionString){}

        public override void closeConnection()
        {
            System.Console.WriteLine("Closing Connection from Oracle");
        }

        public override void openConnection()
        {
            System.Console.WriteLine("Opening Connection from Oracle");
        }
    }
}
