namespace Fundacion_Animales
{
    partial class administracion_animalesForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administracion_animalesForm));
            panel1 = new Panel();
            btnNuevo = new Button();
            dgvAdministracionAnimal = new DataGridView();
            btnReporte = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnRegresar = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdministracionAnimal).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(dgvAdministracionAnimal);
            panel1.Controls.Add(btnReporte);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnRegresar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 494);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNuevo.AutoSize = true;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(52, 412);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(197, 51);
            btnNuevo.TabIndex = 7;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // dgvAdministracionAnimal
            // 
            dgvAdministracionAnimal.Anchor = AnchorStyles.None;
            dgvAdministracionAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdministracionAnimal.Location = new Point(52, 147);
            dgvAdministracionAnimal.MultiSelect = false;
            dgvAdministracionAnimal.Name = "dgvAdministracionAnimal";
            dgvAdministracionAnimal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdministracionAnimal.Size = new Size(832, 257);
            dgvAdministracionAnimal.TabIndex = 11;
            // 
            // btnReporte
            // 
            btnReporte.BackgroundImage = (Image)resources.GetObject("btnReporte.BackgroundImage");
            btnReporte.BackgroundImageLayout = ImageLayout.Stretch;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Location = new Point(685, 411);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(199, 52);
            btnReporte.TabIndex = 10;
            btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(472, 410);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(196, 53);
            btnEliminar.TabIndex = 9;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(255, 410);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(198, 53);
            btnEditar.TabIndex = 8;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(3, 3);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(76, 70);
            btnRegresar.TabIndex = 6;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            // 
            // administracion_animalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(935, 494);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "administracion_animalesForm";
            Text = "administracion_animalesForm";
            Load += administracion_animalesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdministracionAnimal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnReporte;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnRegresar;
        private DataGridView dgvAdministracionAnimal;
        private System.Windows.Forms.Timer menuTransition;
        private Button btnNuevo;
    }
}