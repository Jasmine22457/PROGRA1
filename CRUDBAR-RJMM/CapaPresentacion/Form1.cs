using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new();
        private string idProducto;
        private bool Editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerProds();
        }

        private void LeerProds()
        {

            CN_Productos objeto = new();
            dataGridView1.DataSource = objeto.LeerProd();
        }
         private void LimpiarForm()
        {
            txtProd.Clear();
            txtDesc.Clear();
            txtPrec.Clear();
            txtExis.Clear();
            txtEsta.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            { if (Editar == false)

               try
               {
                 objetoCN.Insprod(txtProd.Text, txtDesc.Text, txtPrec.Text, txtExis.Text, txtEsta.Text);
                        MessageBox.Show("El registro se ingreso correctamente");
                        LeerProds();
                        LimpiarForm();

               }
               catch (Exception ex)
               {
                 MessageBox.Show("registro no pudo ser almacenado, el motivo es:"+ex);
                }

            }
            if(Editar == true)
            {
                try
                {
                 objetoCN.Insprod(txtProd.Text, txtDesc.Text, txtPrec.Text, txtExis.Text, txtEsta.Text);
                    MessageBox.Show("El registro se actualizo correctamnete");
                    LeerProds();
                    LimpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("registro no pudo ser actualizado, el motivo es:" + ex);
                }
            }
        
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
         
                Editar = true;
                txtProd.Text = dataGridView1.CurrentRow.Cells["nomprod"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                txtPrec.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                txtExis.Text = dataGridView1.CurrentRow.Cells["cantidad"].Value.ToString();
                txtEsta.Text = dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
            }
            else
                MessageBox.Show("por favor seleccione una fila ");
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    idProducto = dataGridView1.CurrentRow.Cells["idproducto"].Value.ToString();
                    objetoCN.EliProd(idProducto);
                    MessageBox.Show("Eliminado correctamente");
                    LeerProds();

                }
                else
                    MessageBox.Show("seleccione una fila");


            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}