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

    public partial class ListProducts : UserControl
    {
        public ListProducts()
        {
            InitializeComponent();
        }

        private string _title;
        private string _newValue;
        private Image _image;
        private string _parcels;
        private string _subscript;
        private string _chip;
        private string _idProduct;


        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string NewValue
        {
            get { return _newValue; }
            set { _newValue = value; lblNewValue.Text = value; }
        }

        [Category("Custom Props")]
        public Image ImageProduct
        {
            get { return _image; }
            set { _image = value; productImage.Image = value; }
        }


        [Category("Custom Props")]
        public string Subscript
        {
            get { return _subscript; }
            set { _subscript = value; lblSubscript.Text = value; }
        }


        [Category("Custom Props")]
        public string Parcels
        {
            get { return _parcels; }
            set { _parcels = value; lblParcels.Text = value; }
        }

        [Category("Custom Props")]
        public string Chip
        {
            get { return _chip; }
            set { _chip = value; chipImage.Text = value; }
        }

        public string IdProduct
        {
            get { return _idProduct; }
            set { _idProduct = value; idProduct.Text = value; }
        }

    }



}
