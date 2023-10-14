namespace Gestion_de_notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNombreEscuela = new TextBox();
            txtDireccionEscuela = new TextBox();
            dataGridEscuela = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtIdEscuela = new TextBox();
            label3 = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridEscuela).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Location = new Point(32, 145);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 60);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnPrueba_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 64);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre escuela";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(671, 64);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 2;
            label2.Text = "Direccion escuela";
            // 
            // txtNombreEscuela
            // 
            txtNombreEscuela.BorderStyle = BorderStyle.FixedSingle;
            txtNombreEscuela.Location = new Point(290, 87);
            txtNombreEscuela.Name = "txtNombreEscuela";
            txtNombreEscuela.Size = new Size(359, 27);
            txtNombreEscuela.TabIndex = 3;
            // 
            // txtDireccionEscuela
            // 
            txtDireccionEscuela.BorderStyle = BorderStyle.FixedSingle;
            txtDireccionEscuela.Location = new Point(671, 87);
            txtDireccionEscuela.Name = "txtDireccionEscuela";
            txtDireccionEscuela.Size = new Size(516, 27);
            txtDireccionEscuela.TabIndex = 4;
            // 
            // dataGridEscuela
            // 
            dataGridEscuela.AllowUserToAddRows = false;
            dataGridEscuela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridEscuela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEscuela.Location = new Point(42, 230);
            dataGridEscuela.Name = "dataGridEscuela";
            dataGridEscuela.RowHeadersWidth = 51;
            dataGridEscuela.RowTemplate.Height = 29;
            dataGridEscuela.Size = new Size(1145, 393);
            dataGridEscuela.TabIndex = 5;
            dataGridEscuela.CellMouseClick += Seleccionar;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(345, 145);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 60);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(722, 145);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 60);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdEscuela
            // 
            txtIdEscuela.BorderStyle = BorderStyle.FixedSingle;
            txtIdEscuela.Location = new Point(42, 87);
            txtIdEscuela.Name = "txtIdEscuela";
            txtIdEscuela.ReadOnly = true;
            txtIdEscuela.Size = new Size(169, 27);
            txtIdEscuela.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 64);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 1;
            label3.Text = "ID";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(1051, 145);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 60);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnCancelar);
            Controls.Add(txtIdEscuela);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dataGridEscuela);
            Controls.Add(txtDireccionEscuela);
            Controls.Add(txtNombreEscuela);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Gestion de notas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridEscuela).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private TextBox txtNombreEscuela;
        private TextBox txtDireccionEscuela;
        private DataGridView dataGridEscuela;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtIdEscuela;
        private Label label3;
        private Button btnCancelar;
    }
}