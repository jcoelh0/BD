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
    public partial class VeiculoRepararForm : Form
    {
        private SqlConnection cn;
        private string selectedName;
        private int current;
        private bool adding;

        public VeiculoRepararForm()
        {
            InitializeComponent();

        }

        public VeiculoRepararForm(SqlConnection cn, string selectedName)
        {
            InitializeComponent();
            this.cn = cn;
            this.selectedName = selectedName;
            loadVeiculosReparar();
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
        

        private void loadVeiculosReparar()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.VEICULO_REPARAR", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                VeiculoReparar C = new VeiculoReparar();
                C.ChassisId = reader["Chassis_ID"].ToString();
                C.Marca = reader["Marca"].ToString();
                C.Modelo = reader["Modelo"].ToString();
                C.Quilometragem = reader["Quilometragem"].ToString();
                C.Estado = reader["Estado"].ToString();
                C.TipoVeiculo = reader["Tipo_Veiculo"].ToString();
                C.PeçaId = reader["Peca_ID"].ToString();
                C.OficinaId = reader["Oficina_ID"].ToString();
                C.Mecanico = reader["Mecanico"].ToString();
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
            txtEstado.ReadOnly = true;
            txtChassisId.ReadOnly = true;
            txtMarca.ReadOnly = true;
            txtModelo.ReadOnly = true;
            txtQuilometragem.ReadOnly = true;
            txtPeçaId.ReadOnly = true;
            txtMecanico.ReadOnly = true;
            txtOficinaId.ReadOnly = true;
        }

        public void UnlockControls()
        {
            comboBox1.Enabled = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEstado.ReadOnly = false;
            txtChassisId.ReadOnly = false;
            txtMarca.ReadOnly = false;
            txtModelo.ReadOnly = false;
            txtQuilometragem.ReadOnly = false;
            txtPeçaId.ReadOnly = false;
            txtOficinaId.ReadOnly = false;
            txtMecanico.ReadOnly = false;
        }

        public void ClearFields()
        {
            comboBox1.ResetText();
            comboBox1.SelectedIndex = -1;
            txtPeçaId.Text = "";
            txtModelo.Text = "";
            txtChassisId.Text = "";
            txtMarca.Text = "";
            txtQuilometragem.Text = "";
            txtEstado.Text = "";
            txtOficinaId.Text = "";
            txtMecanico.Text = "";
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
            VeiculoReparar mec = new VeiculoReparar();
            try
            {
                mec.ChassisId = txtChassisId.Text;
                mec.Marca = txtMarca.Text;
                mec.Modelo = txtModelo.Text;
                mec.Quilometragem = txtQuilometragem.Text;
                mec.Estado = txtEstado.Text;
                mec.TipoVeiculo = comboBox1.Text.Substring(0, 1);
                mec.Mecanico = txtMecanico.Text;
                mec.PeçaId = txtPeçaId.Text;
                mec.OficinaId = txtOficinaId.Text;
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

        private void Update(VeiculoReparar mec)
        {
            int rows = 0;

            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE STAND.VEICULO_REPARAR " + "SET Tipo_Veiculo = @Tipo_Veiculo, " +
                "    Estado = @Estado, " +
                "    Chassis_ID = @Chassis_ID, " +
                "    Marca = @Marca, " +
                "    Modelo = @Modelo, " +
                "    Quilometragem = @Quilometragem, " +
                "    Peca_ID = @Peca_ID, " +
                "    Oficina_ID = @Oficina_ID, " +
                "    Mecanico = @Mecanico " +
                "WHERE Chassis_ID = @Chassis_ID";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Tipo_Veiculo", mec.TipoVeiculo);
            cmd.Parameters.AddWithValue("@Estado", mec.Estado);
            cmd.Parameters.AddWithValue("@Chassis_ID", mec.ChassisId);
            cmd.Parameters.AddWithValue("@Marca", mec.Marca);
            cmd.Parameters.AddWithValue("@Modelo", mec.Modelo);
            cmd.Parameters.AddWithValue("@Quilometragem", mec.Quilometragem);
            cmd.Parameters.AddWithValue("@Peca_ID", mec.PeçaId);
            cmd.Parameters.AddWithValue("@Oficina_ID", mec.OficinaId);
            cmd.Parameters.AddWithValue("@Mecanico", mec.Mecanico);
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

        private void Submit(VeiculoReparar mec)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT STAND.VEICULO_REPARAR (Tipo_Veiculo, Estado, Chassis_ID, Marca, Modelo, Quilometragem, Peca_ID, Oficina_ID, Mecanico) "
       + "VALUES (@Tipo_Veiculo, @Estado, @Chassis_ID, @Marca, @Modelo, @Quilometragem, @Peca_ID, @Oficina_ID, @Mecanico) ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Tipo_Veiculo", mec.TipoVeiculo);
            cmd.Parameters.AddWithValue("@Estado", mec.Estado);
            cmd.Parameters.AddWithValue("@Chassis_ID", mec.ChassisId);
            cmd.Parameters.AddWithValue("@Marca", mec.Marca);
            cmd.Parameters.AddWithValue("@Modelo", mec.Modelo);
            cmd.Parameters.AddWithValue("@Quilometragem", mec.Quilometragem);
            cmd.Parameters.AddWithValue("@Peca_ID", mec.PeçaId);
            cmd.Parameters.AddWithValue("@Oficina_ID", mec.OficinaId);
            cmd.Parameters.AddWithValue("@Mecanico", mec.Mecanico);
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
            VeiculoReparar mec = new VeiculoReparar();
            mec = (VeiculoReparar)listBox1.Items[current];
            txtChassisId.Text = mec.ChassisId;
            txtMarca.Text = mec.Marca;
            txtModelo.Text = mec.Modelo;
            txtQuilometragem.Text = mec.Quilometragem;
            txtEstado.Text = mec.Estado;
            comboBox1.Text = comboBox1.Items[int.Parse(mec.TipoVeiculo)-1].ToString();
            txtMecanico.Text = mec.Mecanico;
            txtPeçaId.Text = mec.PeçaId;
            txtOficinaId.Text = mec.OficinaId;
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
    }
}
