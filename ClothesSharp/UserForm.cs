using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ClothesSharp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {

            if (AcName.Text == "" || AcPass.Text == "" || AcPhone.Text == "" || AcEmail.Text == "" || AcCpf.Text == "")
            {
                MessageBox.Show("Preencha todas os campos");
            }
            else
            {
                try
                {
                    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\ClothesSharp.mdf;Integrated Security=True;Connect Timeout=30");

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into AccountTbl(name,cpf,email,phone,password)values(@name,@cpf,@email,@phone,@password)", Con);
                    cmd.Parameters.AddWithValue("@name", AcName.Text);
                    cmd.Parameters.AddWithValue("@cpf", AcCpf.Text);
                    cmd.Parameters.AddWithValue("@email", AcEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", AcPhone.Text);
                    cmd.Parameters.AddWithValue("@password", AcPass.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Conta criada com sucesso :D");
                    Con.Close();
                    this.Hide();
                    Login login = new Login();
                    login.Show();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
    }
}
