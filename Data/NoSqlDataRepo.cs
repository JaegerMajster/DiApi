namespace DiApi.Data
{
    public class NoSqlDataRepo : IDataRepo
    {
        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Getting data from No SQL Databse...");
            Console.ResetColor();

            return("No SQL Data from DB");
        }
    }
}
#pragma warning restore format