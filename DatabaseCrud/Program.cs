using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Read Update Delete
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            string categoryName = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection("Data Source = UTKU\\SQLEXPRESS ; initial catalog=EgitimKampiDb;integrated security=true");
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", categoryName);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            Console.WriteLine("")
        }
    }
}
