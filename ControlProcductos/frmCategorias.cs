using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregar libreria de depuración
using System.Diagnostics;

namespace ControlProcductos
{
    public partial class frmCategorias : Form
    {

        public List<string> cat;
        ComboBox misCategorias;
        public frmCategorias()
        {
            InitializeComponent();
        }

        public frmCategorias(List<string> c, ComboBox cc)
        {
            InitializeComponent();
            cat = new List<string>();
            cat = c;
            misCategorias = cc;
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            foreach (string i in cat) 
            {
                cmbCategorias.Items.Add(i);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtcategoria.Text == "")
            {
                MessageBox.Show("No se puede dejar la categoria en blanco...");
            }
            else 
            {
                cmbCategorias.Items.Add(txtcategoria.Text);
                cat.Add(txtcategoria.Text);
                misCategorias.Items.Add(txtcategoria.Text);
                MessageBox.Show("Categoria agregada correctamente");
                txtcategoria.Text = "";
                txtcategoria.Select();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCategorias.Text == "")
            {
                MessageBox.Show("Debe seleccionar una categoria");
            }
            else 
            {
                //para depurar se utiliza Debug.... o se presiona la tecla F9 para detener la ejecución y examinar variables y objetos
                //Debug.WriteLine("Contenido del combobox" + cmbCategorias.Text);
                cat.Remove(cmbCategorias.Text);
                cmbCategorias.Items.Remove(cmbCategorias.Text);               

            }
        }
    }
}
