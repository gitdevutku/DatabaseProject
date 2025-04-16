using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ******");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            string tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------");


            SqlConnection sqlConnection = new SqlConnection("Data Source=UTKU\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from TblCategory", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            sqlConnection.Close();
            foreach (DataRow item in dataTable.Rows)
            {
                foreach (var row in item.ItemArray)
                {
                    Console.Write(row.ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
