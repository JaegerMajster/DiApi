using DiApi.DataServices;

namespace DiApi.Data
{
    public class NoSqlDataRepo : IDataRepo
    {

        // private readonly IDataService _dataService;
        private readonly IServiceScopeFactory _scopeFactory;

        // public NoSqlDataRepo(IDataService dataService)
        // {
        //     _dataService = dataService;
        // }

        public NoSqlDataRepo(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }
        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Getting data from No SQL Databse...");
            //_dataService.GetProductData("https://ckziumm.edu.pl");
            using (var scope = _scopeFactory.CreateScope())
            {
                var dataService = scope.ServiceProvider.GetRequiredService<IDataService>();
                dataService.GetProductData("https://ckziumm.edu.pl");
                Console.ResetColor();

                return("No SQL Data from DB");
            }
            
        }
    }
}
#pragma warning restore format