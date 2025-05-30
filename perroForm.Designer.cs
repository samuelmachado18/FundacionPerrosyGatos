namespace Fundacion_Animales
{
    partial class perroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perroForm));
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            cboPelaje = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            cboCaracteristicas = new ComboBox();
            cboPersonalidad = new ComboBox();
            label2 = new Label();
            cboTamaño = new ComboBox();
            dgvPerros = new DataGridView();
            btnRegresar = new Button();
            btnMostrarInfo = new Button();
            btnAdoptar = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerros).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvPerros);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(btnMostrarInfo);
            panel1.Controls.Add(btnAdoptar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 494);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cboPelaje);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cboCaracteristicas);
            panel2.Controls.Add(cboPersonalidad);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cboTamaño);
            panel2.Location = new Point(44, 95);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 46);
            panel2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(658, 17);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 6;
            label5.Text = "Pelaje:";
            // 
            // cboPelaje
            // 
            cboPelaje.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPelaje.FormattingEnabled = true;
            cboPelaje.Location = new Point(705, 14);
            cboPelaje.Name = "cboPelaje";
            cboPelaje.Size = new Size(121, 23);
            cboPelaje.TabIndex = 5;
            cboPelaje.SelectedIndexChanged += cboPelaje_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 17);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 4;
            label4.Text = "Caracteristicas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 17);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 4;
            label3.Text = "Personalidad:";
            // 
            // cboCaracteristicas
            // 
            cboCaracteristicas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCaracteristicas.FormattingEnabled = true;
            cboCaracteristicas.Location = new Point(531, 14);
            cboCaracteristicas.Name = "cboCaracteristicas";
            cboCaracteristicas.Size = new Size(121, 23);
            cboCaracteristicas.TabIndex = 3;
            cboCaracteristicas.SelectedIndexChanged += cboCaracteristicas_SelectedIndexChanged;
            // 
            // cboPersonalidad
            // 
            cboPersonalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPersonalidad.FormattingEnabled = true;
            cboPersonalidad.Location = new Point(302, 14);
            cboPersonalidad.Name = "cboPersonalidad";
            cboPersonalidad.Size = new Size(121, 23);
            cboPersonalidad.TabIndex = 3;
            cboPersonalidad.SelectedIndexChanged += cboPersonalidad_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 17);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Tamaño:";
            // 
            // cboTamaño
            // 
            cboTamaño.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTamaño.FormattingEnabled = true;
            cboTamaño.Location = new Point(79, 14);
            cboTamaño.Name = "cboTamaño";
            cboTamaño.Size = new Size(121, 23);
            cboTamaño.TabIndex = 1;
            cboTamaño.SelectedIndexChanged += cboTamaño_SelectedIndexChanged;
            // 
            // dgvPerros
            // 
            dgvPerros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerros.Location = new Point(43, 138);
            dgvPerros.Name = "dgvPerros";
            dgvPerros.Size = new Size(840, 260);
            dgvPerros.TabIndex = 13;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(255, 189, 89);
            btnRegresar.BackgroundImageLayout = ImageLayout.None;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Poor Richard", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.Black;
            btnRegresar.Location = new Point(738, 416);
            btnRegresar.Margin = new Padding(0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(123, 44);
            btnRegresar.TabIndex = 12;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click_1;
            // 
            // btnMostrarInfo
            // 
            btnMostrarInfo.BackColor = Color.FromArgb(255, 189, 89);
            btnMostrarInfo.BackgroundImageLayout = ImageLayout.None;
            btnMostrarInfo.FlatAppearance.BorderSize = 0;
            btnMostrarInfo.FlatStyle = FlatStyle.Flat;
            btnMostrarInfo.Font = new Font("Poor Richard", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMostrarInfo.ForeColor = Color.Black;
            btnMostrarInfo.Location = new Point(246, 416);
            btnMostrarInfo.Margin = new Padding(0);
            btnMostrarInfo.Name = "btnMostrarInfo";
            btnMostrarInfo.Size = new Size(123, 44);
            btnMostrarInfo.TabIndex = 11;
            btnMostrarInfo.Text = "Mostrar Inf";
            btnMostrarInfo.UseVisualStyleBackColor = false;
            btnMostrarInfo.Click += btnMostrarInfo_Click_1;
            // 
            // btnAdoptar
            // 
            btnAdoptar.BackColor = Color.FromArgb(255, 189, 89);
            btnAdoptar.BackgroundImageLayout = ImageLayout.None;
            btnAdoptar.FlatAppearance.BorderSize = 0;
            btnAdoptar.FlatStyle = FlatStyle.Flat;
            btnAdoptar.Font = new Font("Poor Richard", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdoptar.ForeColor = Color.Black;
            btnAdoptar.Location = new Point(67, 416);
            btnAdoptar.Margin = new Padding(0);
            btnAdoptar.Name = "btnAdoptar";
            btnAdoptar.Size = new Size(125, 44);
            btnAdoptar.TabIndex = 10;
            btnAdoptar.Text = "Adoptar";
            btnAdoptar.UseVisualStyleBackColor = false;
            btnAdoptar.Click += btnAdoptar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 73);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 0;
            label1.Text = "Filtrar:";
            // 
            // perroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(935, 494);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "perroForm";
            Text = "perroForm";
            AutoSizeChanged += perroForm_AutoSizeChanged;
            Load += perroForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvPerros;
        private Button btnRegresar;
        private Button btnMostrarInfo;
        private Button btnAdoptar;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private ComboBox cboPelaje;
        private Label label4;
        private Label label3;
        private ComboBox cboCaracteristicas;
        private ComboBox cboPersonalidad;
        private Label label2;
        private ComboBox cboTamaño;
    }
}