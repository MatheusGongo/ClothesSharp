using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using RestSharp;
using RestSharp.Deserializers;
using System.IO;
using System.Data.SqlClient;

namespace ClothesSharp
{

    public partial class ProdutcsProgressive : Form
    {
        public ProdutcsProgressive()
        {
            InitializeComponent();
            PopulateItens();

        }



        private void PopulateItens()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\ClothesSharp.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand("SELECT * FROM tblProductsProgressive", conn);

            conn.Open();

            //ListProducts[] listProducts = new ListProducts[20];
            List<ListProducts> lista = new List<ListProducts>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ListProducts item = new ListProducts();
                    item.IdProduct = reader.GetValue(0).ToString();
                    item.Title = reader.GetValue(1).ToString();
                    item.NewValue = "R$ " + reader.GetValue(2).ToString();
                    item.Subscript = "R$ " + reader.GetValue(3).ToString();
                    item.Parcels = reader.GetValue(4).ToString();
                    item.ImageProduct = Image.FromFile(reader.GetValue(5).ToString());
                    item.Chip = reader.GetValue(6).ToString() + "%";
                    flowLayoutPanel1.Controls.Add(item);

                    item.Click += new System.EventHandler(this.ToBag);
                }

            }


           
            //for (int i = 0; i < listProducts.Length; i++)
            //{
            //    listProducts[i] = new ListProducts();
            //    listProducts[i].Title = "Koeee";
            //    listProducts[i].NewValue = "asudghaushdgasdg";

            //    //if (flowLayoutPanel1.Controls.Count > 0)
            //    //{
            //    //    flowLayoutPanel1.Controls.Clear();
            //    //}
            //    //else
            //    flowLayoutPanel1.Controls.Add(listProducts[i]);
            //    {

            //    }
            //}


        }

        void ToBag(object sender, EventArgs e)
        {
            ListProducts currentProduct = (ListProducts)sender;
            Product getProduct = new Product();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\ClothesSharp.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand("SELECT Id, Title, NewValue, Subscript, Parcels, ImageProduct, Chip FROM tblProductsProgressive WHERE Id=@id", conn);

            command.Parameters.AddWithValue("@id", currentProduct.IdProduct);

            conn.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Product.IdProduct = reader.GetValue(0).ToString();
                    Product.Title = reader.GetValue(1).ToString();
                    Product.NewValue = reader.GetValue(2).ToString();
                    Product.Subscript = reader.GetValue(3).ToString();
                    Product.Parcels = reader.GetValue(4).ToString();
                    Product.ImageProduct = Image.FromFile(reader.GetValue(5).ToString());
                    Product.Chip = reader.GetValue(6).ToString();
                    ProductDetails obj = new ProductDetails();
                    obj.Show();
                    this.Hide();
                    conn.Close();
                }
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsPage produtcs = new ProductsPage();
            produtcs.Show();
        }
    }




    class DadosProdutos
    {
        public string productName { get; set; }
    }
}
