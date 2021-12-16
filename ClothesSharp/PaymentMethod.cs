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
    public class PaymentMethod
    {
        private static Image _qrCode;
        private static Image _barCode;


        public static Image QrCode
        {
            get { return _qrCode; }
            set { _qrCode = value; }
        }

        public static Image BarCode
        {
            get { return _barCode; }
            set { _barCode = value; }
        }
    }
}
