namespace Stand
{
    partial class PeçaForm
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
            this.Label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDisponibiblidade = new System.Windows.Forms.TextBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.bttnRmv.Location = new System.Drawing.Point(568, 258);
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
            this.bttnAdd.Location = new System.Drawing.Point(276, 258);
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
            this.bttnEdit.Location = new System.Drawing.Point(420, 258);
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
            this.txtID.Location = new System.Drawing.Point(244, 39);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(300, 22);
            this.txtID.TabIndex = 160;
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label11.Location = new System.Drawing.Point(242, 17);
            this.Label11.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(86, 16);
            this.Label11.TabIndex = 159;
            this.Label11.Text = "Peça ID";
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label5.Location = new System.Drawing.Point(242, 153);
            this.Label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(72, 16);
            this.Label5.TabIndex = 147;
            this.Label5.Text = "Tipo Peça";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(242, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 145;
            this.label8.Text = "Disponibilidade";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.Location = new System.Drawing.Point(242, 67);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 143;
            this.label12.Text = "Fabricante";
            // 
            // txtDisponibiblidade
            // 
            this.txtDisponibiblidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisponibiblidade.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtDisponibiblidade.Location = new System.Drawing.Point(244, 125);
            this.txtDisponibiblidade.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtDisponibiblidade.Name = "txtDisponibiblidade";
            this.txtDisponibiblidade.ReadOnly = true;
            this.txtDisponibiblidade.Size = new System.Drawing.Size(300, 22);
            this.txtDisponibiblidade.TabIndex = 146;
            // 
            // txtFabricante
            // 
            this.txtFabricante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFabricante.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtFabricante.Location = new System.Drawing.Point(244, 85);
            this.txtFabricante.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.ReadOnly = true;
            this.txtFabricante.Size = new System.Drawing.Size(300, 22);
            this.txtFabricante.TabIndex = 144;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(344, 258);
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
            this.bttnOK.Location = new System.Drawing.Point(496, 258);
            this.bttnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(93, 56);
            this.bttnOK.TabIndex = 162;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(242, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 163;
            this.label1.Text = "Nome da Peça";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtNome.Location = new System.Drawing.Point(244, 217);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(300, 22);
            this.txtNome.TabIndex = 164;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "147 - Suspensão",
            "234 - Motor e Componentes",
            "374 - Outros",
            "482 - Componentes Eletricos e Eletronicos",
            "559 - Interiores",
            "570 - Carroçaria",
            "657 - Iluminação",
            "663 - Vidros",
            "798 - Travagem",
            "957 - Pneus de Ligeiro",
            "958 - Pneus de Motociclo",
            "959 - Pneus de Pesado",
            "960 - Pneus de Quadriciclo",
            "961 - Pneus de Veiculo Agricola"});
            this.comboBox1.Location = new System.Drawing.Point(244, 173);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 21);
            this.comboBox1.TabIndex = 165;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 173;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PeçaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDisponibiblidade);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.bttnEdit);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.bttnRmv);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PeçaForm";
            this.Text = "Form2";
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
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnOK;
        internal System.Windows.Forms.TextBox txtDisponibiblidade;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}