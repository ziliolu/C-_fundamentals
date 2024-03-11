using System;

namespace Extensibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            DbMigrator dbMigrator1 = new DbMigrator(new FileLogger(@"C:\Users\lpicoliz\OneDrive - NTT DATA EMEAL\Documentos\Udemy\Course_II\Extensibility\Program.cs"));
            dbMigrator.Migrate();
            
        }
    }
}
