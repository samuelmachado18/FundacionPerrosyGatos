namespace Fundacion_Animales
{
    partial class insertAnimalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertAnimalForm));
            panel1 = new Panel();
            cboPelaje = new ComboBox();
            cboCaracteristicas = new ComboBox();
            cboTamaño = new ComboBox();
            cboPersonalidad = new ComboBox();
            btnFoto = new Button();
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaIngreso = new DateTimePicker();
            btnRegresar = new Button();
            btnRegistrar = new Button();
            ptbImagen = new PictureBox();
            cboEspecie = new ComboBox();
            cboSexo = new ComboBox();
            txtRaza = new TextBox();
            txtNombre = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbImagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(cboPelaje);
            panel1.Controls.Add(cboCaracteristicas);
            panel1.Controls.Add(cboTamaño);
            panel1.Controls.Add(cboPersonalidad);
            panel1.Controls.Add(btnFoto);
            panel1.Controls.Add(dtpFechaNacimiento);
            panel1.Controls.Add(dtpFechaIngreso);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(ptbImagen);
            panel1.Controls.Add(cboEspecie);
            panel1.Controls.Add(cboSexo);
            panel1.Controls.Add(txtRaza);
            panel1.Controls.Add(txtNombre);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 494);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // cboPelaje
            // 
            cboPelaje.BackColor = Color.FromArgb(223, 181, 116);
            cboPelaje.FlatStyle = FlatStyle.Flat;
            cboPelaje.FormattingEnabled = true;
            cboPelaje.Location = new Point(237, 445);
            cboPelaje.Name = "cboPelaje";
            cboPelaje.Size = new Size(153, 23);
            cboPelaje.TabIndex = 30;
            // 
            // cboCaracteristicas
            // 
            cboCaracteristicas.BackColor = Color.FromArgb(223, 181, 116);
            cboCaracteristicas.FlatStyle = FlatStyle.Flat;
            cboCaracteristicas.FormattingEnabled = true;
            cboCaracteristicas.Location = new Point(237, 409);
            cboCaracteristicas.Name = "cboCaracteristicas";
            cboCaracteristicas.Size = new Size(153, 23);
            cboCaracteristicas.TabIndex = 29;
            // 
            // cboTamaño
            // 
            cboTamaño.BackColor = Color.FromArgb(223, 181, 116);
            cboTamaño.FlatStyle = FlatStyle.Flat;
            cboTamaño.FormattingEnabled = true;
            cboTamaño.Location = new Point(237, 375);
            cboTamaño.Name = "cboTamaño";
            cboTamaño.Size = new Size(153, 23);
            cboTamaño.TabIndex = 28;
            // 
            // cboPersonalidad
            // 
            cboPersonalidad.BackColor = Color.FromArgb(223, 181, 116);
            cboPersonalidad.FlatStyle = FlatStyle.Flat;
            cboPersonalidad.FormattingEnabled = true;
            cboPersonalidad.Location = new Point(237, 344);
            cboPersonalidad.Name = "cboPersonalidad";
            cboPersonalidad.Size = new Size(153, 23);
            cboPersonalidad.TabIndex = 27;
            // 
            // btnFoto
            // 
            btnFoto.BackgroundImage = (Image)resources.GetObject("btnFoto.BackgroundImage");
            btnFoto.BackgroundImageLayout = ImageLayout.Stretch;
            btnFoto.FlatAppearance.BorderSize = 0;
            btnFoto.FlatStyle = FlatStyle.Flat;
            btnFoto.Location = new Point(774, 293);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(70, 29);
            btnFoto.TabIndex = 26;
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(237, 275);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(153, 23);
            dtpFechaNacimiento.TabIndex = 25;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(237, 309);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(153, 23);
            dtpFechaIngreso.TabIndex = 24;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(3, 5);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(85, 75);
            btnRegresar.TabIndex = 23;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click_1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackgroundImage = (Image)resources.GetObject("btnRegistrar.BackgroundImage");
            btnRegistrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(708, 391);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(176, 57);
            btnRegistrar.TabIndex = 22;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // ptbImagen
            // 
            ptbImagen.Location = new Point(730, 126);
            ptbImagen.Name = "ptbImagen";
            ptbImagen.Size = new Size(141, 138);
            ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbImagen.TabIndex = 21;
            ptbImagen.TabStop = false;
            // 
            // cboEspecie
            // 
            cboEspecie.BackColor = Color.FromArgb(223, 181, 116);
            cboEspecie.FlatStyle = FlatStyle.Flat;
            cboEspecie.FormattingEnabled = true;
            cboEspecie.Location = new Point(237, 171);
            cboEspecie.Name = "cboEspecie";
            cboEspecie.Size = new Size(153, 23);
            cboEspecie.TabIndex = 20;
            // 
            // cboSexo
            // 
            cboSexo.BackColor = Color.FromArgb(223, 181, 116);
            cboSexo.FlatStyle = FlatStyle.Flat;
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(237, 241);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(153, 23);
            cboSexo.TabIndex = 18;
            // 
            // txtRaza
            // 
            txtRaza.BackColor = Color.FromArgb(223, 181, 116);
            txtRaza.BorderStyle = BorderStyle.None;
            txtRaza.Location = new Point(237, 205);
            txtRaza.Multiline = true;
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(153, 24);
            txtRaza.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(223, 181, 116);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(237, 141);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(153, 21);
            txtNombre.TabIndex = 12;
            // 
            // insertAnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(935, 494);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "insertAnimalForm";
            Text = "insertAnimal";
            Load += insertAnimalForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegresar;
        private Button btnRegistrar;
        private PictureBox ptbImagen;
        private ComboBox cboEspecie;
        private ComboBox cboSexo;
        private TextBox txtRaza;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaIngreso;
        private Button btnFoto;
        private ComboBox cboPelaje;
        private ComboBox cboCaracteristicas;
        private ComboBox cboTamaño;
        private ComboBox cboPersonalidad;
    }
}