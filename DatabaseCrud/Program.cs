using System;
using System.Collections.Generic;
using System.Data;
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
            #region Kategori ekleme işlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection sqlConnection = new SqlConnection("Data Source = UTKU\\SQLEXPRESS ; initial catalog=EgitimKampiDb;integrated security=true");
            //sqlConnection.Open();

            //SqlCommand cmd = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", sqlConnection);
            //cmd.Parameters.AddWithValue("@p1", categoryName);
            //cmd.ExecuteNonQuery();
            //sqlConnection.Close();
            #endregion
            #region Ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;
            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=UTKU\\SQLEXPRESS;initial catalog =EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Başarılı");
            #endregion;
            #region Ürün Listeleme İşlemi

            //SqlConnection sqlConnection = new SqlConnection("Data Source=UTKU\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("select * from TblProduct", sqlConnection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}


            //sqlConnection.Close();










            #endregion
            #region Ürün silme işlemi
            //Console.Write("Silinecek Ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=UTKU\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("DELETE FROM TblProduct Where ProductID=@productID", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı");



            #endregion
            #region Ürün güncelleme işlemi
            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=UTKU\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName = @productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Güncelleme Başarılı !");
            #endregion
        }
    }
}
