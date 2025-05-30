namespace Fundacion_Animales
{
    partial class Administradoresform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administradoresform));
            dgvAdministradores = new DataGridView();
            btnActualiar = new Button();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnReporte = new Button();
            btnRegresar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAdministradores).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAdministradores
            // 
            dgvAdministradores.AllowUserToAddRows = false;
            dgvAdministradores.AllowUserToDeleteRows = false;
            dgvAdministradores.Anchor = AnchorStyles.None;
            dgvAdministradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdministradores.Location = new Point(52, 96);
            dgvAdministradores.MultiSelect = false;
            dgvAdministradores.Name = "dgvAdministradores";
            dgvAdministradores.ReadOnly = true;
            dgvAdministradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdministradores.Size = new Size(833, 303);
            dgvAdministradores.TabIndex = 17;
            // 
            // btnActualiar
            // 
            btnActualiar.BackgroundImage = (Image)resources.GetObject("btnActualiar.BackgroundImage");
            btnActualiar.BackgroundImageLayout = ImageLayout.Stretch;
            btnActualiar.FlatAppearance.BorderSize = 0;
            btnActualiar.FlatStyle = FlatStyle.Flat;
            btnActualiar.Location = new Point(308, 415);
            btnActualiar.Name = "btnActualiar";
            btnActualiar.Size = new Size(160, 50);
            btnActualiar.TabIndex = 18;
            btnActualiar.UseVisualStyleBackColor = true;
            btnActualiar.Click += btnActualiar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(133, 415);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(160, 50);
            btnNuevo.TabIndex = 19;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(474, 415);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(169, 50);
            btnEliminar.TabIndex = 20;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnReporte
            // 
            btnReporte.BackgroundImage = (Image)resources.GetObject("btnReporte.BackgroundImage");
            btnReporte.BackgroundImageLayout = ImageLayout.Stretch;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Location = new Point(649, 415);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(170, 50);
            btnReporte.TabIndex = 21;
            btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(3, 3);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(72, 63);
            btnRegresar.TabIndex = 22;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click_1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnReporte);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(dgvAdministradores);
            panel1.Controls.Add(btnActualiar);
            panel1.Controls.Add(btnNuevo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 494);
            panel1.TabIndex = 23;
            // 
            // Administradoresform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 494);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Administradoresform";
            Text = "Administradoresform";
            Load += Administradoresform_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdministradores).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAdministradores;
        private Button btnActualiar;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnReporte;
        private Button btnRegresar;
        private Panel panel1;
    }
}