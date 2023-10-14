using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_notas
{
    public partial class pruebaFotocs : Form
    {
        byte[] imagePruebaByte;
        public pruebaFotocs()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar imagen";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picPruebaFoto.Image = Image.FromStream(ofd.OpenFile());
                MemoryStream memory = new MemoryStream();
                picPruebaFoto.Image.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                imagePruebaByte = memory.ToArray();
            }
        }
    }
}
