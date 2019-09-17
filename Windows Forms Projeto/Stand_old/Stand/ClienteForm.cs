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
    public partial class ClienteForm : Form
    {
        private SqlConnection cn;
        private string selectedName;
        private int current;
        private bool adding;

        public ClienteForm()
        {
            InitializeComponent();

        }

        public ClienteForm(SqlConnection cn, string selectedName)
        {
            InitializeComponent();
            this.cn = cn;
            this.selectedName = selectedName;
            loadClientes();
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

        private void loadClientes()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND.AllClients()", cn);
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
            txtNome.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtNIF.ReadOnly = true;
            txtContacto.ReadOnly = true;
            //txtVeiculoID.ReadOnly = true;
        }

        public void UnlockControls()
        {
            txtID.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtNIF.ReadOnly = false;
            txtContacto.ReadOnly = false;
            //txtVeiculoID.ReadOnly = false;
        }

        public void ClearFields()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtContacto.Text = "";
            txtAddress.Text = "";
            txtNIF.Text = "";
            //txtVeiculoID.Text = "";
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
            Cliente mec = new Cliente();
            try
            {
                mec.NrCliente = txtID.Text;
                mec.Contacto = txtContacto.Text;
                mec.Morada = txtAddress.Text;
                mec.Nif = txtNIF.Text;
                mec.Nome = txtNome.Text;
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
                loadClientes();
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

            cmd.CommandText = "UPDATE STAND.CLIENTE " + "SET Contacto = @Contacto, " + "    Morada = @Morada, " + "    Nome = @Nome, "  + "   NIF = @NIF " + "WHERE Nr_Cliente= @Nr_Funcionario";
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

            SqlCommand cmd = new SqlCommand(" select StandAllCi()");

            cmd.CommandText = "INSERT STAND.CLIENTE (Contacto, Morada, NIF, Nome) " 
                + "VALUES (@Contacto, @Morada, @NIF, @Nome) ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Contacto", mec.Contacto);
            cmd.Parameters.AddWithValue("@Morada", mec.Morada);
            cmd.Parameters.AddWithValue("@NIF", mec.Nif);
            cmd.Parameters.AddWithValue("@Nome", mec.Nome);
            //cmd.Parameters.AddWithValue("@Nr_Funcionario", mec.NrCliente);
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
            Cliente mec = new Cliente();
            mec = (Cliente)listBox1.Items[current];
            txtID.Text = mec.NrCliente;
            txtNome.Text = mec.Nome;
            txtContacto.Text = mec.Contacto;
            txtAddress.Text = mec.Morada;
            txtNIF.Text = mec.Nif;
            //txtVeiculoID.Text = mec.VeiculoId;
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            current = listBox1.SelectedIndex;
            if (current < 0)
            {
                MessageBox.Show("Please select a client to edit");
                return;
            }
            adding = false;
            txtID.Enabled = false;
            HideButtons();
            listBox1.Enabled = false;
        }

        private void bttnRmv_Click(object sender, EventArgs e)
        {
            current = listBox1.SelectedIndex;
            if (current < 0)
            {
                MessageBox.Show("Please select a client to remove");
                return;
            }
            if (listBox1.SelectedIndex > -1)
            {
                try
                {
                    RemoveItem(((Cliente)listBox1.SelectedItem).NrCliente);
                    MessageBox.Show("Deletion successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (current== listBox1.Items.Count)
                    current = listBox1.Items.Count - 1;
                if (current == -1)
                {
                    ClearFields();
                    MessageBox.Show("There are no more contacts");
                }
                else
                {
                    ShowItem();
                }
            }
            loadClientes();
        }


        private void RemoveItem(string Cliente_ID)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            //cmd.CommandText = "DELETE STAND.CLIENTE WHERE Nr_Cliente=@Cliente_ID ";
            cmd.CommandText = "exec sp_deleteClient @Cliente_ID";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Cliente_ID", Cliente_ID);
            cmd.Connection = cn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
