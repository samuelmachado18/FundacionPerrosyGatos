namespace Fundacion_Animales
{
    partial class seguimientoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seguimientoFrm));
            panel1 = new Panel();
            btnNuevo = new Button();
            btnSalir = new Button();
            ptnImage = new PictureBox();
            dgvSeguimiento = new DataGridView();
            txtDescripcion = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptnImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSeguimiento).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(ptnImage);
            panel1.Controls.Add(dgvSeguimiento);
            panel1.Controls.Add(txtDescripcion);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 494);
            panel1.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(257, 419);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(205, 48);
            btnNuevo.TabIndex = 5;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(468, 419);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(210, 48);
            btnSalir.TabIndex = 4;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ptnImage
            // 
            ptnImage.Location = new Point(717, 3);
            ptnImage.Name = "ptnImage";
            ptnImage.Size = new Size(122, 112);
            ptnImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ptnImage.TabIndex = 2;
            ptnImage.TabStop = false;
            // 
            // dgvSeguimiento
            // 
            dgvSeguimiento.AllowUserToAddRows = false;
            dgvSeguimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeguimiento.Location = new Point(52, 131);
            dgvSeguimiento.MultiSelect = false;
            dgvSeguimiento.Name = "dgvSeguimiento";
            dgvSeguimiento.ReadOnly = true;
            dgvSeguimiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSeguimiento.Size = new Size(435, 240);
            dgvSeguimiento.TabIndex = 1;
            dgvSeguimiento.CellClick += dgvSeguimiento_CellClick;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(543, 161);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(305, 210);
            txtDescripcion.TabIndex = 0;
            txtDescripcion.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 13, 71);
            label1.Location = new Point(207, 105);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 7;
            label1.Text = "Elige tu mascota";
            // 
            // seguimientoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 494);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "seguimientoFrm";
            Text = "seguimientoFrm";
            Load += seguimientoFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptnImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSeguimiento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox ptnImage;
        private DataGridView dgvSeguimiento;
        private Button btnNuevo;
        private Button btnSalir;
        private TextBox txtDescripcion;
        private Label label1;
    }
}