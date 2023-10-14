using Gestion_de_notas.ClasesDatos;
using Gestion_de_notas.ClasesSQL;

namespace Gestion_de_notas
{
    public partial class Form1 : Form
    {
        EscuelaSQL escuelaSQL;
        public Form1()
        {
            escuelaSQL = new EscuelaSQL();
            InitializeComponent();
            actualizarDatos();
            limpiarOpciones();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            EscuelaDatos escuelaDatos = new EscuelaDatos();

            if (string.IsNullOrEmpty(txtNombreEscuela.Text) || string.IsNullOrEmpty(txtDireccionEscuela.Text))
            {
                MessageBox.Show("Todos los datos deben contener informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                escuelaSQL.Agregar(datosEscuela());
                actualizarDatos();
                limpiarOpciones();
            }
        }
        private EscuelaDatos datosEscuela()
        {
            EscuelaDatos escuelaDatos = new EscuelaDatos();
            int ID = 0; int.TryParse(txtIdEscuela.Text, out ID);
            escuelaDatos.IdEscuela = ID;
            escuelaDatos.NombreEscuela = txtNombreEscuela.Text;
            escuelaDatos.DireccionEscuela = txtDireccionEscuela.Text;
            return escuelaDatos;
        }


        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;

            dataGridEscuela.ClearSelection();

            if (index >= 0)
            {
                txtIdEscuela.Text = dataGridEscuela.Rows[index].Cells[0].Value.ToString();
                txtNombreEscuela.Text = dataGridEscuela.Rows[index].Cells[1].Value.ToString();
                txtDireccionEscuela.Text = dataGridEscuela.Rows[index].Cells[2].Value.ToString();

                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            escuelaSQL.Eliminar(datosEscuela());
            actualizarDatos();
            limpiarOpciones();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            escuelaSQL.Editar(datosEscuela());
            actualizarDatos();
            limpiarOpciones();
        }

        public void actualizarDatos()
        {
            dataGridEscuela.DataSource = escuelaSQL.mostrarEscuela().Tables[0];

            dataGridEscuela.Columns[0].HeaderText = "ID";
            dataGridEscuela.Columns[1].HeaderText = "Nombre de la escuela";
            dataGridEscuela.Columns[2].HeaderText = "Direccion de la escuela";
        }

        public void limpiarOpciones()
        {
            txtIdEscuela.Text = "";
            txtNombreEscuela.Text = "";
            txtDireccionEscuela.Text = "";

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