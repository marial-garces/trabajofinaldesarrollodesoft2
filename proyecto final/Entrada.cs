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

        private void BusquedaContantoCB_Click(object sender, EventArgs e)
        {

        }
    }
}
