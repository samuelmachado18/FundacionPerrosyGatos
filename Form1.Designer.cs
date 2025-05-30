namespace Fundacion_Animales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnSolicitud = new Button();
            btnSalir = new Button();
            lblTitulo = new Label();
            menuContainer = new FlowLayoutPanel();
            pnAdoptar = new Panel();
            btnMenu = new Button();
            panel6 = new Panel();
            btnPerro = new Button();
            panel7 = new Panel();
            btnGato = new Button();
            pnConocenos = new Panel();
            button1 = new Button();
            pnContactanos = new Panel();
            button4 = new Button();
            flpAgregar = new FlowLayoutPanel();
            panel3 = new Panel();
            btnAgregar = new Button();
            panel8 = new Panel();
            btnAgregarMascota = new Button();
            panel2 = new Panel();
            btnAdministradores = new Button();
            pnInicio = new Panel();
            btnSolicitudes = new Button();
            panel4 = new Panel();
            panelContenedor2 = new FlowLayoutPanel();
            panel5 = new Panel();
            button2 = new Button();
            panel10 = new Panel();
            btnSegumientosMascotas = new Button();
            ptnimagen = new PictureBox();
            mainPanel = new Panel();
            menuTransition = new System.Windows.Forms.Timer(components);
            menuTransition2 = new System.Windows.Forms.Timer(components);
            menuTransition3 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            menuContainer.SuspendLayout();
            pnAdoptar.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            pnConocenos.SuspendLayout();
            pnContactanos.SuspendLayout();
            flpAgregar.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            pnInicio.SuspendLayout();
            panel4.SuspendLayout();
            panelContenedor2.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptnimagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnSolicitud);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 39);
            panel1.TabIndex = 0;
            // 
            // btnSolicitud
            // 
            btnSolicitud.BackgroundImage = (Image)resources.GetObject("btnSolicitud.BackgroundImage");
            btnSolicitud.BackgroundImageLayout = ImageLayout.Stretch;
            btnSolicitud.FlatAppearance.BorderSize = 0;
            btnSolicitud.FlatStyle = FlatStyle.Flat;
            btnSolicitud.Location = new Point(156, 1);
            btnSolicitud.Name = "btnSolicitud";
            btnSolicitud.Size = new Size(45, 35);
            btnSolicitud.TabIndex = 0;
            btnSolicitud.UseVisualStyleBackColor = true;
            btnSolicitud.Click += btnSolicitud_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(1088, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(45, 37);
            btnSalir.TabIndex = 3;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(12, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(115, 27);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "ENGINEERS";
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(224, 224, 224);
            menuContainer.Controls.Add(pnAdoptar);
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel7);
            menuContainer.Location = new Point(1, 131);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(200, 53);
            menuContainer.TabIndex = 6;
            // 
            // pnAdoptar
            // 
            pnAdoptar.Controls.Add(btnMenu);
            pnAdoptar.Location = new Point(0, 0);
            pnAdoptar.Margin = new Padding(0);
            pnAdoptar.Name = "pnAdoptar";
            pnAdoptar.Size = new Size(207, 54);
            pnAdoptar.TabIndex = 7;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(224, 224, 224);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(-25, -9);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(30, 0, 0, 0);
            btnMenu.Size = new Size(238, 67);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Adoptar";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnPerro);
            panel6.Location = new Point(0, 54);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(204, 54);
            panel6.TabIndex = 8;
            // 
            // btnPerro
            // 
            btnPerro.BackColor = Color.FromArgb(224, 224, 224);
            btnPerro.ForeColor = Color.Black;
            btnPerro.Image = (Image)resources.GetObject("btnPerro.Image");
            btnPerro.ImageAlign = ContentAlignment.MiddleLeft;
            btnPerro.Location = new Point(-25, -11);
            btnPerro.Margin = new Padding(0);
            btnPerro.Name = "btnPerro";
            btnPerro.Padding = new Padding(30, 0, 0, 0);
            btnPerro.Size = new Size(238, 76);
            btnPerro.TabIndex = 2;
            btnPerro.Text = "PERROS";
            btnPerro.UseVisualStyleBackColor = false;
            btnPerro.Click += btnPerro_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnGato);
            panel7.Location = new Point(0, 108);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(204, 54);
            panel7.TabIndex = 9;
            // 
            // btnGato
            // 
            btnGato.BackColor = Color.FromArgb(224, 224, 224);
            btnGato.ForeColor = Color.Black;
            btnGato.Image = (Image)resources.GetObject("btnGato.Image");
            btnGato.ImageAlign = ContentAlignment.MiddleLeft;
            btnGato.Location = new Point(-25, -11);
            btnGato.Margin = new Padding(0);
            btnGato.Name = "btnGato";
            btnGato.Padding = new Padding(30, 0, 0, 0);
            btnGato.Size = new Size(238, 78);
            btnGato.TabIndex = 2;
            btnGato.Text = "GATOS";
            btnGato.UseVisualStyleBackColor = false;
            btnGato.Click += button5_Click;
            // 
            // pnConocenos
            // 
            pnConocenos.BackColor = Color.FromArgb(224, 224, 224);
            pnConocenos.Controls.Add(button1);
            pnConocenos.Location = new Point(2, 178);
            pnConocenos.Name = "pnConocenos";
            pnConocenos.Size = new Size(200, 54);
            pnConocenos.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-25, -7);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(238, 70);
            button1.TabIndex = 2;
            button1.Text = "      Seguimiento de tu mascota";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnContactanos
            // 
            pnContactanos.BackColor = Color.FromArgb(224, 224, 224);
            pnContactanos.Controls.Add(button4);
            pnContactanos.Location = new Point(2, 234);
            pnContactanos.Name = "pnContactanos";
            pnContactanos.Size = new Size(200, 54);
            pnContactanos.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button4.ForeColor = Color.Black;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-25, -13);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(238, 76);
            button4.TabIndex = 2;
            button4.Text = "Contáctanos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // flpAgregar
            // 
            flpAgregar.BackColor = Color.FromArgb(224, 224, 224);
            flpAgregar.Controls.Add(panel3);
            flpAgregar.Controls.Add(panel8);
            flpAgregar.Controls.Add(panel2);
            flpAgregar.Location = new Point(0, 336);
            flpAgregar.Name = "flpAgregar";
            flpAgregar.Size = new Size(200, 48);
            flpAgregar.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAgregar);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 54);
            panel3.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(224, 224, 224);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(-25, -9);
            btnAgregar.Margin = new Padding(0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(30, 0, 0, 0);
            btnAgregar.Size = new Size(238, 67);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnAgregarMascota);
            panel8.Location = new Point(0, 54);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(204, 54);
            panel8.TabIndex = 8;
            // 
            // btnAgregarMascota
            // 
            btnAgregarMascota.BackColor = Color.FromArgb(224, 224, 224);
            btnAgregarMascota.ForeColor = Color.Black;
            btnAgregarMascota.Image = (Image)resources.GetObject("btnAgregarMascota.Image");
            btnAgregarMascota.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarMascota.Location = new Point(-25, -9);
            btnAgregarMascota.Margin = new Padding(0);
            btnAgregarMascota.Name = "btnAgregarMascota";
            btnAgregarMascota.Padding = new Padding(30, 0, 0, 0);
            btnAgregarMascota.Size = new Size(238, 67);
            btnAgregarMascota.TabIndex = 2;
            btnAgregarMascota.Text = "Agregar Mascota";
            btnAgregarMascota.UseVisualStyleBackColor = false;
            btnAgregarMascota.Click += btnAgregarMascota_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAdministradores);
            panel2.Location = new Point(0, 108);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 47);
            panel2.TabIndex = 9;
            // 
            // btnAdministradores
            // 
            btnAdministradores.BackColor = Color.FromArgb(224, 224, 224);
            btnAdministradores.ForeColor = Color.Black;
            btnAdministradores.Image = (Image)resources.GetObject("btnAdministradores.Image");
            btnAdministradores.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdministradores.Location = new Point(-25, -13);
            btnAdministradores.Margin = new Padding(0);
            btnAdministradores.Name = "btnAdministradores";
            btnAdministradores.Padding = new Padding(30, 0, 0, 0);
            btnAdministradores.Size = new Size(238, 76);
            btnAdministradores.TabIndex = 2;
            btnAdministradores.Text = "  Agregar Administrador";
            btnAdministradores.UseVisualStyleBackColor = false;
            btnAdministradores.Click += btnAdministradores_Click;
            // 
            // pnInicio
            // 
            pnInicio.BackColor = Color.FromArgb(224, 224, 224);
            pnInicio.Controls.Add(btnSolicitudes);
            pnInicio.Location = new Point(3, 104);
            pnInicio.Name = "pnInicio";
            pnInicio.Size = new Size(200, 53);
            pnInicio.TabIndex = 7;
            // 
            // btnSolicitudes
            // 
            btnSolicitudes.BackColor = Color.FromArgb(224, 224, 224);
            btnSolicitudes.ForeColor = Color.Black;
            btnSolicitudes.Image = (Image)resources.GetObject("btnSolicitudes.Image");
            btnSolicitudes.ImageAlign = ContentAlignment.MiddleLeft;
            btnSolicitudes.Location = new Point(-28, -10);
            btnSolicitudes.Margin = new Padding(0);
            btnSolicitudes.Name = "btnSolicitudes";
            btnSolicitudes.Padding = new Padding(30, 0, 0, 0);
            btnSolicitudes.Size = new Size(238, 76);
            btnSolicitudes.TabIndex = 2;
            btnSolicitudes.Text = "Solicitudes";
            btnSolicitudes.UseVisualStyleBackColor = false;
            btnSolicitudes.Click += btnInicio_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(panelContenedor2);
            panel4.Controls.Add(flpAgregar);
            panel4.Controls.Add(menuContainer);
            panel4.Controls.Add(ptnimagen);
            panel4.Controls.Add(pnConocenos);
            panel4.Controls.Add(pnContactanos);
            panel4.Dock = DockStyle.Left;
            panel4.ForeColor = Color.Silver;
            panel4.Location = new Point(0, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 494);
            panel4.TabIndex = 11;
            // 
            // panelContenedor2
            // 
            panelContenedor2.BackColor = Color.FromArgb(224, 224, 224);
            panelContenedor2.Controls.Add(panel5);
            panelContenedor2.Controls.Add(panel10);
            panelContenedor2.Controls.Add(pnInicio);
            panelContenedor2.Location = new Point(0, 283);
            panelContenedor2.Name = "panelContenedor2";
            panelContenedor2.Size = new Size(200, 50);
            panelContenedor2.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(207, 54);
            panel5.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-25, -9);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(238, 67);
            button2.TabIndex = 2;
            button2.Text = "         Solicitudes y Seguimientos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnSegumientosMascotas);
            panel10.Location = new Point(0, 54);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(204, 47);
            panel10.TabIndex = 9;
            // 
            // btnSegumientosMascotas
            // 
            btnSegumientosMascotas.BackColor = Color.FromArgb(224, 224, 224);
            btnSegumientosMascotas.ForeColor = Color.Black;
            btnSegumientosMascotas.Image = (Image)resources.GetObject("btnSegumientosMascotas.Image");
            btnSegumientosMascotas.ImageAlign = ContentAlignment.MiddleLeft;
            btnSegumientosMascotas.Location = new Point(-25, -13);
            btnSegumientosMascotas.Margin = new Padding(0);
            btnSegumientosMascotas.Name = "btnSegumientosMascotas";
            btnSegumientosMascotas.Padding = new Padding(30, 0, 0, 0);
            btnSegumientosMascotas.Size = new Size(238, 76);
            btnSegumientosMascotas.TabIndex = 2;
            btnSegumientosMascotas.Text = "         Seguimiento de mascotas";
            btnSegumientosMascotas.UseVisualStyleBackColor = false;
            btnSegumientosMascotas.Click += btnSegumientosMascotas_Click;
            // 
            // ptnimagen
            // 
            ptnimagen.BackColor = Color.White;
            ptnimagen.Location = new Point(28, 11);
            ptnimagen.Name = "ptnimagen";
            ptnimagen.Size = new Size(136, 108);
            ptnimagen.SizeMode = PictureBoxSizeMode.StretchImage;
            ptnimagen.TabIndex = 12;
            ptnimagen.TabStop = false;
            ptnimagen.Click += ptnimagen_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.BackgroundImageLayout = ImageLayout.Stretch;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 39);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(936, 494);
            mainPanel.TabIndex = 13;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // menuTransition2
            // 
            menuTransition2.Interval = 10;
            menuTransition2.Tick += menuTransition2_Tick;
            // 
            // menuTransition3
            // 
            menuTransition3.Interval = 10;
            menuTransition3.Tick += menuTransition3_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 533);
            Controls.Add(mainPanel);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuContainer.ResumeLayout(false);
            pnAdoptar.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            pnConocenos.ResumeLayout(false);
            pnContactanos.ResumeLayout(false);
            flpAgregar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnInicio.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panelContenedor2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptnimagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Button button1;
        private Panel pnConocenos;
        private Button btnMenu;
        private FlowLayoutPanel menuContainer;
        private Panel pnAdoptar;
        private Panel panel6;
        private Button btnPerro;
        private Panel panel7;
        private Button btnGato;
        private Panel pnInicio;
        private Button btnSolicitudes;
        private Panel pnContactanos;
        private Button button4;
        private FlowLayoutPanel flpAgregar;
        private Panel panel3;
        private Button btnAgregar;
        private Panel panel8;
        private Button btnAgregarMascota;
        private Button btnSolicitud;
        private Button btnSalir;
        private Panel panel2;
        private Button btnAdministradores;
        private Panel panel4;
        private PictureBox ptnimagen;
        private Panel mainPanel;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer menuTransition2;
        private FlowLayoutPanel panelContenedor2;
        private Panel panel5;
        private Button button2;
        private Panel panel10;
        private Button btnSegumientosMascotas;
        private System.Windows.Forms.Timer menuTransition3;
    }
}
