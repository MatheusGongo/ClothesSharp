namespace ClothesSharp
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.clientLogin = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(149, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 57);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reserva Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seja bem-vindo";
            // 
            // clientLogin
            // 
            this.clientLogin.BorderThickness = 1;
            this.clientLogin.CheckedState.Parent = this.clientLogin;
            this.clientLogin.CustomImages.Parent = this.clientLogin;
            this.clientLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clientLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clientLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clientLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clientLogin.DisabledState.Parent = this.clientLogin;
            this.clientLogin.FillColor = System.Drawing.Color.White;
            this.clientLogin.Font = new System.Drawing.Font("Reserva Sans", 14.25F);
            this.clientLogin.ForeColor = System.Drawing.Color.Black;
            this.clientLogin.HoverState.Parent = this.clientLogin;
            this.clientLogin.Location = new System.Drawing.Point(57, 314);
            this.clientLogin.Name = "clientLogin";
            this.clientLogin.ShadowDecoration.Parent = this.clientLogin;
            this.clientLogin.Size = new System.Drawing.Size(235, 45);
            this.clientLogin.TabIndex = 3;
            this.clientLogin.Text = "Entrar como Cliente";
            this.clientLogin.Click += new System.EventHandler(this.clientLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 577);
            this.Controls.Add(this.clientLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button clientLogin;
    }
}

