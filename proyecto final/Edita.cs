using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyecto_final
{
    public partial class Edita : Form
    {
        static string agendotastring = "data source = LAPTOP-8HDRD3GH\\SQLEXPRESS; database= agendota; integrated security= true";
        SqlConnection agendota = new SqlConnection(agendotastring);

        public Edita()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCell_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIniciales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProfesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string agendotica = "Insert into edita ([Apodo] ,[Nombre1] ,[Nombre2] ,[Apellidos], [Profesion], [Iniciales], [Telefono1], [Telefono2], [Correo], [Nota]) " +
                " values ('"+txtApodo+"','"+txtNombre1+"','"+txtNombre2+"','"+txtApellidos+"','"+txtProfesion+"','"+txtIniciales+ "','"+txtCasa+ "','"+txtCell+ "','"+txtEmail+ "','"+txtNota+"')";
            SqlCommand agendototica = new SqlCommand(agendotica, agendota);
            agendototica.ExecuteNonQuery();
            string correo = txtEmail.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {

        }

        private void gbContact_Enter(object sender, EventArgs e)
        {

        }
    }
}
