using SQLite;
using Task1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task1.Data
{
    public class PackageData
    {
        private readonly SQLiteAsyncConnection _dbConnection;

        public PackageData(string databasePath)
        {
            _dbConnection = new SQLiteAsyncConnection(databasePath);
            _dbConnection.ExecuteAsync("PRAGMA foreign_keys = ON;").Wait();
        }

        public async Task<List<Package>> RetrievePackagesAsync()
        {
            return await _dbConnection.Table<Package>().ToListAsync();
        }

        public async Task<int> InsertPackageAsync(Package package)
        {
            return await _dbConnection.InsertAsync(package);
        }

        public async Task<int> RemovePackageAsync(int packageId)
        {
            var package = await _dbConnection.Table<Package>().Where(p => p.PackageId == packageId).FirstOrDefaultAsync();
            if (package != null)
            {
                return await _dbConnection.DeleteAsync(package);
            }
            return 0;
        }
    }
}
