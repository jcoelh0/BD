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
    public partial class VeiculoVendaForm : Form
    {
        private SqlConnection cn;
        private string selectedName;
        private int current;
        private bool adding;

        public VeiculoVendaForm()
        {
            InitializeComponent();

        }

        public VeiculoVendaForm(SqlConnection cn, string selectedName)
        {
            InitializeComponent();
            this.cn = cn;
            this.selectedName = selectedName;
            loadVeiculosVenda();
            ShowButtons(); 
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
                ShowItem();
            }
        }
        

        private void loadVeiculosVenda()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.VEICULO_VENDA", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                VeiculoVenda C = new VeiculoVenda();
                C.ChassisId = reader["Chassis_ID"].ToString();
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
                listBox1.Items.Add(C);
                
    }

            cn.Close();

            current = 0;
            ShowItem();

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

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adding = true;
            ClearFields();
            //UnlockControls();
            HideButtons();
            listBox1.Enabled = false;
        }

        public void HideButtons()
        {
            UnlockControls();
            bttnAdd.Visible = false;
            bttnRmv.Visible = false;
            bttnEdit.Visible = false;
            bttnOK.Visible = true;
            bttnCancel.Visible = true;
        }

        public void ShowButtons()
        {
            LockControls();
            bttnAdd.Visible = true;
            bttnRmv.Visible = true;
            bttnEdit.Visible = true;
            bttnOK.Visible = false;
            bttnCancel.Visible = false;
        }

        public void LockControls()
        {
            comboBox1.Enabled = false;
            txtPaisOrigem.ReadOnly = true;
            txtChassisId.ReadOnly = true;
            txtMarca.ReadOnly = true;
            txtModelo.ReadOnly = true;
            txtQuilometragem.ReadOnly = true;
            txtAnoFabrico.ReadOnly = true;
            txtCombustivel.ReadOnly = true;
            txtTraçao.ReadOnly = true;
            txtPotencia.ReadOnly = true;
            txtStandId.ReadOnly = true;

        }

        public void UnlockControls()
        {
            comboBox1.Enabled = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPaisOrigem.ReadOnly = false;
            txtChassisId.ReadOnly = false;
            txtMarca.ReadOnly = false;
            txtModelo.ReadOnly = false;
            txtQuilometragem.ReadOnly = false;
            txtAnoFabrico.ReadOnly = false;
            txtCombustivel.ReadOnly = false;
            txtTraçao.ReadOnly = false;
            txtPotencia.ReadOnly = false;
            txtStandId.ReadOnly = false;
        }

        public void ClearFields()
        {
            comboBox1.ResetText();
            comboBox1.SelectedIndex = -1;
            txtAnoFabrico.Text = "";
            txtModelo.Text = "";
            txtChassisId.Text = "";
            txtMarca.Text = "";
            txtQuilometragem.Text = "";
            txtPaisOrigem.Text = "";
            txtCombustivel.Text = "";
            txtTraçao.Text = "";
            txtStandId.Text = "";
            txtPotencia.Text = "";
        }

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
            int idx = listBox1.FindString(txtChassisId.Text);
            listBox1.SelectedIndex = idx;
            ShowButtons();
        }

        private bool Save()
        {
            VeiculoVenda mec = new VeiculoVenda();
            try
            {
                mec.ChassisId = txtChassisId.Text;
                mec.Marca = txtMarca.Text;
                mec.Modelo = txtModelo.Text;
                mec.Quilometragem = txtQuilometragem.Text;
                mec.PaisOrigem = txtPaisOrigem.Text;
                mec.TipoVeiculo = comboBox1.Text.Substring(0, 1);
                mec.Traçao = txtTraçao.Text;
                mec.AnoFabrico = txtAnoFabrico.Text;
                mec.Combustivel = txtCombustivel.Text;
                mec.StandId = txtStandId.Text;
                mec.Potencia = txtPotencia.Text;
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

        private void Update(VeiculoVenda mec)
        {
            int rows = 0;

            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE STAND.VEICULO_VENDA " + "SET Tipo_Veiculo = @Tipo_Veiculo, " +
                "    Pais_Origem = @Pais_Origem, " +
                "    Chassis_ID = @Chassis_ID, " +
                "    Marca = @Marca, " +
                "    Modelo = @Modelo, " +
                "    Quilometragem = @Quilometragem, " +
                "    Ano_Fabrico = @Ano_Fabrico, " +
                "    Combustivel = @Combustivel, " +
                "    Tracao = @Tracao, " +
                "    Potencia = @Potencia, " +
                "    Stand_ID = @Stand_ID " +
                "WHERE Chassis_ID = @Chassis_ID";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Tipo_Veiculo", mec.TipoVeiculo);
            cmd.Parameters.AddWithValue("@Pais_Origem", mec.PaisOrigem);
            cmd.Parameters.AddWithValue("@Chassis_ID", mec.ChassisId);
            cmd.Parameters.AddWithValue("@Marca", mec.Marca);
            cmd.Parameters.AddWithValue("@Modelo", mec.Modelo);
            cmd.Parameters.AddWithValue("@Quilometragem", mec.Quilometragem);
            cmd.Parameters.AddWithValue("@Ano_Fabrico", mec.AnoFabrico);
            cmd.Parameters.AddWithValue("@Combustivel", mec.Combustivel);
            cmd.Parameters.AddWithValue("@Tracao", mec.Traçao);
            cmd.Parameters.AddWithValue("@Potencia", mec.Potencia);
            cmd.Parameters.AddWithValue("@Stand_ID", mec.StandId);
            cmd.Connection = cn;

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update veiculo in database. \n ERROR MESSAGE: \n" + ex.Message);
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

        private void Submit(VeiculoVenda mec)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT STAND.VEICULO_VENDA (Tipo_Veiculo, Pais_Origem, Chassis_ID, Marca, Modelo, Quilometragem, Ano_Fabrico, Combustivel, Tracao, Potencia, Stand_ID) "
       + "VALUES (@Tipo_Veiculo, @Pais_Origem, @Chassis_ID, @Marca, @Modelo, @Quilometragem, @Ano_Fabrico, @Combustivel, @Tracao, @Potencia, @Stand_ID) ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Tipo_Veiculo", mec.TipoVeiculo);
            cmd.Parameters.AddWithValue("@Pais_Origem", mec.PaisOrigem);
            cmd.Parameters.AddWithValue("@Chassis_ID", mec.ChassisId);
            cmd.Parameters.AddWithValue("@Marca", mec.Marca);
            cmd.Parameters.AddWithValue("@Modelo", mec.Modelo);
            cmd.Parameters.AddWithValue("@Quilometragem", mec.Quilometragem);
            cmd.Parameters.AddWithValue("@Ano_Fabrico", mec.AnoFabrico);
            cmd.Parameters.AddWithValue("@Combustivel", mec.Combustivel);
            cmd.Parameters.AddWithValue("@Tracao", mec.Traçao);
            cmd.Parameters.AddWithValue("@Potencia", mec.Potencia);
            cmd.Parameters.AddWithValue("@Stand_ID", mec.StandId);
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

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            listBox1.Enabled = true;
            if (listBox1.Items.Count > 0)
            {
                current = listBox1.SelectedIndex;
                if (current < 0)
                    current = 0;
                ShowItem();
            }
            else
            {
                ClearFields();
                LockControls();
            }
            ShowButtons();
        }

        private void ShowItem()
        {
            current = listBox1.SelectedIndex;
            if (listBox1.Items.Count == 0 | current < 0)
                return;
            VeiculoVenda mec = new VeiculoVenda();
            mec = (VeiculoVenda)listBox1.Items[current];
            txtChassisId.Text = mec.ChassisId;
            txtMarca.Text = mec.Marca;
            txtModelo.Text = mec.Modelo;
            txtQuilometragem.Text = mec.Quilometragem;
            txtPaisOrigem.Text = mec.PaisOrigem;
            comboBox1.Text = comboBox1.Items[int.Parse(mec.TipoVeiculo)-1].ToString();
            txtTraçao.Text = mec.Traçao;
            txtAnoFabrico.Text = mec.AnoFabrico;
            txtCombustivel.Text = mec.Combustivel;
            txtPotencia.Text = mec.Potencia;
            txtStandId.Text = mec.StandId;
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            current = listBox1.SelectedIndex;
            if (current < 0)
            {
                MessageBox.Show("Please select a veiculo to edit");
                return;
            }
            adding = false;
            HideButtons();
            listBox1.Enabled = false;
        }

        private void bttnRmv_Click(object sender, EventArgs e)
        {
            current = listBox1.SelectedIndex;
            if (current < 0)
            {
                MessageBox.Show("Please select a veiculo to remove");
                return;
            }
            adding = false;
            HideButtons();
            listBox1.Enabled = false;
        }

        private void bttnSrch_Click(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new LoginForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
