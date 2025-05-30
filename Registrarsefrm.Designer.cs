namespace Fundacion_Animales
{
    partial class Registrarsefrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrarsefrm));
            panel1 = new Panel();
            ptnImagen = new PictureBox();
            label7 = new Label();
            txtNombreCompl = new TextBox();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            btnRegistro = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ptnImagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(195, 181, 194);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 252);
            panel1.TabIndex = 0;
            // 
            // ptnImagen
            // 
            ptnImagen.BackColor = Color.DimGray;
            ptnImagen.Location = new Point(593, 35);
            ptnImagen.Name = "ptnImagen";
            ptnImagen.Size = new Size(110, 97);
            ptnImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            ptnImagen.TabIndex = 13;
            ptnImagen.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DimGray;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(620, 153);
            label7.Name = "label7";
            label7.Size = new Size(55, 22);
            label7.TabIndex = 14;
            label7.Text = "Foto:";
            label7.Click += label7_Click;
            // 
            // txtNombreCompl
            // 
            txtNombreCompl.BackColor = Color.Black;
            txtNombreCompl.BorderStyle = BorderStyle.None;
            txtNombreCompl.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCompl.ForeColor = Color.DimGray;
            txtNombreCompl.Location = new Point(212, 27);
            txtNombreCompl.Name = "txtNombreCompl";
            txtNombreCompl.Size = new Size(321, 20);
            txtNombreCompl.TabIndex = 16;
            txtNombreCompl.Text = "Nombre Completo";
            txtNombreCompl.TextAlign = HorizontalAlignment.Center;
            txtNombreCompl.TextChanged += txtPass_TextChanged;
            txtNombreCompl.Enter += txtNombreCompl_Enter;
            txtNombreCompl.Leave += txtNombreCompl_Leave;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.Black;
            txtNombreUsuario.BorderStyle = BorderStyle.None;
            txtNombreUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.ForeColor = Color.DimGray;
            txtNombreUsuario.Location = new Point(212, 53);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(321, 20);
            txtNombreUsuario.TabIndex = 17;
            txtNombreUsuario.Text = "Nombre Usuario";
            txtNombreUsuario.TextAlign = HorizontalAlignment.Center;
            txtNombreUsuario.TextChanged += textBox1_TextChanged;
            txtNombreUsuario.Enter += txtNombreUsuario_Enter;
            txtNombreUsuario.Leave += txtNombreUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.Black;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(212, 79);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(321, 20);
            txtContraseña.TabIndex = 18;
            txtContraseña.Text = "Contraseña";
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            txtContraseña.TextChanged += textBox2_TextChanged;
            txtContraseña.Enter += txtContraseña_Enter_1;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.Black;
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.DimGray;
            txtCorreo.Location = new Point(212, 105);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(321, 20);
            txtCorreo.TabIndex = 19;
            txtCorreo.Text = "Correo";
            txtCorreo.TextAlign = HorizontalAlignment.Center;
            txtCorreo.Enter += txtCorreo_Enter;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.Black;
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.ForeColor = Color.DimGray;
            txtDireccion.Location = new Point(212, 129);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(321, 20);
            txtDireccion.TabIndex = 20;
            txtDireccion.Text = "Dirección";
            txtDireccion.TextAlign = HorizontalAlignment.Center;
            txtDireccion.Enter += txtDireccion_Enter;
            txtDireccion.Leave += txtDireccion_Leave;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Black;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.ForeColor = Color.DimGray;
            txtTelefono.Location = new Point(212, 155);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(321, 20);
            txtTelefono.TabIndex = 21;
            txtTelefono.Text = "Telefono";
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(40, 40, 40);
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28, 28);
            btnRegistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64, 64);
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.ForeColor = Color.LightGray;
            btnRegistro.Location = new Point(262, 191);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(175, 37);
            btnRegistro.TabIndex = 22;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(500, 191);
            button1.Name = "button1";
            button1.Size = new Size(175, 37);
            button1.TabIndex = 23;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Registrarsefrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(748, 252);
            Controls.Add(button1);
            Controls.Add(btnRegistro);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtNombreCompl);
            Controls.Add(label7);
            Controls.Add(ptnImagen);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registrarsefrm";
            Text = "Registrarsefrm";
            Load += Registrarsefrm_Load;
            ((System.ComponentModel.ISupportInitialize)ptnImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox ptnImagen;
        private Label label7;
        private TextBox txtNombreCompl;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Button btnRegistro;
        private Button button1;
    }
}