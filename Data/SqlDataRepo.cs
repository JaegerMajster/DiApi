namespace DiApi.Data
{
    public class SqlDataRepo
    {
        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--> Getting data from SQL Databse...");
            Console.ResetColor();

            return("SQL Data from DB");
        }
    }
}
#pragma warning restore format