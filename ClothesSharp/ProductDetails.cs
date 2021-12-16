using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClothesSharp
{
    public partial class ProductDetails : Form
    {
        public ProductDetails()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\ClothesSharp.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand("SELECT Id, Title, NewValue, Subscript, Parcels, ImageProduct, Chip FROM tblProductsProgressive WHERE Id=@id", conn);

            command.Parameters.AddWithValue("@id", Product.IdProduct);

            conn.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Product.IdProduct = reader.GetValue(0).ToString();
                    lblTitle.Text = reader.GetValue(1).ToString();
                    lblNewValue.Text = "R$ " + reader.GetValue(2).ToString();
                    lblSubscript.Text = "R$ " + reader.GetValue(3).ToString();
                    lblParcels.Text = reader.GetValue(4).ToString();
                    productImage.Image = Image.FromFile(reader.GetValue(5).ToString());
                    chipImage.Text = reader.GetValue(6).ToString() + "%";
                    conn.Close();
                }
            }
        }

        private void addToBag_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcessPayment processPay = new ProcessPayment();
            processPay.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProdutcsProgressive produtcsProgressive = new ProdutcsProgressive();
            produtcsProgressive.Show();
        }
    }
}
