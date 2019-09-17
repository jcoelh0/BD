namespace Stand
{
    partial class MecanicoForm
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
            this.bttnRmv = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtVeiculoID = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 19);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 264);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bttnRmv
            // 
            this.bttnRmv.Location = new System.Drawing.Point(568, 307);
            this.bttnRmv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnRmv.Name = "bttnRmv";
            this.bttnRmv.Size = new System.Drawing.Size(93, 56);
            this.bttnRmv.TabIndex = 8;
            this.bttnRmv.Text = "Remover";
            this.bttnRmv.UseVisualStyleBackColor = true;
            this.bttnRmv.Click += new System.EventHandler(this.bttnRmv_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(275, 307);
            this.bttnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(93, 56);
            this.bttnAdd.TabIndex = 9;
            this.bttnAdd.Text = "Adicionar";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(419, 307);
            this.bttnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(93, 56);
            this.bttnEdit.TabIndex = 10;
            this.bttnEdit.Text = "Editar";
            this.bttnEdit.UseVisualStyleBackColor = true;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtID.Location = new System.Drawing.Point(277, 39);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(170, 22);
            this.txtID.TabIndex = 160;
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label11.Location = new System.Drawing.Point(274, 17);
            this.Label11.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(86, 16);
            this.Label11.TabIndex = 159;
            this.Label11.Text = "NrFuncionário";
            // 
            // txtVeiculoID
            // 
            this.txtVeiculoID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVeiculoID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtVeiculoID.Location = new System.Drawing.Point(277, 272);
            this.txtVeiculoID.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtVeiculoID.Name = "txtVeiculoID";
            this.txtVeiculoID.ReadOnly = true;
            this.txtVeiculoID.Size = new System.Drawing.Size(160, 22);
            this.txtVeiculoID.TabIndex = 158;
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label4.Location = new System.Drawing.Point(274, 249);
            this.Label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 16);
            this.Label4.TabIndex = 157;
            this.Label4.Text = "VeículoID";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label6.Location = new System.Drawing.Point(274, 203);
            this.Label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(86, 16);
            this.Label6.TabIndex = 151;
            this.Label6.Text = "Contacto";
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label5.Location = new System.Drawing.Point(274, 158);
            this.Label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(72, 16);
            this.Label5.TabIndex = 147;
            this.Label5.Text = "NIF";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(274, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 145;
            this.label8.Text = "Morada";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.Location = new System.Drawing.Point(274, 67);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 143;
            this.label12.Text = "Nome";
            // 
            // txtContacto
            // 
            this.txtContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContacto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtContacto.Location = new System.Drawing.Point(277, 221);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.ReadOnly = true;
            this.txtContacto.Size = new System.Drawing.Size(120, 22);
            this.txtContacto.TabIndex = 152;
            // 
            // txtNIF
            // 
            this.txtNIF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNIF.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtNIF.Location = new System.Drawing.Point(277, 176);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.ReadOnly = true;
            this.txtNIF.Size = new System.Drawing.Size(146, 22);
            this.txtNIF.TabIndex = 148;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtAddress.Location = new System.Drawing.Point(277, 125);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(344, 22);
            this.txtAddress.TabIndex = 146;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtNome.Location = new System.Drawing.Point(277, 85);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(344, 22);
            this.txtNome.TabIndex = 144;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(343, 307);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(93, 56);
            this.bttnCancel.TabIndex = 161;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnOK
            // 
            this.bttnOK.Location = new System.Drawing.Point(495, 307);
            this.bttnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(93, 56);
            this.bttnOK.TabIndex = 162;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 173;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MecanicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtVeiculoID);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.bttnEdit);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.bttnRmv);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MecanicoForm";
            this.Text = "Mecânico";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bttnRmv;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnEdit;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtVeiculoID;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtContacto;
        internal System.Windows.Forms.TextBox txtNIF;
        internal System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnOK;
        internal System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button button1;
    }
}