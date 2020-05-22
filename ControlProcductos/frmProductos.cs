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
    public partial class frmProductos : Form
    {
        List<string> categorias;

        public frmProductos()
        {
           InitializeComponent();
            categorias = new List<string>();
            categorias.Add("Mercado");
            categorias.Add("Papeleria");
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.Rows.Add("A001", "Lapiz", "700", "Papeleria");
            dgvProductos.Rows.Add("A002", "Borrador de nata", "1200", "Papeleria");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoProducto ventana = new frmNuevoProducto(categorias, dgvProductos);
            //abrir un formulario como un modal(única ventana activa)
            ventana.ShowDialog();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = dgvProductos.CurrentRow.Index;
            frmActualizarProducto actualizar = new frmActualizarProducto(dgvProductos.Rows[i], categorias);
            actualizar.ShowDialog();
            if (actualizar.eliminar)
            {
                dgvProductos.Rows.RemoveAt(i);
            }
            else 
            {
                dgvProductos.Rows[i].Cells["Codigo"].Value = actualizar.datosNuevos.Cells[0].Value.ToString();
                dgvProductos.Rows[i].Cells["Descripcion"].Value = actualizar.datosNuevos.Cells[1].Value.ToString();
                dgvProductos.Rows[i].Cells["Precio"].Value = actualizar.datosNuevos.Cells[2].Value.ToString();
                dgvProductos.Rows[i].Cells["Categoria"].Value = actualizar.datosNuevos.Cells[3].Value.ToString();


            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
