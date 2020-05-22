using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace ControlProcductos
{
    public partial class frmActualizarProducto : Form
    {

        public bool eliminar = false;
        public DataGridViewRow datosNuevos =  new DataGridViewRow();
        public frmActualizarProducto()
        {
            InitializeComponent();
        }

        public frmActualizarProducto(DataGridViewRow fila, List<string> cat)
        {
            InitializeComponent();
            //verificar si se ha recibido la información
            //Debug.WriteLine(fila.Cells["Codigo"].Value.ToString() + fila.Cells["Descripcion"].Value.ToString() + fila.Cells["Precio"].Value.ToString());
            txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
            foreach (string dato in cat)
            {
                cmbCategorias.Items.Add(dato);

            }
            cmbCategorias.Text = fila.Cells["Categoria"].Value.ToString();


        }

        private void frmActualizarProducto_Load(object sender, EventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar = true;
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            datosNuevos.Cells.Add(new DataGridViewTextBoxCell() { Value = txtCodigo.Text });
            datosNuevos.Cells.Add(new DataGridViewTextBoxCell() { Value = txtDescripcion.Text });
            datosNuevos.Cells.Add(new DataGridViewTextBoxCell() { Value = txtPrecio.Text });
            datosNuevos.Cells.Add(new DataGridViewTextBoxCell() { Value = cmbCategorias.Text });
            this.Close();
        }
    }
}
