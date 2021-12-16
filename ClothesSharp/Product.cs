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
    public class Product
    {
        private static string _title;
        private static string _newValue;
        private static Image _image;
        private static string _parcels;
        private static string _subscript;
        private static string _chip;
        private static string _idProduct;


        public static string Title
        {
            get { return _title; }
            set { _title = value;}
        }

        public static string NewValue
        {
            get { return _newValue; }
            set { _newValue = value;}
        }

        public static Image ImageProduct
        {
            get { return _image; }
            set { _image = value;}
        }


        public static string Subscript
        {
            get { return _subscript; }
            set { _subscript = value;}
        }


        public static string Parcels
        {
            get { return _parcels; }
            set { _parcels = value;}
        }

        public static string Chip
        {
            get { return _chip; }
            set { _chip = value;}
        }

        public static string IdProduct
        {
            get { return _idProduct; }
            set { _idProduct = value;}
        }
    }
}
