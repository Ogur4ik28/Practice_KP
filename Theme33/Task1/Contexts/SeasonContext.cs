using SQLite;
using Task1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task1.Data
{
    public class SeasonData
    {
        private readonly SQLiteAsyncConnection _dbConnection;

        public SeasonData(string dbPath)
        {
            _dbConnection = new SQLiteAsyncConnection(dbPath);
            _dbConnection.ExecuteAsync("PRAGMA foreign_keys = ON;").Wait();
        }

        public async Task<List<Season>> RetrieveSeasonsAsync()
        {
            return await _dbConnection.Table<Season>().ToListAsync();
        }

        public async Task<int> InsertSeasonAsync(Season season)
        {
            return await _dbConnection.InsertAsync(season);
        }

        public async Task<int> RemoveSeasonAsync(int seasonId)
        {
            var season = await _dbConnection.Table<Season>().Where(s => s.SeasonId == seasonId).FirstOrDefaultAsync();
            if (season != null)
            {
                return await _dbConnection.DeleteAsync(season);
            }
            return 0;
        }
    }
}
