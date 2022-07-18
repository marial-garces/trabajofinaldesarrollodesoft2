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

        private void obtener()
        {
         

             if (txtBuscar.Text == "")
             {
                 string query = "select * from edita";
                SqlCommand agendototica = new SqlCommand(query, agendota);
                 SqlDataAdapter data = new SqlDataAdapter(agendototica);
                 DataTable editica = new DataTable();
                 data.Fill(editica);
                 dgvCont.DataSource = editica;
             }
             else
             {
                 string query = "select * from edita where Nombre ='" + txtBuscar.Text + "'";
                SqlCommand agendototica = new SqlCommand(query, agendota);
                 SqlDataAdapter data = new SqlDataAdapter(agendototica);
                 DataTable editica = new DataTable();
                 data.Fill(editica);
                 dgvCont.DataSource = editica;
             }
        }

        public Edita()
        {
            InitializeComponent();
        }
        public int baseC;
        private void Form1_Load(object sender, EventArgs e)
        {
            obtener();
           agendota.Open();

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
       
            string correo = txtEmail.Text;
            Int64 NUMERO1;
            NUMERO1 = Int64.Parse(txtCell.Text);
            Int64 NUMERO2;
            NUMERO2 = Int64.Parse(txtCasa.Text);

            string agendotica = "Insert into edita ([Apodo] ,[Nombre1] ,[Nombre2] ,[Apellidos], [Profesion], [Iniciales], [Telefono1], [Telefon2], [Correo], [Nota]) " +
                " values ('"+txtApodo.Text+"','"+txtNombre1.Text+"','"+txtNombre2.Text+"','"+txtApellidos.Text+"','"+txtProfesion.Text+"','"+txtIniciales.Text+ "','"+NUMERO2+ "','"+NUMERO1+"', '"+correo+ "','"+txtNota.Text+"')";
            SqlCommand agendototica = new SqlCommand(agendotica, agendota);
            agendototica.ExecuteNonQuery();
            MessageBox.Show("Guardado Exitosamente");

            obtener();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           string queri = "Delete from edita Where Id = @Id";
            SqlCommand comando = new SqlCommand(queri, agendota );
            comando.Parameters.AddWithValue("@Id", txtId.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Borrado");
            obtener();

        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {

        }

        private void gbContact_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCont_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            baseC = Convert.ToInt32(dgvCont.Rows[0].Cells[0].Value);
            txtApodo.Text = dgvCont.SelectedRows[0].Cells[1].Value.ToString();
            txtNombre1.Text = dgvCont.SelectedRows[0].Cells[2].Value.ToString();
            txtNombre2.Text = dgvCont.SelectedRows[0].Cells[3].Value.ToString();
            txtApellidos.Text = dgvCont.SelectedRows[0].Cells[4].Value.ToString();
            txtProfesion.Text = dgvCont.SelectedRows[0].Cells[5].Value.ToString();
            txtIniciales.Text = dgvCont.SelectedRows[0].Cells[6].Value.ToString();
            txtCasa.Text = dgvCont.SelectedRows[0].Cells[7].Value.ToString();
            txtCell.Text = dgvCont.SelectedRows[0].Cells[8].Value.ToString();
            txtEmail.Text = dgvCont.SelectedRows[0].Cells[9].Value.ToString();
            txtNota.Text = dgvCont.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdit_Click(object sender, EventArgs e)
        {
            Int64 NUMERO2;
            NUMERO2 = Int64.Parse(txtCasa.Text);
            Int64 NUMERO1;
            NUMERO1 = Int64.Parse(txtCell.Text);
            string correo = txtEmail.Text;
            string queri = "Update edita set Apodo = @Apodo,Nombre1 = @Nombre1,Nombre2= @Nombre2,Apellidos = @Apellidos,Profesion = @Profesion, Iniciales = @Iniciales, Telefono1 = @Telefono1, Telefon2 = @Telefon2, Correo = @Correo, Nota = @Nota where Id = @Id";
            SqlCommand comando = new SqlCommand(queri, agendota);
            comando.Parameters.AddWithValue("@Apodo", txtApodo.Text);
            comando.Parameters.AddWithValue("@Nombre1", txtNombre1.Text);
            comando.Parameters.AddWithValue("@Nombre2", txtNombre2.Text);
            comando.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
            comando.Parameters.AddWithValue("@Profesion", txtProfesion.Text);
            comando.Parameters.AddWithValue("@Iniciales", txtIniciales.Text);
            comando.Parameters.AddWithValue("@Telefono1", NUMERO2);
            comando.Parameters.AddWithValue("@Telefon2", NUMERO1);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Nota", txtIniciales.Text);
            comando.Parameters.AddWithValue("@Id", txtId.Text);
            comando.ExecuteNonQuery();


            MessageBox.Show("Editado");
            obtener();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
