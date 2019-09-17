namespace Stand
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Mecanico");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Cliente");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Veículo_Reparar");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Veículo_Venda");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Peças");
            this.listView1 = new System.Windows.Forms.ListView();
            this.connectBttn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.clientBttn = new System.Windows.Forms.Button();
            this.bttnMecanico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.FullRowSelect = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(256, 114);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(136, 107);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // connectBttn
            // 
            this.connectBttn.Location = new System.Drawing.Point(420, 169);
            this.connectBttn.Name = "connectBttn";
            this.connectBttn.Size = new System.Drawing.Size(100, 52);
            this.connectBttn.TabIndex = 1;
            this.connectBttn.Text = "Connect";
            this.connectBttn.UseVisualStyleBackColor = true;
            this.connectBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "P1G10";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "1362919921@Bd1";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(55, 94);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 17);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(55, 179);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Location = new System.Drawing.Point(253, 94);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(48, 17);
            this.tableLabel.TabIndex = 6;
            this.tableLabel.Text = "Table:";
            // 
            // clientBttn
            // 
            this.clientBttn.Location = new System.Drawing.Point(55, 12);
            this.clientBttn.Name = "clientBttn";
            this.clientBttn.Size = new System.Drawing.Size(100, 49);
            this.clientBttn.TabIndex = 7;
            this.clientBttn.Text = "Client Side";
            this.clientBttn.UseVisualStyleBackColor = true;
            this.clientBttn.Click += new System.EventHandler(this.clientBttn_Click);
            // 
            // bttnMecanico
            // 
            this.bttnMecanico.Location = new System.Drawing.Point(201, 12);
            this.bttnMecanico.Name = "bttnMecanico";
            this.bttnMecanico.Size = new System.Drawing.Size(116, 49);
            this.bttnMecanico.TabIndex = 8;
            this.bttnMecanico.Text = "Mecanico Side";
            this.bttnMecanico.UseVisualStyleBackColor = true;
            this.bttnMecanico.Click += new System.EventHandler(this.bttnMecanico_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 265);
            this.Controls.Add(this.bttnMecanico);
            this.Controls.Add(this.clientBttn);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.connectBttn);
            this.Controls.Add(this.listView1);
            this.Name = "LoginForm";
            this.Text = "Login Menu";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button connectBttn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Button clientBttn;
        private System.Windows.Forms.Button bttnMecanico;
    }
}

