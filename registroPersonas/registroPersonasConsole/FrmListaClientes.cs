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
    public partial class FrmListaClientes : Form
    {
        List<Persona> personas;
        public FrmListaClientes(Form1 form, List<Persona> personas)
        {
            this.personas = personas;
            this.Owner = form;
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarList();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            cargarList();
        }

        private void cargarList()
        {
            this.lstClientes.DataSource = null;
            this.lstClientes.DataSource = personas;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void Limpiar()
        {
            this.lstClientes.DataSource = null;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            cargarList();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (lstClientes.DataSource != null)
            {
                Persona seleccionada = (Persona)lstClientes.SelectedValue;

                MessageBox.Show(seleccionada.ToString());
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (lstClientes.DataSource != null)
            {
                Persona seleccionada = (Persona)lstClientes.SelectedValue;
                seleccionada.Activo = false;

                MessageBox.Show(seleccionada.ToString());
            }
        }
    }
}
