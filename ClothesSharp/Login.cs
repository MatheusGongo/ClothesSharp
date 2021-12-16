using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothesSharp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void clientLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin user = new UserLogin();
            user.Show();
        }

        private void vendedorLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            VendedorLogin v = new VendedorLogin();
            v.Show();
        }
    }
}
