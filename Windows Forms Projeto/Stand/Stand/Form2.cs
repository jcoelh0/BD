using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stand
{
    public partial class Form2 : Form
    {
        private SqlConnection cn;
        private string selectedName;
        private int currentCliente;

        public Form2()
        {
            InitializeComponent();

        }

        public Form2(SqlConnection cn, string selectedName)
        {
            InitializeComponent();
            this.cn = cn;
            this.selectedName = selectedName;
            if(selectedName == "Cliente")
            {
                MessageBox.Show("cliente");
                loadClientes();
                
            }
            else if(selectedName == "Mecanico")
            {
                MessageBox.Show("mecanico");
                loadMecanicos();
                
            }
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void loadClientes()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.CLIENTE", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                Cliente C = new Cliente();
                C.Nome = reader["Nome"].ToString();
                C.Morada = reader["Morada"].ToString();
                C.Nif = reader["NIF"].ToString();
                C.Contacto = reader["Contacto"].ToString();
                C.NrCliente = reader["Nr_Cliente"].ToString();
                listBox1.Items.Add(C);
            }

            cn.Close();
            
            currentCliente = 0;
            //ShowCliente();

        }

        private void loadMecanicos()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.MECANICO", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                Mecanico C = new Mecanico();
                C.Nome = reader["Nome"].ToString();
                C.Morada = reader["Morada"].ToString();
                C.Nif = reader["NIF"].ToString();
                C.Contacto = reader["Contacto"].ToString();
                C.VeiculoId = reader["Veiculo_ID"].ToString();
                C.NrFuncionario = reader["Nr_Funcionario"].ToString();
                listBox1.Items.Add(C);
            }

            cn.Close();

            currentCliente = 0;
            //ShowCliente();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
