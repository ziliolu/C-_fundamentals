using System;

namespace DataBaseConnection_exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OracleConnection oracleConnection = new OracleConnection("connection1");
            oracleConnection.openConnection();
            oracleConnection.closeConnection();

            SqlConnection sqlConnection = new SqlConnection("connection2");
             sqlConnection.openConnection();
             sqlConnection.closeConnection();
        }

    }
}
