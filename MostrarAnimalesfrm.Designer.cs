namespace Fundacion_Animales
{
    partial class MostrarAnimalesfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarAnimalesfrm));
            btnRegresar = new Button();
            ptbImagen = new PictureBox();
            txtFechaNacimiento = new TextBox();
            txtNombre = new TextBox();
            txtEspecie = new TextBox();
            txtRaza = new TextBox();
            txtSexo = new TextBox();
            txtEstado = new TextBox();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ptbImagen).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(-1, 0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(55, 49);
            btnRegresar.TabIndex = 0;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // ptbImagen
            // 
            ptbImagen.Location = new Point(380, 38);
            ptbImagen.Name = "ptbImagen";
            ptbImagen.Size = new Size(227, 175);
            ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbImagen.TabIndex = 2;
            ptbImagen.TabStop = false;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(256, 398);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(479, 23);
            txtFechaNacimiento.TabIndex = 3;
            txtFechaNacimiento.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(256, 298);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(479, 23);
            txtNombre.TabIndex = 4;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(256, 323);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(479, 23);
            txtEspecie.TabIndex = 5;
            txtEspecie.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(256, 348);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(479, 23);
            txtRaza.TabIndex = 6;
            txtRaza.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(256, 373);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(479, 23);
            txtSexo.TabIndex = 7;
            txtSexo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(256, 423);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(479, 23);
            txtEstado.TabIndex = 8;
            txtEstado.TextAlign = HorizontalAlignment.Center;
            // 
            // txtID
            // 
            txtID.Location = new Point(256, 274);
            txtID.Name = "txtID";
            txtID.Size = new Size(479, 23);
            txtID.TabIndex = 9;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // MostrarAnimalesfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(935, 494);
            Controls.Add(txtID);
            Controls.Add(txtEstado);
            Controls.Add(txtSexo);
            Controls.Add(txtRaza);
            Controls.Add(txtEspecie);
            Controls.Add(txtNombre);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(ptbImagen);
            Controls.Add(btnRegresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MostrarAnimalesfrm";
            Text = "MostrarAnimalesfrm";
            Load += MostrarAnimalesfrm_Load;
            ((System.ComponentModel.ISupportInitialize)ptbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private PictureBox ptbImagen;
        private TextBox txtFechaNacimiento;
        private TextBox txtNombre;
        private TextBox txtEspecie;
        private TextBox txtRaza;
        private TextBox txtSexo;
        private TextBox txtEstado;
        private TextBox txtID;
    }
}