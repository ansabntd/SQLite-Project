using System.Data.SQLite;

namespace SQLProject.Services
{
    public class CreateSqlDb
    {
        public bool CreateSqliteDb()
        {
            try
            {
                if (!File.Exists("mydatabase.db"))
                    SQLiteConnection.CreateFile("mydatabase.db");

                using var conn = new SQLiteConnection("Data Source=./mydatabase.db");
                conn.Open();

                string sql = @"
        CREATE TABLE IF NOT EXISTS sales_data (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            receipt_number TEXT,
            sale_date TEXT,
            transaction_time TEXT,
            sale_amount REAL,
            tax_amount REAL,
            discount_amount REAL,
            round_off REAL,
            net_sale REAL,
            payment_mode TEXT,
            order_type TEXT,
            transaction_status TEXT
        );";

                using var cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
