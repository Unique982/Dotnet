using MySql.Data.MySqlClient;
using System;

namespace lab_8
{
    internal class Example5
    {
        public static void Main(string[] args)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3307;database=bank;uid=root;password='';");
            conn.Open();

          
            string sql = "INSERT INTO customer (`id`, `account_no`, `name`, `address`, `deposit_amount`) " +
                         "VALUES (1, '1234567890918245', 'Unique Neupane', 'Dang', 17000), " +
                         "(2, '1231566777677777', 'Ram', 'KTM', 1500), " +
                         "(3, '1267823445566678', 'Hari', 'PKR', 250)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
                Console.WriteLine(row + " rows inserted.");
            else
                Console.WriteLine("Insertion failed");

            // Corrected SQL delete statement
            string sql2 = "DELETE FROM customer WHERE deposit_amount < 500";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            int row2 = cmd2.ExecuteNonQuery();
            if (row2 > 0)
                Console.WriteLine(row2 + " rows deleted.");
            else
                Console.WriteLine("Deletion failed");

            conn.Close();
            Console.ReadKey();
        }
    }
}
