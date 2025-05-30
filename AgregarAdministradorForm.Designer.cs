namespace Fundacion_Animales
{
    partial class AgregarAdministradorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAdministradorForm));
            panel1 = new Panel();
            txtTelefono = new TextBox();
            txtNombreUsuario = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            btnAgregar = new Button();
            btnFoto = new Button();
            btnRegresar = new Button();
            ptbImagen = new PictureBox();
            txtContraseña = new TextBox();
            textBox3 = new TextBox();
            txtNombre = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbImagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtNombreUsuario);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnFoto);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(ptbImagen);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 494);
            panel1.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(223, 181, 116);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Location = new Point(293, 381);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(201, 31);
            txtTelefono.TabIndex = 58;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.FromArgb(223, 181, 116);
            txtNombreUsuario.BorderStyle = BorderStyle.None;
            txtNombreUsuario.Location = new Point(293, 185);
            txtNombreUsuario.Multiline = true;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(201, 31);
            txtNombreUsuario.TabIndex = 57;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(223, 181, 116);
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Location = new Point(293, 282);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(201, 31);
            txtDireccion.TabIndex = 56;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(223, 181, 116);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Location = new Point(293, 333);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(201, 31);
            txtCorreo.TabIndex = 54;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(711, 393);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(175, 50);
            btnAgregar.TabIndex = 53;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackgroundImage = (Image)resources.GetObject("btnFoto.BackgroundImage");
            btnFoto.BackgroundImageLayout = ImageLayout.Stretch;
            btnFoto.FlatAppearance.BorderSize = 0;
            btnFoto.FlatStyle = FlatStyle.Flat;
            btnFoto.Location = new Point(753, 305);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(95, 35);
            btnFoto.TabIndex = 52;
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(3, 3);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(85, 75);
            btnRegresar.TabIndex = 51;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // ptbImagen
            // 
            ptbImagen.Location = new Point(729, 139);
            ptbImagen.Name = "ptbImagen";
            ptbImagen.Size = new Size(141, 138);
            ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbImagen.TabIndex = 50;
            ptbImagen.TabStop = false;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(223, 181, 116);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Location = new Point(293, 233);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(201, 31);
            txtContraseña.TabIndex = 49;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(223, 181, 116);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(293, 185);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 31);
            textBox3.TabIndex = 48;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(223, 181, 116);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(293, 139);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 31);
            txtNombre.TabIndex = 46;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(223, 181, 116);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(293, 139);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 31);
            textBox1.TabIndex = 47;
            // 
            // AgregarAdministradorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 494);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarAdministradorForm";
            Text = "AgregarAdministradorForm";
            Load += AgregarAdministradorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtTelefono;
        private TextBox txtNombreUsuario;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private Button btnAgregar;
        private Button btnFoto;
        private Button btnRegresar;
        private PictureBox ptbImagen;
        private TextBox txtContraseña;
        private TextBox textBox3;
        private TextBox txtNombre;
        private TextBox textBox1;
    }
}