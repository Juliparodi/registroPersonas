using registroPersonasLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registroPersonasConsole
{
    public partial class Form1 : Form
    {
        List<Persona> personas;
        public Form1(FormPrincipal frmPrincipal)
        {
            personas = new List<Persona>();
            this.Owner = frmPrincipal;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarListas();
            Limpiar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            chkActivo.Checked = false;
            cmbTipoDNI.SelectedIndex = 0;
            txtDNI.Text = string.Empty;
        }

        private void CargarListas()
        {
            this.cmbTipoDNI.DataSource = tipoDNIHelper.getListaTipoDni();
            this.cmbTipoDNI.DisplayMember = "Descripcion";
            this.cmbTipoDNI.ValueMember = "Codigo";
        }

        private void Validar()
        {
            if ((int)cmbTipoDNI.SelectedValue == 0)
                throw new Exception("Seleccione estado civil");

            if (ti.Text == string.Empty)
                throw new Exception("Apellido no puede estar en blanco");

            if (t.Text == string.Empty)
                throw new Exception("Nombre no puede estar en blanco");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Validar();

                Persona p = new Cliente(1, txtNombre.Text, txtApellido.Text, cmbTipoDNI.SelectedValue.ToString(), txtDNI.Text, chkActivo.Checked);

                personas.Add(p);

                MessageBox.Show(p.ToString());

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoDNI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            FrmListaClientes frmLista = new FrmListaClientes(this, personas);

            frmLista.Show();

            this.Hide();
        }
    }
}
