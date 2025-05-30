namespace Fundacion_Animales
{
    partial class SolicitudForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudForm));
            txtRespuesta1 = new TextBox();
            txtRespuesta2 = new TextBox();
            txtRespuesta3 = new TextBox();
            txtRespuesta4 = new TextBox();
            txtRespuesta5 = new TextBox();
            btnEnviar = new Button();
            btnRegresar = new Button();
            ptbFoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbFoto).BeginInit();
            SuspendLayout();
            // 
            // txtRespuesta1
            // 
            txtRespuesta1.Location = new Point(272, 130);
            txtRespuesta1.Multiline = true;
            txtRespuesta1.Name = "txtRespuesta1";
            txtRespuesta1.Size = new Size(573, 66);
            txtRespuesta1.TabIndex = 0;
            // 
            // txtRespuesta2
            // 
            txtRespuesta2.Location = new Point(272, 198);
            txtRespuesta2.Multiline = true;
            txtRespuesta2.Name = "txtRespuesta2";
            txtRespuesta2.Size = new Size(573, 55);
            txtRespuesta2.TabIndex = 1;
            // 
            // txtRespuesta3
            // 
            txtRespuesta3.Location = new Point(272, 256);
            txtRespuesta3.Multiline = true;
            txtRespuesta3.Name = "txtRespuesta3";
            txtRespuesta3.Size = new Size(573, 63);
            txtRespuesta3.TabIndex = 2;
            // 
            // txtRespuesta4
            // 
            txtRespuesta4.Location = new Point(272, 320);
            txtRespuesta4.Multiline = true;
            txtRespuesta4.Name = "txtRespuesta4";
            txtRespuesta4.Size = new Size(573, 52);
            txtRespuesta4.TabIndex = 3;
            // 
            // txtRespuesta5
            // 
            txtRespuesta5.Location = new Point(272, 374);
            txtRespuesta5.Multiline = true;
            txtRespuesta5.Name = "txtRespuesta5";
            txtRespuesta5.Size = new Size(573, 54);
            txtRespuesta5.TabIndex = 4;
            // 
            // btnEnviar
            // 
            btnEnviar.BackgroundImage = (Image)resources.GetObject("btnEnviar.BackgroundImage");
            btnEnviar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Location = new Point(247, 451);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(203, 43);
            btnEnviar.TabIndex = 5;
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(487, 451);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(203, 43);
            btnRegresar.TabIndex = 6;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // ptbFoto
            // 
            ptbFoto.BackgroundImageLayout = ImageLayout.Stretch;
            ptbFoto.Location = new Point(718, 8);
            ptbFoto.Name = "ptbFoto";
            ptbFoto.Size = new Size(119, 100);
            ptbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbFoto.TabIndex = 7;
            ptbFoto.TabStop = false;
            // 
            // SolicitudForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(935, 494);
            Controls.Add(ptbFoto);
            Controls.Add(btnRegresar);
            Controls.Add(btnEnviar);
            Controls.Add(txtRespuesta5);
            Controls.Add(txtRespuesta4);
            Controls.Add(txtRespuesta3);
            Controls.Add(txtRespuesta2);
            Controls.Add(txtRespuesta1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SolicitudForm";
            Text = "SolicitudForm";
            Load += SolicitudForm_Load;
            ((System.ComponentModel.ISupportInitialize)ptbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRespuesta1;
        private TextBox txtRespuesta2;
        private TextBox txtRespuesta3;
        private TextBox txtRespuesta4;
        private TextBox txtRespuesta5;
        private Button btnEnviar;
        private Button btnRegresar;
        private PictureBox ptbFoto;
    }
}