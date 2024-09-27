using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

public class Example6
{
    public static void Main(string[] args)
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3307;database=bank;uid=root;password='';");
        conn.Open();
        string sql = "select * from customer";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        MySqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Console.WriteLine("Customer ID = " + dr[0] + " Account = " + dr[1] + " name = " + dr[2] + " address = " + dr[3] + "deposit_amount = " + dr[4]);
        }
        dr.Close();
        string sql2 = "UPDATE customer SET address = 'kathmandu' WHERE account_no = 1234;";

        MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
        int row2 = cmd2.ExecuteNonQuery();
        if (row2 > 0)
            Console.WriteLine(row2 + " row updated.");
        else
            Console.WriteLine("updation failed");

        conn.Close();
        Console.ReadKey();
    }
}