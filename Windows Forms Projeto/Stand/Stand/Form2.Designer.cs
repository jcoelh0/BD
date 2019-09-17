namespace Stand
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 324);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 378);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 33);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(757, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 69);
            this.button4.TabIndex = 8;
            this.button4.Text = "Remover";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 69);
            this.button2.TabIndex = 9;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(559, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 69);
            this.button3.TabIndex = 10;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtID.Location = new System.Drawing.Point(369, 48);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(225, 26);
            this.txtID.TabIndex = 160;
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label11.Location = new System.Drawing.Point(365, 21);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(115, 20);
            this.Label11.TabIndex = 159;
            this.Label11.Text = "NrFuncionário";
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountry.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtCountry.Location = new System.Drawing.Point(369, 335);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(212, 26);
            this.txtCountry.TabIndex = 158;
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label4.Location = new System.Drawing.Point(365, 307);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(115, 20);
            this.Label4.TabIndex = 157;
            this.Label4.Text = "Country";
            // 
            // Label10
            // 
            this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label10.Location = new System.Drawing.Point(717, 189);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(43, 20);
            this.Label10.TabIndex = 155;
            this.Label10.Text = "&ZIP";
            // 
            // txtZIP
            // 
            this.txtZIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZIP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtZIP.Location = new System.Drawing.Point(719, 211);
            this.txtZIP.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.ReadOnly = true;
            this.txtZIP.Size = new System.Drawing.Size(73, 26);
            this.txtZIP.TabIndex = 156;
            // 
            // Label9
            // 
            this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label9.Location = new System.Drawing.Point(599, 194);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(59, 20);
            this.Label9.TabIndex = 149;
            this.Label9.Text = "&State";
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label7.Location = new System.Drawing.Point(578, 250);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(96, 20);
            this.Label7.TabIndex = 153;
            this.Label7.Text = "&Fax";
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label6.Location = new System.Drawing.Point(365, 250);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(115, 20);
            this.Label6.TabIndex = 151;
            this.Label6.Text = "Contacto";
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label5.Location = new System.Drawing.Point(365, 194);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 20);
            this.Label5.TabIndex = 147;
            this.Label5.Text = "NIF";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(365, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 145;
            this.label8.Text = "Morada";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.Location = new System.Drawing.Point(365, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 143;
            this.label12.Text = "Nome";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label13.Location = new System.Drawing.Point(599, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 141;
            this.label13.Text = "NrCliente";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtFax
            // 
            this.txtFax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFax.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtFax.Location = new System.Drawing.Point(581, 272);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(244, 26);
            this.txtFax.TabIndex = 154;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtTel.Location = new System.Drawing.Point(369, 272);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(159, 26);
            this.txtTel.TabIndex = 152;
            // 
            // txtState
            // 
            this.txtState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtState.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtState.Location = new System.Drawing.Point(602, 216);
            this.txtState.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(52, 26);
            this.txtState.TabIndex = 150;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtCity.Location = new System.Drawing.Point(369, 216);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(193, 26);
            this.txtCity.TabIndex = 148;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtAddress1.Location = new System.Drawing.Point(369, 154);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.ReadOnly = true;
            this.txtAddress1.Size = new System.Drawing.Size(457, 26);
            this.txtAddress1.TabIndex = 146;
            // 
            // txtContact
            // 
            this.txtContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtContact.Location = new System.Drawing.Point(369, 105);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(457, 26);
            this.txtContact.TabIndex = 144;
            // 
            // txtCompany
            // 
            this.txtCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompany.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtCompany.Location = new System.Drawing.Point(602, 48);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(239, 26);
            this.txtCompany.TabIndex = 142;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 527);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtZIP);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtCountry;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TextBox txtZIP;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txtFax;
        internal System.Windows.Forms.TextBox txtTel;
        internal System.Windows.Forms.TextBox txtState;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtAddress1;
        internal System.Windows.Forms.TextBox txtContact;
        internal System.Windows.Forms.TextBox txtCompany;
    }
}