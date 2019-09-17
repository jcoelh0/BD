using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Stand
{
    public partial class MecanicoSideForm : Form
    {
        private SqlConnection cn;
        private int current;

        public MecanicoSideForm(SqlConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
            comboBoxMec.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
            label1.Visible = false;
            loadMechanics();
            //ShowButtons(); 
        }


        private void loadCarsRepaired()
        {

            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.RepairedVehicles();", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                VeiculoReparar C = new VeiculoReparar();
                C.ChassisId = reader["Chassis_ID"].ToString();
                C.Marca = reader["Marca"].ToString();
                C.Modelo = reader["Modelo"].ToString();
                C.Quilometragem = reader["Modelo"].ToString();
                C.TipoVeiculo = reader["Tipo_Veiculo"].ToString();
                listBox1.Items.Add(C);
            }
            reader.Close();
            cn.Close();
            current = 0;
        }

        private bool verifySGBDConnection()
        {
            if (cn == null) {
                var instance = new LoginForm();
                //LoginForm lg = new LoginForm();
                cn = instance.getSGBDConnection();
            }
            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                current = listBox1.SelectedIndex;


                
                //ShowItem();
            }

        }

        private void loadCarsToRepair()
        {

            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.ToRepairVehicles();", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            //listBox1.Items.Clear();

            while (reader.Read())
            {
                VeiculoReparar C = new VeiculoReparar();
                C.ChassisId = reader["Chassis_ID"].ToString();
                C.Marca = reader["Marca"].ToString();
                C.Modelo = reader["Modelo"].ToString();
                C.Quilometragem = reader["Modelo"].ToString();
                C.TipoVeiculo = reader["Tipo_Veiculo"].ToString();
                //C.PeçaId = reader["Peca_ID"].ToString();
                //C.OficinaId = reader["Oficina_ID"].ToString();
                //C.Mecanico = reader["Mecanico"].ToString();
                listBox1.Items.Add(C);
            }
            reader.Close();
            cn.Close();
            current = 0;
        }

        private void loadMechanics()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.AllMechanics()", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                Mecanico C = new Mecanico();
                C.Nome = reader["Nome"].ToString();
                C.Morada = reader["Morada"].ToString();
                C.Nif = reader["NIF"].ToString();
                C.Contacto = reader["Contacto"].ToString();
                C.VeiculoId = reader["Oficina_ID"].ToString();
                C.NrFuncionario = reader["Nr_Funcionario"].ToString();
                comboBoxMec.Items.Add(C);
            }

            cn.Close();
        }

        private void loadClientes()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.AllClients()", cn);
            SqlDataReader reader = cmd.ExecuteReader();
           //comboBoxOptions.Items.Clear();

            while (reader.Read())
            {
                Cliente C = new Cliente();
                C.Nome = reader["Nome"].ToString();
                C.Morada = reader["Morada"].ToString();
                C.Nif = reader["NIF"].ToString();
                C.Contacto = reader["Contacto"].ToString();
                C.NrCliente = reader["Nr_Cliente"].ToString();
            }

            cn.Close();
            reader.Close();
            current = 0;
            //ShowCliente();

        }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        private void ShowItem()
        {
            current = listBox1.SelectedIndex;
            if (listBox1.Items.Count == 0 | current < 0)
                return;
            Cliente mec = new Cliente();
            mec = (Cliente)listBox1.Items[current];
            //txtID.Text = mec.NrCliente;
            /*txtNome.Text = mec.Nome;
            txtContacto.Text = mec.Contacto;
            txtAddress.Text = mec.Morada;
            txtNIF.Text = mec.Nif;*/
            //txtVeiculoID.Text = mec.VeiculoId;
        }
        
        
        

        //private void comboBoxMecClient_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    current = comboBoxMecClient.SelectedIndex;

        //    String resultString = Regex.Match(comboBoxMecClient.Items[current].ToString(), @"\d+").Value;

            
            


        //    if (!verifySGBDConnection())
        //        return;

        //    SqlCommand cmd = new SqlCommand();

            

        //    cmd.CommandText = "SELECT * FROM STAND.AllClients() WHERE Nr_Cliente=@Cliente_ID;";
        //    cmd.Parameters.Clear();
        //    cmd.Parameters.AddWithValue("@Cliente_ID", resultString);
        //    cmd.Connection = cn;

        //    SqlDataReader reader = cmd.ExecuteReader();
        //    Cliente C = new Cliente();
        //    while (reader.Read())
        //    {
                
        //        C.Nome = reader["Nome"].ToString();
        //        C.Morada = reader["Morada"].ToString();
        //        C.Nif = reader["NIF"].ToString();
        //        C.Contacto = reader["Contacto"].ToString();
        //        C.NrCliente = reader["Nr_Cliente"].ToString();
        //    }

        //    reader.Close();
        //    loadCarsToRepair(C);

            
        //}

        private void bttnReparar_Click(object sender, EventArgs e)
        {
            cn.Open();

            current = listBox1.SelectedIndex;
            if (current < 0)
            {
                MessageBox.Show("Please select a car to be repaired");
                return;
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "exec sp_repairVehicle @Chassis_ID, @Nr_Funcionario";

            cmd.Connection = cn;
            string NrFunc = comboBoxMec.GetItemText(comboBoxMec.SelectedItem);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nr_Funcionario", NrFunc.Split('\t')[0]);
            cmd.Parameters.AddWithValue("@Chassis_ID", ((VeiculoReparar)listBox1.Items[current]).ChassisId);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            MessageBox.Show("Carro reparado com sucesso!");
            listBox1.Items.Clear();
            ShowReparar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new LoginForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            current = listBox1.SelectedIndex;
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                ShowReparar();
            }
            else
            {
                listBox1.Items.Clear();
                ShowEntregar();
            }
        }

        private void ShowReparar()
        {
            comboBoxMec.Visible = true;
            label1.Visible = true;
            bttnEntregar.Visible = false;
            labelEntregar.Visible = false;
            bttnReparar.Visible = true;
            loadCarsToRepair();
        }

        private void ShowEntregar()
        {
            comboBoxMec.Visible = false;
            bttnEntregar.Visible = true;
            label1.Visible = false;
            labelEntregar.Visible = true;
            bttnReparar.Visible = false;
            loadCarsRepaired();
        }
        

        private void bttnEntregar_Click(object sender, EventArgs e)
        {
            cn.Open();

            current = listBox1.SelectedIndex;
            if (current < 0)
            {
                MessageBox.Show("Please select a car to be delivered");
                return;
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "exec sp_deliverVehicle @Chassis_ID";

            cmd.Connection = cn;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Chassis_ID", ((VeiculoReparar)listBox1.Items[current]).ChassisId);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            MessageBox.Show("Carro entregue com sucesso!");
            listBox1.Items.Clear();
            ShowEntregar();
        }
    }
}
