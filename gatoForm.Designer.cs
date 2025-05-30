namespace Fundacion_Animales
{
    partial class gatoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gatoForm));
            panel1 = new Panel();
            dgvGato = new DataGridView();
            btnRegresar = new Button();
            btnMostrarInfo = new Button();
            btnAdoptar = new Button();
            panel2 = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox3 = new ComboBox();
            label3 = new Label();
            comboBox4 = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGato).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvGato);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(btnMostrarInfo);
            panel1.Controls.Add(btnAdoptar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 494);
            panel1.TabIndex = 0;
            // 
            // dgvGato
            // 
            dgvGato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGato.Location = new Point(53, 141);
            dgvGato.Name = "dgvGato";
            dgvGato.Size = new Size(830, 256);
            dgvGato.TabIndex = 9;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(255, 189, 89);
            btnRegresar.BackgroundImageLayout = ImageLayout.None;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Poor Richard", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.Black;
            btnRegresar.Location = new Point(742, 416);
            btnRegresar.Margin = new Padding(0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(125, 44);
            btnRegresar.TabIndex = 8;
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
            btnMostrarInfo.Size = new Size(124, 44);
            btnMostrarInfo.TabIndex = 7;
            btnMostrarInfo.Text = "Mostrar Inf";
            btnMostrarInfo.UseVisualStyleBackColor = false;
            btnMostrarInfo.Click += btnMostrarInfo_Click;
            // 
            // btnAdoptar
            // 
            btnAdoptar.BackColor = Color.FromArgb(255, 189, 89);
            btnAdoptar.BackgroundImageLayout = ImageLayout.None;
            btnAdoptar.FlatAppearance.BorderSize = 0;
            btnAdoptar.FlatStyle = FlatStyle.Flat;
            btnAdoptar.Font = new Font("Poor Richard", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdoptar.ForeColor = Color.Black;
            btnAdoptar.Location = new Point(69, 416);
            btnAdoptar.Margin = new Padding(0);
            btnAdoptar.Name = "btnAdoptar";
            btnAdoptar.Size = new Size(127, 44);
            btnAdoptar.TabIndex = 6;
            btnAdoptar.Text = "Adoptar";
            btnAdoptar.UseVisualStyleBackColor = false;
            btnAdoptar.Click += btnAdoptar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(comboBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(53, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 47);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 16);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 0;
            label2.Text = "Tamaño:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(66, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(288, 13);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 16);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 5;
            label6.Text = "Personalidad:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(507, 13);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 16);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 7;
            label3.Text = "Caracteristicas:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(693, 13);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(649, 16);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "Pelaje";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 72);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 11;
            label1.Text = "Filtrar:";
            // 
            // gatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(935, 494);
            Controls.Add(panel1);
            Cursor = Cursors.SizeAll;
            FormBorderStyle = FormBorderStyle.None;
            Name = "gatoForm";
            Text = "gatoForm";
            Load += gatoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGato).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvGato;
        private Button btnRegresar;
        private Button btnMostrarInfo;
        private Button btnAdoptar;
        private Panel panel2;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox4;
        private Label label4;
        private ComboBox comboBox3;
        private Label label3;
        private ComboBox comboBox2;
        private Label label6;
        private Label label1;
    }
}