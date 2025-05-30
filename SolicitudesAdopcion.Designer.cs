namespace Fundacion_Animales
{
    partial class SolicitudesAdopcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudesAdopcion));
            panel1 = new Panel();
            btnRegresar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnReporte = new Button();
            dgvSolicitudes = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnReporte);
            panel1.Controls.Add(dgvSolicitudes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 494);
            panel1.TabIndex = 0;
            panel1.Resize += panel1_Resize;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(572, 414);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(140, 47);
            btnRegresar.TabIndex = 4;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(418, 414);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 47);
            btnEliminar.TabIndex = 3;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackgroundImage = (Image)resources.GetObject("btnActualizar.BackgroundImage");
            btnActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Location = new Point(267, 414);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 47);
            btnActualizar.TabIndex = 2;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnReporte
            // 
            btnReporte.BackgroundImage = (Image)resources.GetObject("btnReporte.BackgroundImage");
            btnReporte.BackgroundImageLayout = ImageLayout.Stretch;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Location = new Point(114, 414);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(140, 47);
            btnReporte.TabIndex = 1;
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Location = new Point(46, 95);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.Size = new Size(722, 303);
            dgvSolicitudes.TabIndex = 0;
            dgvSolicitudes.CellEndEdit += dgvSolicitudes_CellEndEdit;
            // 
            // SolicitudesAdopcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(814, 494);
            Controls.Add(panel1);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SolicitudesAdopcion";
            Text = "InicioForm";
            Load += InicioForm_Load;
            Resize += SolicitudesAdopcion_Resize;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnReporte;
        private DataGridView dgvSolicitudes;
        private Button btnRegresar;
        private Button btnEliminar;
        private Button btnActualizar;
    }
}