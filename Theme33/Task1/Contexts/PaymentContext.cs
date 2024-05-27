using SQLite;
using Task1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task1.Data
{
    public class PaymentData
    {
        private readonly SQLiteAsyncConnection _dbConnection;

        public PaymentData(string dbPath)
        {
            _dbConnection = new SQLiteAsyncConnection(dbPath);
            _dbConnection.ExecuteAsync("PRAGMA foreign_keys = ON;").Wait();
        }

        public async Task<List<Payment>> RetrievePaymentsAsync()
        {
            return await _dbConnection.Table<Payment>().ToListAsync();
        }

        public async Task<int> InsertPaymentAsync(Payment payment)
        {
            return await _dbConnection.InsertAsync(payment);
        }

        public async Task<int> RemovePaymentAsync(int paymentId)
        {
            var payment = await _dbConnection.Table<Payment>().Where(p => p.PaymentId == paymentId).FirstOrDefaultAsync();
            if (payment != null)
            {
                return await _dbConnection.DeleteAsync(payment);
            }
            return 0;
        }
    }
}
