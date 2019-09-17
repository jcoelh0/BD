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
            comboBoxMecClient.DropDownStyle = ComboBoxStyle.DropDownList;
            
            //comboBoxOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            loadClientes();
            //ShowButtons(); 
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

       
        private void loadCarsToRepair(Cliente mec)
        {

            //cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.ClientVehicles(@Cliente_ID);", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Cliente_ID", mec.NrCliente);

            SqlDataReader reader = cmd.ExecuteReader();

            //listBoxCars.Items.Clear();

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


        private void loadClientes()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.CLIENTE", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            comboBoxMecClient.Items.Clear();
            //comboBoxOptions.Items.Clear();

            while (reader.Read())
            {
                Cliente C = new Cliente();
                C.Nome = reader["Nome"].ToString();
                C.Morada = reader["Morada"].ToString();
                C.Nif = reader["NIF"].ToString();
                C.Contacto = reader["Contacto"].ToString();
                C.NrCliente = reader["Nr_Cliente"].ToString();
                comboBoxMecClient.Items.Add(C.ToString());
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
        
        
        

        private void comboBoxMecClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            current = comboBoxMecClient.SelectedIndex;

            String resultString = Regex.Match(comboBoxMecClient.Items[current].ToString(), @"\d+").Value;

            
            


            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();

            

            cmd.CommandText = "SELECT * FROM STAND.AllClients() WHERE Nr_Cliente=@Cliente_ID;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Cliente_ID", resultString);
            cmd.Connection = cn;

            SqlDataReader reader = cmd.ExecuteReader();
            Cliente C = new Cliente();
            while (reader.Read())
            {
                
                C.Nome = reader["Nome"].ToString();
                C.Morada = reader["Morada"].ToString();
                C.Nif = reader["NIF"].ToString();
                C.Contacto = reader["Contacto"].ToString();
                C.NrCliente = reader["Nr_Cliente"].ToString();
            }

            reader.Close();
            loadCarsToRepair(C);

            
        }

        private void bttnReparar_Click(object sender, EventArgs e)
        {
            //if (!verifySGBDConnection())
            //    return;
            cn.Open();

            current = listBox1.SelectedIndex;
            if (current < 0)
            {
                MessageBox.Show("Please select a car to be delivered");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please insert your employee number.");
                return;
            }

            String NrFuncionario = textBox1.Text;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "exec sp_deliverVehicle @Chassis_ID, @Nr_Funcionario";

            cmd.Connection = cn;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nr_Funcionario", NrFuncionario);
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

           
        }

    }
}
