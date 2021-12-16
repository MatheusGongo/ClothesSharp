using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen;

namespace ClothesSharp
{
    public partial class ProcessPayment : Form
    {
        public ProcessPayment()
        {
            InitializeComponent();
        }

        private void qrCode_Click(object sender, EventArgs e)
        {
            string formatTxtQRCode = "Você pagou R$ " + Product.NewValue.ToString();
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            PaymentMethod.QrCode = qrcode.Draw(formatTxtQRCode, 50);

            this.Hide();
            PayPix pay = new PayPix();
            pay.Show();
        }
    }
}
