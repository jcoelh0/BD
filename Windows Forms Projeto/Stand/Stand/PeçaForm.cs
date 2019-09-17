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
    public partial class PeçaForm : Form
    {
        private SqlConnection cn;
        private string selectedName;
        private int current;
        private bool adding;

        public PeçaForm()
        {
            InitializeComponent();

        }

        public PeçaForm(SqlConnection cn, string selectedName)
        {
            InitializeComponent();
            this.cn = cn;
            this.selectedName = selectedName;
            loadPeças();
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

        private void loadPeças()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.PECAS", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                Peça C = new Peça();
                C.PeçaId = reader["Peca_ID"].ToString();
                C.Fabricante = reader["Fabricante"].ToString();
                C.Disponibilidade = reader["Disponibilidade"].ToString();
                C.TipoPeça = reader["Tipo_Peca"].ToString();
                C.Nome = reader["Nome"].ToString();
                listBox1.Items.Add(C);
            }

            cn.Close();

            current = 0;
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
            txtID.ReadOnly = true;
            txtFabricante.ReadOnly = true;
            txtDisponibiblidade.ReadOnly = true;
            comboBox1.Enabled = false;
            txtNome.ReadOnly = true;
        }

        public void UnlockControls()
        {
            txtID.ReadOnly = false;
            txtFabricante.ReadOnly = false;
            txtDisponibiblidade.ReadOnly = false;
            comboBox1.Enabled = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNome.ReadOnly = false;
        }

        public void ClearFields()
        {
            txtID.Text = "";
            txtFabricante.Text = "";
            txtDisponibiblidade.Text = "";
            comboBox1.ResetText();
            comboBox1.SelectedIndex = -1;
            txtNome.Text = "";
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
            int idx = listBox1.FindString(txtID.Text);
            listBox1.SelectedIndex = idx;
            ShowButtons();
        }

        private bool Save()
        {
            Peça mec = new Peça();
            try
            {
                mec.PeçaId = txtID.Text;
                mec.Nome = txtNome.Text;
                mec.Disponibilidade = txtDisponibiblidade.Text;
                mec.TipoPeça = comboBox1.Text.Substring(0, 3);
                mec.Fabricante = txtFabricante.Text;

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

        private void Update(Peça mec)
        {
            int rows = 0;

            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE STAND.PECAS " + "SET Fabricante = @Fabricante, " + "    Disponibilidade = @Disponibilidade, " + "    Nome = @Nome " + "WHERE Peca_ID = @Peca_ID";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Peca_ID", mec.PeçaId);
            cmd.Parameters.AddWithValue("@Fabricante", mec.Fabricante);
            cmd.Parameters.AddWithValue("@Disponibilidade", mec.Disponibilidade);
            cmd.Parameters.AddWithValue("@Tipo_peca", mec.TipoPeça);
            cmd.Parameters.AddWithValue("@Nome", mec.Nome);
            cmd.Connection = cn;

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update peça in database. \n ERROR MESSAGE: \n" + ex.Message);
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

        private void Submit(Peça mec)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT STAND.PECAS (Fabricante, Disponibilidade, Tipo_peca, Nome) "
                + "VALUES (@Fabricante, @Disponibilidade, @Tipo_peca, @Nome) ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Fabricante", mec.Fabricante);
            cmd.Parameters.AddWithValue("@Disponibilidade", mec.Disponibilidade);
            cmd.Parameters.AddWithValue("@Tipo_peca", mec.TipoPeça);
            cmd.Parameters.AddWithValue("@Nome", mec.Nome);
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
            Peça mec = new Peça();
            mec = (Peça)listBox1.Items[current];
            int i = 0;
            foreach (object item in comboBox1.Items)
            {
                i++;
                if (item.ToString().Contains(mec.TipoPeça))
                    comboBox1.Text = comboBox1.Items[i].ToString();
            }

            txtID.Text = mec.PeçaId;
            txtFabricante.Text = mec.Fabricante;
            txtDisponibiblidade.Text = mec.Disponibilidade;
            
            txtNome.Text = mec.Nome;
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            current = listBox1.SelectedIndex;
            if (current < 0)
            {
                MessageBox.Show("Please select a peça to edit");
                return;
            }
            adding = false;
            txtID.Enabled = false;
            HideButtons();
            listBox1.Enabled = false;
        }

        private void bttnRmv_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                try
                {
                    Remove(((Peça)listBox1.SelectedItem).PeçaId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (current == listBox1.Items.Count)
                    current = listBox1.Items.Count - 1;
                if (current == -1)
                {
                    ClearFields();
                    MessageBox.Show("There are no more peças");
                }
                else
                {
                    ShowItem();
                }
            }
        }

        private void Remove(string Peca_ID)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM STAND.PECAS WHERE Peca_ID = @Peca_ID ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Peca_ID", Peca_ID);
            cmd.Connection = cn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete peça in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void bttnSrch_Click(object sender, EventArgs e)
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
