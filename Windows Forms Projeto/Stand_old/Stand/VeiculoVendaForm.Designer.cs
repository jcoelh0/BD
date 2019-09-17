namespace Stand
{
    partial class VeiculoVendaForm
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
            this.Label11 = new System.Windows.Forms.Label();
            this.txtQuilometragem = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtChassisId = new System.Windows.Forms.TextBox();
            this.txtPaisOrigem = new System.Windows.Forms.TextBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnOK = new System.Windows.Forms.Button();
            this.txtTraçao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnoFabrico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStandId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            // bttnRmv
            // 
            this.bttnRmv.Location = new System.Drawing.Point(757, 378);
            this.bttnRmv.Name = "bttnRmv";
            this.bttnRmv.Size = new System.Drawing.Size(124, 69);
            this.bttnRmv.TabIndex = 8;
            this.bttnRmv.Text = "Remover";
            this.bttnRmv.UseVisualStyleBackColor = true;
            this.bttnRmv.Click += new System.EventHandler(this.bttnRmv_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(367, 378);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(124, 69);
            this.bttnAdd.TabIndex = 9;
            this.bttnAdd.Text = "Adicionar";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(559, 378);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(124, 69);
            this.bttnEdit.TabIndex = 10;
            this.bttnEdit.Text = "Editar";
            this.bttnEdit.UseVisualStyleBackColor = true;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
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
            this.Label11.Text = "Tipo Veiculo";
            // 
            // txtQuilometragem
            // 
            this.txtQuilometragem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuilometragem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtQuilometragem.Location = new System.Drawing.Point(367, 335);
            this.txtQuilometragem.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtQuilometragem.Name = "txtQuilometragem";
            this.txtQuilometragem.ReadOnly = true;
            this.txtQuilometragem.Size = new System.Drawing.Size(214, 26);
            this.txtQuilometragem.TabIndex = 158;
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label4.Location = new System.Drawing.Point(365, 307);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(138, 26);
            this.Label4.TabIndex = 157;
            this.Label4.Text = "Quilometragem";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
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
            this.Label6.Text = "Modelo";
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
            this.Label5.Text = "Marca";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(366, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 145;
            this.label8.Text = "Chassis ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.Location = new System.Drawing.Point(365, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 20);
            this.label12.TabIndex = 143;
            this.label12.Text = "País de Origem";
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtModelo.Location = new System.Drawing.Point(367, 273);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(214, 26);
            this.txtModelo.TabIndex = 152;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtMarca.Location = new System.Drawing.Point(367, 216);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(214, 26);
            this.txtMarca.TabIndex = 148;
            // 
            // txtChassisId
            // 
            this.txtChassisId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChassisId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtChassisId.Location = new System.Drawing.Point(367, 160);
            this.txtChassisId.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtChassisId.Name = "txtChassisId";
            this.txtChassisId.ReadOnly = true;
            this.txtChassisId.Size = new System.Drawing.Size(214, 26);
            this.txtChassisId.TabIndex = 146;
            // 
            // txtPaisOrigem
            // 
            this.txtPaisOrigem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaisOrigem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtPaisOrigem.Location = new System.Drawing.Point(367, 105);
            this.txtPaisOrigem.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtPaisOrigem.Name = "txtPaisOrigem";
            this.txtPaisOrigem.ReadOnly = true;
            this.txtPaisOrigem.Size = new System.Drawing.Size(214, 26);
            this.txtPaisOrigem.TabIndex = 144;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(457, 378);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(124, 69);
            this.bttnCancel.TabIndex = 161;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnOK
            // 
            this.bttnOK.Location = new System.Drawing.Point(660, 378);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(124, 69);
            this.bttnOK.TabIndex = 162;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // txtTraçao
            // 
            this.txtTraçao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTraçao.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtTraçao.Location = new System.Drawing.Point(611, 188);
            this.txtTraçao.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtTraçao.Name = "txtTraçao";
            this.txtTraçao.ReadOnly = true;
            this.txtTraçao.Size = new System.Drawing.Size(231, 26);
            this.txtTraçao.TabIndex = 164;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(608, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 163;
            this.label1.Text = "Tração";
            // 
            // txtAnoFabrico
            // 
            this.txtAnoFabrico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnoFabrico.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtAnoFabrico.Location = new System.Drawing.Point(611, 48);
            this.txtAnoFabrico.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtAnoFabrico.Name = "txtAnoFabrico";
            this.txtAnoFabrico.ReadOnly = true;
            this.txtAnoFabrico.Size = new System.Drawing.Size(231, 26);
            this.txtAnoFabrico.TabIndex = 166;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(608, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 165;
            this.label2.Text = "Ano de Fabrico";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCombustivel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtCombustivel.Location = new System.Drawing.Point(611, 122);
            this.txtCombustivel.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.ReadOnly = true;
            this.txtCombustivel.Size = new System.Drawing.Size(231, 26);
            this.txtCombustivel.TabIndex = 168;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(608, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 167;
            this.label3.Text = "Combustível";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 - Ligeiro",
            "2 - Motociclo",
            "3 - Pesado de Passageiros",
            "4 - Pesado de Mercadorias",
            "5 - Veiculo Agricola",
            "6 - Quadriciclo"});
            this.comboBox1.Location = new System.Drawing.Point(367, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 24);
            this.comboBox1.TabIndex = 170;
            // 
            // txtPotencia
            // 
            this.txtPotencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPotencia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtPotencia.Location = new System.Drawing.Point(611, 261);
            this.txtPotencia.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.ReadOnly = true;
            this.txtPotencia.Size = new System.Drawing.Size(231, 26);
            this.txtPotencia.TabIndex = 172;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(608, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 26);
            this.label7.TabIndex = 171;
            this.label7.Text = "Potência";
            // 
            // txtStandId
            // 
            this.txtStandId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStandId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtStandId.Location = new System.Drawing.Point(611, 335);
            this.txtStandId.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtStandId.Name = "txtStandId";
            this.txtStandId.ReadOnly = true;
            this.txtStandId.Size = new System.Drawing.Size(231, 26);
            this.txtStandId.TabIndex = 174;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(608, 307);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 26);
            this.label9.TabIndex = 173;
            this.label9.Text = "Stand ID";
            // 
            // VeiculoVendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 527);
            this.Controls.Add(this.txtStandId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnoFabrico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTraçao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtQuilometragem);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtChassisId);
            this.Controls.Add(this.txtPaisOrigem);
            this.Controls.Add(this.bttnEdit);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.bttnRmv);
            this.Controls.Add(this.listBox1);
            this.Name = "VeiculoVendaForm";
            this.Text = "Vender Veículos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bttnRmv;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnEdit;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtQuilometragem;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtModelo;
        internal System.Windows.Forms.TextBox txtMarca;
        internal System.Windows.Forms.TextBox txtPaisOrigem;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnOK;
        internal System.Windows.Forms.TextBox txtChassisId;
        internal System.Windows.Forms.TextBox txtTraçao;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtAnoFabrico;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtCombustivel;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.TextBox txtPotencia;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtStandId;
        internal System.Windows.Forms.Label label9;
    }
}