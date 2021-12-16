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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            passInput.PasswordChar = '*';
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (emailInput.Text == "" || passInput.Text == "")
            {
                MessageBox.Show("Senha ou login estão incorretos");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\ClothesSharp.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand command = new SqlCommand("SELECT name, cpf, email, phone, password FROM AccountTbl WHERE email=@email and password=@pass", conn);

                command.Parameters.AddWithValue("@email", emailInput.Text);
                command.Parameters.AddWithValue("@pass", passInput.Text);

                conn.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        ProductsPage obj = new ProductsPage();
                        obj.Show();
                        this.Hide();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Senha ou login estão incorretos");
                    }
                }
            }
        }
    }
}
