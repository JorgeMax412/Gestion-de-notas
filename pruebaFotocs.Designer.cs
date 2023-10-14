namespace Gestion_de_notas
{
    partial class pruebaFotocs
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
            picPruebaFoto = new PictureBox();
            btnAgregar = new Button();
            btnCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)picPruebaFoto).BeginInit();
            SuspendLayout();
            // 
            // picPruebaFoto
            // 
            picPruebaFoto.Location = new Point(292, 36);
            picPruebaFoto.Name = "picPruebaFoto";
            picPruebaFoto.Size = new Size(252, 286);
            picPruebaFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picPruebaFoto.TabIndex = 0;
            picPruebaFoto.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(436, 350);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 49);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(292, 350);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(108, 49);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // pruebaFotocs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 549);
            Controls.Add(btnCargar);
            Controls.Add(btnAgregar);
            Controls.Add(picPruebaFoto);
            Name = "pruebaFotocs";
            Text = "pruebaFotocs";
            ((System.ComponentModel.ISupportInitialize)picPruebaFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picPruebaFoto;
        private Button btnAgregar;
        private Button btnCargar;
    }
}