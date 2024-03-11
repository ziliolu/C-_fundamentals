using System;

namespace DataBaseConnection_exercise
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }

        public DbConnection(string ConnectionString)
        {
            if(!ConnectionString.Any())
                	throw new ArgumentNullException();
            this.ConnectionString = ConnectionString;
        }

        public abstract void openConnection();
        public abstract void closeConnection();
    }
}
