namespace Gestion_de_notas
{
    partial class alumnoFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alumnoFormulario));
            dataGridAlumno = new DataGridView();
            picAlumno = new PictureBox();
            btnAgregarFoto = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtNieAlumno = new TextBox();
            txtIdEscuela = new TextBox();
            label2 = new Label();
            txtNombreAlumno = new TextBox();
            label3 = new Label();
            txtApellidoAlumno = new TextBox();
            label4 = new Label();
            txtDireccionAlumno = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dateAlumno = new DateTimePicker();
            cmbGeneroAlumno = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridAlumno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAlumno).BeginInit();
            SuspendLayout();
            // 
            // dataGridAlumno
            // 
            dataGridAlumno.AllowUserToAddRows = false;
            dataGridAlumno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAlumno.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridAlumno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAlumno.Cursor = Cursors.Hand;
            dataGridAlumno.Location = new Point(29, 332);
            dataGridAlumno.Name = "dataGridAlumno";
            dataGridAlumno.RowHeadersWidth = 51;
            dataGridAlumno.RowTemplate.Height = 29;
            dataGridAlumno.Size = new Size(1207, 329);
            dataGridAlumno.TabIndex = 0;
            dataGridAlumno.CellFormatting += dataGridAlumno_CellFormatting;
            dataGridAlumno.CellMouseClick += Seleccionar;
            // 
            // picAlumno
            // 
            picAlumno.Location = new Point(947, 11);
            picAlumno.Name = "picAlumno";
            picAlumno.Size = new Size(251, 230);
            picAlumno.SizeMode = PictureBoxSizeMode.StretchImage;
            picAlumno.TabIndex = 1;
            picAlumno.TabStop = false;
            // 
            // btnAgregarFoto
            // 
            btnAgregarFoto.Cursor = Cursors.Hand;
            btnAgregarFoto.Location = new Point(1006, 260);
            btnAgregarFoto.Name = "btnAgregarFoto";
            btnAgregarFoto.Size = new Size(135, 52);
            btnAgregarFoto.TabIndex = 2;
            btnAgregarFoto.Text = "Examinar";
            btnAgregarFoto.UseVisualStyleBackColor = true;
            btnAgregarFoto.Click += btnAgregarFoto_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Location = new Point(29, 260);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(135, 52);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(266, 260);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(135, 52);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(500, 260);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(135, 52);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(740, 260);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 52);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 11);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 3;
            label1.Text = "NIE";
            // 
            // txtNieAlumno
            // 
            txtNieAlumno.BorderStyle = BorderStyle.FixedSingle;
            txtNieAlumno.Location = new Point(28, 34);
            txtNieAlumno.Name = "txtNieAlumno";
            txtNieAlumno.ReadOnly = true;
            txtNieAlumno.Size = new Size(135, 27);
            txtNieAlumno.TabIndex = 4;
            // 
            // txtIdEscuela
            // 
            txtIdEscuela.BorderStyle = BorderStyle.FixedSingle;
            txtIdEscuela.Location = new Point(190, 34);
            txtIdEscuela.Name = "txtIdEscuela";
            txtIdEscuela.Size = new Size(135, 27);
            txtIdEscuela.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 11);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 5;
            label2.Text = "ID escuela";
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.BorderStyle = BorderStyle.FixedSingle;
            txtNombreAlumno.Location = new Point(28, 91);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(390, 27);
            txtNombreAlumno.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 68);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Nombres";
            // 
            // txtApellidoAlumno
            // 
            txtApellidoAlumno.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoAlumno.Location = new Point(484, 91);
            txtApellidoAlumno.Name = "txtApellidoAlumno";
            txtApellidoAlumno.Size = new Size(390, 27);
            txtApellidoAlumno.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 68);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 9;
            label4.Text = "Apellidos";
            // 
            // txtDireccionAlumno
            // 
            txtDireccionAlumno.BorderStyle = BorderStyle.FixedSingle;
            txtDireccionAlumno.Location = new Point(28, 152);
            txtDireccionAlumno.Name = "txtDireccionAlumno";
            txtDireccionAlumno.Size = new Size(845, 27);
            txtDireccionAlumno.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 129);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 11;
            label5.Text = "Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 191);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 11;
            label6.Text = "Fecha de nacimiento";
            // 
            // dateAlumno
            // 
            dateAlumno.CustomFormat = "dd/MM/yyyy";
            dateAlumno.Format = DateTimePickerFormat.Custom;
            dateAlumno.Location = new Point(28, 214);
            dateAlumno.Name = "dateAlumno";
            dateAlumno.Size = new Size(389, 27);
            dateAlumno.TabIndex = 13;
            dateAlumno.Value = new DateTime(2022, 12, 18, 0, 0, 0, 0);
            // 
            // cmbGeneroAlumno
            // 
            cmbGeneroAlumno.FormattingEnabled = true;
            cmbGeneroAlumno.Items.AddRange(new object[] { "F", "M" });
            cmbGeneroAlumno.Location = new Point(483, 212);
            cmbGeneroAlumno.Name = "cmbGeneroAlumno";
            cmbGeneroAlumno.Size = new Size(390, 28);
            cmbGeneroAlumno.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(483, 189);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 11;
            label7.Text = "Genero";
            // 
            // alumnoFormulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(cmbGeneroAlumno);
            Controls.Add(dateAlumno);
            Controls.Add(txtDireccionAlumno);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtApellidoAlumno);
            Controls.Add(label4);
            Controls.Add(txtNombreAlumno);
            Controls.Add(label3);
            Controls.Add(txtIdEscuela);
            Controls.Add(label2);
            Controls.Add(txtNieAlumno);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(btnAgregarFoto);
            Controls.Add(picAlumno);
            Controls.Add(dataGridAlumno);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "alumnoFormulario";
            Text = "Alumno";
            Load += alumnoFormulario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridAlumno).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAlumno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridAlumno;
        private PictureBox picAlumno;
        private Button btnAgregarFoto;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtNieAlumno;
        private TextBox txtIdEscuela;
        private Label label2;
        private TextBox txtNombreAlumno;
        private Label label3;
        private TextBox txtApellidoAlumno;
        private Label label4;
        private TextBox txtDireccionAlumno;
        private Label label5;
        private Label label6;
        private DateTimePicker dateAlumno;
        private ComboBox cmbGeneroAlumno;
        private Label label7;
    }
}