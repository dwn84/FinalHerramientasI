using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlProcductos
{
    public partial class frmNuevoProducto : Form
    {
        List<string> listaCat;
        DataGridView miTabla;

        public frmNuevoProducto()
        {
            InitializeComponent();
        }

        public frmNuevoProducto(List<string> listaC, DataGridView tabla)
        {
            InitializeComponent();
            listaCat = listaC;
            miTabla = tabla;
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            foreach (string dato in listaCat)
            {
                cmbCategorias.Items.Add(dato);

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "" || cmbCategorias.Text == "") {
                MessageBox.Show("Faltan datos para agregar el producto");
            }
            else
            {
                miTabla.Rows.Add(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, cmbCategorias.Text);
                this.Close();
            }
            
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias cat = new frmCategorias(listaCat, cmbCategorias);
            cat.ShowDialog();
            //se ha terminado el proceso de categorias
            cmbCategorias.Items.Clear();
            foreach (string dato in cat.cat)
            {
                cmbCategorias.Items.Add(dato);

            }

        }
    }
}
