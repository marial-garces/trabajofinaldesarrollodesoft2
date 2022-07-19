using System;
using System.Windows.Forms;

namespace proyecto_final
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void g_Enter(object sender, EventArgs e)
        {

        }

        private void Entrada_Load(object sender, EventArgs e)
        {

        }

        private void BotonBusqueda_Click(object sender, EventArgs e)
        {
            var Openform = new Edita();
            Openform.Show();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            Edita Aedita = new Edita();
            Aedita.Show();
        }

        private void BusquedaContantoCB_Click(object sender, EventArgs e)
        {

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ContactosGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BusquedaContantoCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
