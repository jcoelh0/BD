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
    public partial class LoginForm : Form
    {

        private SqlConnection cn;
        private string id;
        private string pass;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
            //loadDataAutomatically();
        }

        public SqlConnection getSGBDConnection()
        {
            SqlConnection CN = new SqlConnection("Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;" + 
                "Initial Catalog = p1g10" + "; uid = " + id + ";" + "password = " + pass);

            return CN;
            
        }

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a table to connect.");
                return;
            }
            else if(listView1.SelectedIndices[0] == 0) //mecanico
            {
                string selectedName = listView1.SelectedItems[0].Text;
                id = textBox1.Text;
                pass = textBox2.Text;
                cn = getSGBDConnection();
                this.Hide();
                var form2 = new MecanicoForm(cn, selectedName);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else if (listView1.FocusedItem.Index == 1) //cliente
            {
                string selectedName = listView1.SelectedItems[0].Text;
                id = textBox1.Text;
                pass = textBox2.Text;
                cn = getSGBDConnection();
                this.Hide();
                var form2 = new ClienteForm(cn, selectedName);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else if (listView1.FocusedItem.Index == 2) //veiculos_reparar
            {
                string selectedName = listView1.SelectedItems[0].Text;
                id = textBox1.Text;
                pass = textBox2.Text;
                cn = getSGBDConnection();
                this.Hide();
                var form2 = new VeiculoRepararForm(cn, selectedName);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else if (listView1.FocusedItem.Index == 3) //veiculo_venda
            {
                string selectedName = listView1.SelectedItems[0].Text;
                id = textBox1.Text;
                pass = textBox2.Text;
                cn = getSGBDConnection();
                this.Hide();
                var form2 = new VeiculoVendaForm(cn, selectedName);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else if (listView1.FocusedItem.Index == 4) //peças
            {
                string selectedName = listView1.SelectedItems[0].Text;
                id = textBox1.Text;
                pass = textBox2.Text;
                cn = getSGBDConnection();
                this.Hide();
                var form2 = new PeçaForm(cn, selectedName);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void clientBttn_Click(object sender, EventArgs e)
        {
            
            id = textBox1.Text;
            pass = textBox2.Text;
            cn = getSGBDConnection();
            this.Hide();
            var form2 = new ClientSideForm(cn);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void bttnMecanico_Click(object sender, EventArgs e)
        {
            id = textBox1.Text;
            pass = textBox2.Text;
            cn = getSGBDConnection();
            this.Hide();
            var form2 = new MecanicoSideForm(cn);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
