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
    public partial class ProductsPage : Form
    {
        public ProductsPage()
        {
            InitializeComponent();
        }


        private void progressive_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProdutcsProgressive produtcsProgressive = new ProdutcsProgressive();
            produtcsProgressive.Show();
        }

        private void aproveite_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProdutcsProgressive produtcsProgressive = new ProdutcsProgressive();
            produtcsProgressive.Show();
        }
    }
}
