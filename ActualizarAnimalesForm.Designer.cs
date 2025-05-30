namespace Fundacion_Animales
{
    partial class ActualizarAnimalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarAnimalesForm));
            panel1 = new Panel();
            btnFoto = new Button();
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaIngreso = new DateTimePicker();
            btnRegresar = new Button();
            btnActualizar = new Button();
            ptbImagen = new PictureBox();
            cboEstado = new ComboBox();
            cboSexo = new ComboBox();
            txtRaza = new TextBox();
            txtNombre = new TextBox();
            textBox1 = new TextBox();
            cboEspecie = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbImagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnFoto);
            panel1.Controls.Add(dtpFechaNacimiento);
            panel1.Controls.Add(dtpFechaIngreso);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(ptbImagen);
            panel1.Controls.Add(cboEspecie);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(cboSexo);
            panel1.Controls.Add(txtRaza);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 494);
            panel1.TabIndex = 0;
            // 
            // btnFoto
            // 
            btnFoto.BackgroundImage = (Image)resources.GetObject("btnFoto.BackgroundImage");
            btnFoto.BackgroundImageLayout = ImageLayout.Stretch;
            btnFoto.FlatAppearance.BorderSize = 0;
            btnFoto.FlatStyle = FlatStyle.Flat;
            btnFoto.Location = new Point(776, 309);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(68, 27);
            btnFoto.TabIndex = 39;
            btnFoto.UseMnemonic = false;
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(296, 331);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(197, 23);
            dtpFechaNacimiento.TabIndex = 38;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(296, 379);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(197, 23);
            dtpFechaIngreso.TabIndex = 37;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(3, 3);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(79, 70);
            btnRegresar.TabIndex = 36;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackgroundImage = (Image)resources.GetObject("btnActualizar.BackgroundImage");
            btnActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Location = new Point(710, 396);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(177, 53);
            btnActualizar.TabIndex = 35;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // ptbImagen
            // 
            ptbImagen.Location = new Point(727, 142);
            ptbImagen.Name = "ptbImagen";
            ptbImagen.Size = new Size(145, 131);
            ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbImagen.TabIndex = 34;
            ptbImagen.TabStop = false;
            // 
            // cboEstado
            // 
            cboEstado.BackColor = Color.FromArgb(223, 181, 116);
            cboEstado.FlatStyle = FlatStyle.Flat;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(296, 426);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(197, 23);
            cboEstado.TabIndex = 32;
            // 
            // cboSexo
            // 
            cboSexo.BackColor = Color.FromArgb(223, 181, 116);
            cboSexo.FlatStyle = FlatStyle.Flat;
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(296, 283);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(197, 23);
            cboSexo.TabIndex = 31;
            // 
            // txtRaza
            // 
            txtRaza.BackColor = Color.FromArgb(223, 181, 116);
            txtRaza.BorderStyle = BorderStyle.None;
            txtRaza.Location = new Point(296, 234);
            txtRaza.Multiline = true;
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(197, 26);
            txtRaza.TabIndex = 30;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(223, 181, 116);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(307, 142);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 26);
            txtNombre.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(223, 181, 116);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(307, 142);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 26);
            textBox1.TabIndex = 28;
            // 
            // cboEspecie
            // 
            cboEspecie.BackColor = Color.FromArgb(223, 181, 116);
            cboEspecie.FlatStyle = FlatStyle.Flat;
            cboEspecie.FormattingEnabled = true;
            cboEspecie.Location = new Point(296, 191);
            cboEspecie.Name = "cboEspecie";
            cboEspecie.Size = new Size(197, 23);
            cboEspecie.TabIndex = 33;
            // 
            // ActualizarAnimalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 494);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActualizarAnimalesForm";
            Text = "ActualizarAnimalesForm";
            Load += ActualizarAnimalesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnFoto;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaIngreso;
        private Button btnRegresar;
        private Button btnActualizar;
        private PictureBox ptbImagen;
        private ComboBox cboEstado;
        private ComboBox cboSexo;
        private TextBox txtRaza;
        private TextBox txtNombre;
        private TextBox textBox1;
        private ComboBox cboEspecie;
    }
}