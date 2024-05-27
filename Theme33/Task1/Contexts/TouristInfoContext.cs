using SQLite;
using Task1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task1.Data
{
    public class TouristInfoData
    {
        private readonly SQLiteAsyncConnection _dbConnection;

        public TouristInfoData(string dbPath)
        {
            _dbConnection = new SQLiteAsyncConnection(dbPath);
            _dbConnection.ExecuteAsync("PRAGMA foreign_keys = ON;").Wait();
        }

        public async Task<List<TouristInfo>> RetrieveTouristInfosAsync()
        {
            return await _dbConnection.Table<TouristInfo>().ToListAsync();
        }

        public async Task<int> InsertTouristInfoAsync(TouristInfo touristInfo)
        {
            return await _dbConnection.InsertAsync(touristInfo);
        }

        public async Task<int> RemoveTouristInfoAsync(int touristId)
        {
            var touristInfo = await _dbConnection.Table<TouristInfo>().Where(t => t.TouristId == touristId).FirstOrDefaultAsync();
            if (touristInfo != null)
            {
                return await _dbConnection.DeleteAsync(touristInfo);
            }
            return 0;
        }
    }
}
