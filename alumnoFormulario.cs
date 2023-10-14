using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Gestion_de_notas.ClasesDatos;
using Gestion_de_notas.ClasesSQL;

namespace Gestion_de_notas
{
    public partial class alumnoFormulario : Form
    {
        AlumnoSQL alumnoSQL;
        private byte[] imageAlumnoByte;

        public alumnoFormulario()
        {
            InitializeComponent();
            alumnoSQL = new AlumnoSQL();
            actualizarDatos();
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar imagen";
            openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAlumno.Image = Image.FromFile(openFileDialog.FileName);

                // Convertir la imagen a bytes y asignarla a la propiedad
                using (MemoryStream memory = new MemoryStream())
                {
                    picAlumno.Image.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                    imageAlumnoByte = memory.ToArray();
                }
            }
        }

        private AlumnoDatos datosAlumno()
        {
            AlumnoDatos alumnoDatos = new AlumnoDatos();
            int NIE = 0;
            int.TryParse(txtNieAlumno.Text, out NIE);
            alumnoDatos.NieAlumno = NIE;

            alumnoDatos.NombreAlumno = txtNombreAlumno.Text;
            alumnoDatos.ApellidoAlumno = txtApellidoAlumno.Text;
            alumnoDatos.FechaNacAlumno = DateOnly.FromDateTime(dateAlumno.Value);
            string generoSeleccionado = cmbGeneroAlumno.SelectedItem.ToString();
            alumnoDatos.GeneroAlumno = generoSeleccionado;
            alumnoDatos.DireccionAlumno = txtDireccionAlumno.Text;
            alumnoDatos.FotoAlumno = imageAlumnoByte; // Asigna la imagen

            int EscuelaID = 0;
            int.TryParse(txtIdEscuela.Text, out EscuelaID);
            alumnoDatos.IdEscuela = EscuelaID;

            return alumnoDatos;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            alumnoSQL.Agregar(datosAlumno());
            actualizarDatos();
        }


        private void alumnoFormulario_Load(object sender, EventArgs e)
        {

        }

        public void actualizarDatos()
        {
            dataGridAlumno.DataSource = alumnoSQL.mostrarAlumno().Tables[0];

            dataGridAlumno.Columns[0].HeaderText = "NIE";
            dataGridAlumno.Columns[1].HeaderText = "Nombres";
            dataGridAlumno.Columns[2].HeaderText = "Apellidos";
            dataGridAlumno.Columns[3].HeaderText = "Fecha de nacimiento";
            dataGridAlumno.Columns[4].HeaderText = "Genero";
            dataGridAlumno.Columns[5].HeaderText = "Direccion";
            dataGridAlumno.Columns[6].HeaderText = "Foto";
            dataGridAlumno.Columns[7].HeaderText = "Codigo escuela";
        }



        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            dataGridAlumno.ClearSelection();

            if (index >= 0)
            {
                txtNieAlumno.Text = dataGridAlumno.Rows[index].Cells[0].Value.ToString();
                txtNombreAlumno.Text = dataGridAlumno.Rows[index].Cells[1].Value.ToString();
                txtApellidoAlumno.Text = dataGridAlumno.Rows[index].Cells[2].Value.ToString();
                dateAlumno.Value = DateTime.Parse(dataGridAlumno.Rows[index].Cells[3].Value.ToString());
                cmbGeneroAlumno.Text = dataGridAlumno.Rows[index].Cells[4].Value.ToString();
                txtDireccionAlumno.Text = dataGridAlumno.Rows[index].Cells[5].Value.ToString();

                if (dataGridAlumno.Rows[index].Cells[6].Value != null)
                {
                    imageAlumnoByte = (byte[])dataGridAlumno.Rows[index].Cells[6].Value;
                    using (MemoryStream memory = new MemoryStream(imageAlumnoByte))
                    {
                        picAlumno.Image = Image.FromStream(memory);
                    }
                }
                else
                {
                    picAlumno.Image = null;
                }

                txtIdEscuela.Text = dataGridAlumno.Rows[index].Cells[7].Value.ToString();

                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true;
            }

        }

        private void dataGridAlumno_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6) //Columna donde esta la imagen
            {
                if (e.Value != null)
                {
                    //Obtener la imagen
                    byte[] imageData = (byte[])e.Value;
                    using (MemoryStream memory = new MemoryStream(imageData))
                    {
                        Image originalImage = Image.FromStream(memory);

                        //Ajustar el tamaño de la imagen
                        int maxWidth = 80;
                        int maxHeight = 80;
                        Image resizedImage = new Bitmap(originalImage, new Size(maxWidth, maxHeight));
                        e.Value = resizedImage;
                    }
                }
            }
        }

        public void limpiarOpciones()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarOpciones();
        }
    }
}
