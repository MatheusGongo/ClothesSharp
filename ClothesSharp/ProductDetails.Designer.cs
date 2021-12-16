namespace ClothesSharp
{
    partial class ProductDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetails));
            this.productImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.chipImage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chipPanel = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNewValue = new System.Windows.Forms.Label();
            this.lblSubscript = new System.Windows.Forms.Label();
            this.lblParcels = new System.Windows.Forms.Label();
            this.addToBag = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chipPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // productImage
            // 
            this.productImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productImage.BackgroundImage")));
            this.productImage.Image = ((System.Drawing.Image)(resources.GetObject("productImage.Image")));
            this.productImage.ImageRotate = 0F;
            this.productImage.Location = new System.Drawing.Point(51, 53);
            this.productImage.Name = "productImage";
            this.productImage.ShadowDecoration.Parent = this.productImage;
            this.productImage.Size = new System.Drawing.Size(377, 501);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productImage.TabIndex = 41;
            this.productImage.TabStop = false;
            // 
            // chipImage
            // 
            this.chipImage.AutoSize = true;
            this.chipImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.chipImage.Font = new System.Drawing.Font("Reserva Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipImage.ForeColor = System.Drawing.Color.White;
            this.chipImage.Location = new System.Drawing.Point(468, 60);
            this.chipImage.Name = "chipImage";
            this.chipImage.Size = new System.Drawing.Size(66, 32);
            this.chipImage.TabIndex = 45;
            this.chipImage.Text = "40%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.label1.Font = new System.Drawing.Font("Reserva Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(540, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "OFF";
            // 
            // chipPanel
            // 
            this.chipPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.chipPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.chipPanel.ImageRotate = 0F;
            this.chipPanel.Location = new System.Drawing.Point(461, 53);
            this.chipPanel.Name = "chipPanel";
            this.chipPanel.ShadowDecoration.Parent = this.chipPanel;
            this.chipPanel.Size = new System.Drawing.Size(153, 50);
            this.chipPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chipPanel.TabIndex = 44;
            this.chipPanel.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Reserva Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(455, 124);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 36);
            this.lblTitle.TabIndex = 47;
            this.lblTitle.Text = "label2";
            // 
            // lblNewValue
            // 
            this.lblNewValue.AutoSize = true;
            this.lblNewValue.Font = new System.Drawing.Font("Reserva Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.lblNewValue.Location = new System.Drawing.Point(654, 182);
            this.lblNewValue.Name = "lblNewValue";
            this.lblNewValue.Size = new System.Drawing.Size(84, 21);
            this.lblNewValue.TabIndex = 50;
            this.lblNewValue.Text = "R$ 179,00";
            // 
            // lblSubscript
            // 
            this.lblSubscript.AutoSize = true;
            this.lblSubscript.Font = new System.Drawing.Font("Reserva Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscript.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubscript.Location = new System.Drawing.Point(564, 182);
            this.lblSubscript.Name = "lblSubscript";
            this.lblSubscript.Size = new System.Drawing.Size(84, 21);
            this.lblSubscript.TabIndex = 49;
            this.lblSubscript.Text = "R$ 299,00";
            // 
            // lblParcels
            // 
            this.lblParcels.AutoSize = true;
            this.lblParcels.Font = new System.Drawing.Font("Reserva Serif Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcels.Location = new System.Drawing.Point(456, 182);
            this.lblParcels.Name = "lblParcels";
            this.lblParcels.Size = new System.Drawing.Size(102, 21);
            this.lblParcels.TabIndex = 48;
            this.lblParcels.Text = "2x R$ 89,50";
            // 
            // addToBag
            // 
            this.addToBag.CheckedState.Parent = this.addToBag;
            this.addToBag.CustomImages.Parent = this.addToBag;
            this.addToBag.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addToBag.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addToBag.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addToBag.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addToBag.DisabledState.Parent = this.addToBag;
            this.addToBag.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(142)))), ((int)(((byte)(91)))));
            this.addToBag.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToBag.ForeColor = System.Drawing.Color.White;
            this.addToBag.HoverState.Parent = this.addToBag;
            this.addToBag.Location = new System.Drawing.Point(460, 233);
            this.addToBag.Name = "addToBag";
            this.addToBag.ShadowDecoration.Parent = this.addToBag;
            this.addToBag.Size = new System.Drawing.Size(287, 45);
            this.addToBag.TabIndex = 52;
            this.addToBag.Text = "COMPRAR AGORA";
            this.addToBag.Click += new System.EventHandler(this.addToBag_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Location = new System.Drawing.Point(2, -3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.ShadowDecoration.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(74, 54);
            this.guna2ImageButton1.TabIndex = 53;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 607);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.addToBag);
            this.Controls.Add(this.lblNewValue);
            this.Controls.Add(this.lblSubscript);
            this.Controls.Add(this.lblParcels);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chipImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chipPanel);
            this.Controls.Add(this.productImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chipPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox productImage;
        private System.Windows.Forms.Label chipImage;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox chipPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNewValue;
        private System.Windows.Forms.Label lblSubscript;
        private System.Windows.Forms.Label lblParcels;
        private Guna.UI2.WinForms.Guna2Button addToBag;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}