namespace DiApi.Data
{
    public class NoSqlDataRepo
    {
        public string GetData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Getting data from No SQL Databse...");
            Console.ResetColor();

            return("No SQL Data from DB");
        }
    }
}
#pragma warning restore format