using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stand
{
    public partial class ClientSideForm : Form
    {
        private SqlConnection cn;
        private int current;
        private bool adding;

        public ClientSideForm(SqlConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
            comboBoxMecClient.DropDownStyle = ComboBoxStyle.DropDownList;
            bttnComprar.Visible = false;
            bttnReparar.Visible = false;

            loadClientes();
            //comboBoxOptions.DropDownStyle = ComboBoxStyle.DropDownList;

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
                if (comboBoxMecClient.SelectedIndex == 0)
                {
                    loadCars((Cliente)listBox1.Items[current]); // mostrar todos carros listBoxCars
                }
                else
                {
                    loadGarageCars((Cliente)listBox1.Items[current]);
                }
                

                //ShowItem();
            }

        }

        private void loadCars(Cliente mec)
        {
            
            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM AllStandVehicles", cn);
            //cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@Cliente_ID", mec.NrCliente);

            SqlDataReader reader = cmd.ExecuteReader();

            listBoxCars.Items.Clear();

            while (reader.Read())
            {
                VeiculoCliente C = new VeiculoCliente();
                C.ChassisId = reader["Chassis_ID"].ToString();
                C.Marca = reader["Marca"].ToString();
                C.Modelo = reader["Modelo"].ToString();
                C.TipoVeiculo = reader["Tipo_Veiculo"].ToString();
                //C.ClienteId = reader["Cliente_ID"].ToString();
                listBoxCars.Items.Add(C);
            }

            cn.Close();
            current = 0;
        }

        private void loadGarageCars(Cliente mec)
        {
            if (comboBoxMecClient.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma opção");
                return;
            }
            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM AllClientVehicles WHERE Cliente_ID=@Cliente_ID", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Cliente_ID", mec.NrCliente);

            SqlDataReader reader = cmd.ExecuteReader();

            listBoxCars.Items.Clear();

            while (reader.Read())
            {
                VeiculoCliente C = new VeiculoCliente();
                C.ChassisId = reader["Chassis_ID"].ToString();
                C.Marca = reader["Marca"].ToString();
                C.Modelo = reader["Modelo"].ToString();
                C.TipoVeiculo = reader["Tipo_Veiculo"].ToString();
                C.ClienteId = reader["Cliente_ID"].ToString();
                //C.PeçaId = reader["Peca_ID"].ToString();
                //C.OficinaId = reader["Oficina_ID"].ToString();
                listBoxCars.Items.Add(C);
            }

            cn.Close();
            current = 0;
        }


        private void loadClientes()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.CLIENTE", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();
            //comboBoxOptions.Items.Clear();

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

            current = 0;
            //ShowCliente();

        }

        private void loadMecanicos()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.MECANICO", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();
            //comboBoxOptions.Items.Clear();
            while (reader.Read())
            {
                Mecanico C = new Mecanico();
                C.Nome = reader["Nome"].ToString();
                C.Morada = reader["Morada"].ToString();
                C.Nif = reader["NIF"].ToString();
                C.Contacto = reader["Contacto"].ToString();
                C.VeiculoId = reader["Oficina_ID"].ToString();
                C.NrFuncionario = reader["Nr_Funcionario"].ToString();
                listBox1.Items.Add(C);
            }

            cn.Close();

            current = 0;
            ShowItem();

        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        

        

        

        public void ShowComprar()
        {
            //UnlockControls();
            bttnComprar.Visible = true;
            //bttnRmv.Visible = false;
            bttnReparar.Visible = false;
            //bttnOK.Visible = true;
            //bttnCancel.Visible = true;
        }

        public void ShowReparar()
        {
            LockControls();
            bttnComprar.Visible = false;
            bttnReparar.Visible = true;
        }

        public void LockControls()
        {
            //txtID.ReadOnly = true;
            //txtNome.ReadOnly = true;
            //txtAddress.ReadOnly = true;
            //txtNIF.ReadOnly = true;
            //txtContacto.ReadOnly = true;
            //txtVeiculoID.ReadOnly = true;
        }
        /*
        public void UnlockControls()
        {
            //txtID.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtNIF.ReadOnly = false;
            txtContacto.ReadOnly = false;
            //txtVeiculoID.ReadOnly = false;
        }
        */
        /*
        public void ClearFields()
        {
            //txtID.Text = "";
            txtNome.Text = "";
            txtContacto.Text = "";
            txtAddress.Text = "";
            txtNIF.Text = "";
            //txtVeiculoID.Text = "";
        }
        */
        private void bttnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listBox1.Enabled = true;
            //int idx = listBox1.FindString(txtID.Text);
            //listBox1.SelectedIndex = idx;
            //ShowButtons();
        }

        private bool Save()
        {
            Cliente mec = new Cliente();
            try
            {
                //mec.NrCliente = txtID.Text;
                /*mec.Contacto = txtContacto.Text;
                mec.Morada = txtAddress.Text;
                mec.Nif = txtNIF.Text;
                mec.Nome = txtNome.Text;*/
                //mec.VeiculoId = txtVeiculoID.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            if (adding)
            {
                Submit(mec);
                listBox1.Items.Add(mec);
            }
            else
            {
                Update(mec);
                listBox1.Items[current] = mec;
            }
            return true;
        }

        private void Update(Cliente mec)
        {
            int rows = 0;

            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE STAND.MECANICO " + "SET Contacto = @Contacto, " + "    Morada = @Morada, " + "    Nome = @Nome, " + "    Nr_Funcionario = @Nr_Funcionario, " + "   NIF = @NIF " + "WHERE Nr_Funcionario = @Nr_Funcionario";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Contacto", mec.Contacto);
            cmd.Parameters.AddWithValue("@Morada", mec.Morada);
            cmd.Parameters.AddWithValue("@NIF", mec.Nif);
            cmd.Parameters.AddWithValue("@Nome", mec.Nome);
            cmd.Parameters.AddWithValue("@Nr_Funcionario", mec.NrCliente);
            cmd.Connection = cn;

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update mechanic in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                if (rows == 1)
                    MessageBox.Show("Update OK");
                else
                    MessageBox.Show("Update NOT OK");

                cn.Close();
            }
        }

        private void Submit(Cliente mec)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT STAND.MECANICO (Contacto, Morada, NIF, Nome, Nr_Funcionario) " 
                + "VALUES (@Contacto, @Morada, @NIF, @Nome, @Nr_Funcionario) ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Contacto", mec.Contacto);
            cmd.Parameters.AddWithValue("@Morada", mec.Morada);
            cmd.Parameters.AddWithValue("@NIF", mec.Nif);
            cmd.Parameters.AddWithValue("@Nome", mec.Nome);
            cmd.Parameters.AddWithValue("@Nr_Funcionario", mec.NrCliente);
            cmd.Connection = cn;

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
            current = listBoxCars.SelectedIndex;
            if (comboBoxMecClient.SelectedIndex == 0)
            {
                
                ShowComprar();
            }
            else
            {
                listBoxCars.Items.Clear();
                ShowReparar();
            }
        }

        private void bttnReparar_Click(object sender, EventArgs e)
        {

            if (!verifySGBDConnection())
                return;


            current = listBoxCars.SelectedIndex;
            if (current < 0)
            {
                MessageBox.Show("Please select a car to be repaired");
                return;
            }

            //exec sp_addVehicleToRepair 98124, "Audi", "A3", 231954, 0, "1994", 1, 4, null, null

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "exec sp_addVehicleToRepair @Chassis_ID, @Marca, @Modelo, 231954, 1, 1974, @Tipo_Veiculo, 4, null, null";

            //@Chassis_ID INT, @Marca VARCHAR(40), @Modelo VARCHAR(30), @Quilometragem INT, @Estado BIT, @Ano_Fabrico CHAR(4),  @Tipo_Veiculo INT, @Peca_ID INT, @Oficina_ID INT, @Mecanico INT
            //98124, "Audi", "A3", 231954, 0, "1994", 1, 4, null, null

            VeiculoCliente mec = new VeiculoCliente();
            mec = (VeiculoCliente)listBoxCars.Items[current];
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Tipo_Veiculo", mec.TipoVeiculo);
            //cmd.Parameters.AddWithValue("@AnoFabrico", mec.AnoFabrico);
            //cmd.Parameters.AddWithValue("@Estado", mec.Estado);
            cmd.Parameters.AddWithValue("@Chassis_ID", mec.ChassisId);
            cmd.Parameters.AddWithValue("@Marca", mec.Marca);
            cmd.Parameters.AddWithValue("@Modelo", mec.Modelo);
            //cmd.Parameters.AddWithValue("@Quilometragem", mec.Quilometragem);
           // cmd.Parameters.AddWithValue("@Peca_ID", mec.PeçaId);
            //cmd.Parameters.AddWithValue("@Oficina_ID", mec.OficinaId);
            //cmd.Parameters.AddWithValue("@Mecanico", mec.Mecanico);
            
            cmd.Connection = cn;

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
            MessageBox.Show("Carro na oficina para reparar com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e) //COMPRAR
        {
            current = listBoxCars.SelectedIndex;
            if (current < 0)
            {
                MessageBox.Show("Please select a car to purchase");
                return;
            }
            cn.Open();
            //exec sp_buyVehicle 15000, 918, 21415, 5
            //@Preço INT, @Stand_ID INT, @Veiculo_ID INT, @Cliente INT

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "exec sp_buyVehicle 15000, 918, @Chassis_ID, @Cliente_ID";


            VeiculoCliente mec = new VeiculoCliente();
            mec = (VeiculoCliente)listBoxCars.Items[current];
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Tipo_Veiculo", mec.TipoVeiculo);
            //cmd.Parameters.AddWithValue("@AnoFabrico", mec.AnoFabrico);
            cmd.Parameters.AddWithValue("@Cliente_ID", mec.ClienteId);
            cmd.Parameters.AddWithValue("@Chassis_ID", mec.ChassisId);
            cmd.Parameters.AddWithValue("@Marca", mec.Marca);
            cmd.Parameters.AddWithValue("@Modelo", mec.Modelo);

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
            MessageBox.Show("Carro comprado com sucesso!");

        }
        /*
private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
{
   if (!verifySGBDConnection())
       return;


   //ShowItem();
   listBoxCars.Items.Clear();
   if (comboBoxOptions.SelectedIndex == 0) { //Veículos em Stock
       cn.Close();
   }
   else if (comboBoxOptions.SelectedIndex == 1) { //Seus Veículos
       SqlCommand cmd = new SqlCommand("SELECT * FROM AllStandVehicles;", cn);
       SqlDataReader reader = cmd.ExecuteReader();


       while (reader.Read())
       {
           VeiculoVenda C = new VeiculoVenda();
           C.Marca = reader["Marca"].ToString();
           C.Modelo = reader["Modelo"].ToString();
           C.Quilometragem = reader["Quilometragem"].ToString();
           C.PaisOrigem = reader["Pais_Origem"].ToString();
           C.AnoFabrico = reader["Ano_Fabrico"].ToString();
           C.Combustivel = reader["Combustivel"].ToString();
           C.Traçao = reader["Tracao"].ToString();
           C.TipoVeiculo = reader["Tipo_Veiculo"].ToString();
           C.Potencia = reader["Potencia"].ToString();
           C.StandId = reader["Stand_ID"].ToString();

           listBoxCars.Items.Add(C);
       }
       reader.Close();

       current = 0;

       cn.Close();
   }
   else if (comboBoxOptions.SelectedIndex == 2) { //Mecânicos Disponíveis
       //cn.Open();
       SqlCommand cmd = new SqlCommand("SELECT * FROM AvailableMechanics;", cn);
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
           listBoxCars.Items.Add(C);
       }
       reader.Close();

       current = 0;
       cn.Close();
   }
}
*/

    }
}
