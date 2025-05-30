namespace Fundacion_Animales
{
    partial class seguimientoAdminfrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seguimientoAdminfrom));
            panel1 = new Panel();
            ptnImagen = new PictureBox();
            dgvSeguimiento = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptnImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSeguimiento).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(ptnImagen);
            panel1.Controls.Add(dgvSeguimiento);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 494);
            panel1.TabIndex = 0;
            // 
            // ptnImagen
            // 
            ptnImagen.Location = new Point(715, 3);
            ptnImagen.Name = "ptnImagen";
            ptnImagen.Size = new Size(124, 108);
            ptnImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            ptnImagen.TabIndex = 4;
            ptnImagen.TabStop = false;
            // 
            // dgvSeguimiento
            // 
            dgvSeguimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeguimiento.Location = new Point(53, 143);
            dgvSeguimiento.Name = "dgvSeguimiento";
            dgvSeguimiento.ReadOnly = true;
            dgvSeguimiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSeguimiento.Size = new Size(604, 236);
            dgvSeguimiento.TabIndex = 3;
            dgvSeguimiento.CellClick += dgvSeguimiento_CellClick;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(677, 286);
            button3.Name = "button3";
            button3.Size = new Size(209, 46);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(677, 238);
            button2.Name = "button2";
            button2.Size = new Size(209, 46);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(677, 190);
            button1.Name = "button1";
            button1.Size = new Size(209, 46);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // seguimientoAdminfrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 494);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "seguimientoAdminfrom";
            Text = "seguimientoAdminfrom";
            Load += seguimientoAdminfrom_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptnImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSeguimiento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox ptnImagen;
        private DataGridView dgvSeguimiento;
    }
}