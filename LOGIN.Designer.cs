namespace Fundacion_Animales
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            panelContenedor = new Panel();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Black;
            panelContenedor.Controls.Add(button1);
            panelContenedor.Controls.Add(linkLabel1);
            panelContenedor.Controls.Add(panel2);
            panelContenedor.Dock = DockStyle.Left;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(763, 291);
            panelContenedor.TabIndex = 0;
            panelContenedor.MouseDown += panel1_MouseDown;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(682, 0);
            button1.Name = "button1";
            button1.Size = new Size(81, 25);
            button1.TabIndex = 4;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.RoyalBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(465, 265);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(69, 17);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrase";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(195, 181, 194);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 291);
            panel2.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Black;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(318, 48);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(333, 24);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.Black;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.ForeColor = Color.DimGray;
            txtPass.Location = new Point(318, 109);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(333, 24);
            txtPass.TabIndex = 2;
            txtPass.Text = "CONTRASEÑA";
            txtPass.TextChanged += txtPass_TextChanged;
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(484, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28, 28);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.LightGray;
            btnLogin.Location = new Point(318, 212);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(354, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "ACCEDER";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(764, 291);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LOGIN";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            MouseDown += LOGIN_MouseDown;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelContenedor;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Label label1;
        private Button btnLogin;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private Button button1;
    }
}