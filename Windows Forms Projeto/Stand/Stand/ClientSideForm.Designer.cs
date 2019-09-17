namespace Stand
{
    partial class ClientSideForm
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
            this.bttnComprar = new System.Windows.Forms.Button();
            this.bttnReparar = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.comboBoxMecClient = new System.Windows.Forms.ComboBox();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.comboBoxGarages = new System.Windows.Forms.ComboBox();
            this.comboBoxParts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 71);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 225);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bttnComprar
            // 
            this.bttnComprar.Location = new System.Drawing.Point(419, 307);
            this.bttnComprar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnComprar.Name = "bttnComprar";
            this.bttnComprar.Size = new System.Drawing.Size(93, 56);
            this.bttnComprar.TabIndex = 9;
            this.bttnComprar.Text = "Comprar Carro";
            this.bttnComprar.UseVisualStyleBackColor = true;
            this.bttnComprar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnReparar
            // 
            this.bttnReparar.Location = new System.Drawing.Point(420, 307);
            this.bttnReparar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnReparar.Name = "bttnReparar";
            this.bttnReparar.Size = new System.Drawing.Size(93, 56);
            this.bttnReparar.TabIndex = 10;
            this.bttnReparar.Text = "Mandar Reparar Carro";
            this.bttnReparar.UseVisualStyleBackColor = true;
            this.bttnReparar.Click += new System.EventHandler(this.bttnReparar_Click);
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label11.Location = new System.Drawing.Point(34, 15);
            this.Label11.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(334, 19);
            this.Label11.TabIndex = 159;
            this.Label11.Text = "Escolha uma opção para a visualização de veículos:";
            // 
            // comboBoxMecClient
            // 
            this.comboBoxMecClient.FormattingEnabled = true;
            this.comboBoxMecClient.Items.AddRange(new object[] {
            "Comprar",
            "Mandar Reparar"});
            this.comboBoxMecClient.Location = new System.Drawing.Point(37, 39);
            this.comboBoxMecClient.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMecClient.Name = "comboBoxMecClient";
            this.comboBoxMecClient.Size = new System.Drawing.Size(164, 21);
            this.comboBoxMecClient.Sorted = true;
            this.comboBoxMecClient.TabIndex = 163;
            this.comboBoxMecClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxMecClient_SelectedIndexChanged);
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(289, 71);
            this.listBoxCars.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCars.MultiColumn = true;
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(224, 225);
            this.listBoxCars.Sorted = true;
            this.listBoxCars.TabIndex = 165;
            // 
            // comboBoxGarages
            // 
            this.comboBoxGarages.FormattingEnabled = true;
            this.comboBoxGarages.Location = new System.Drawing.Point(37, 342);
            this.comboBoxGarages.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGarages.Name = "comboBoxGarages";
            this.comboBoxGarages.Size = new System.Drawing.Size(164, 21);
            this.comboBoxGarages.Sorted = true;
            this.comboBoxGarages.TabIndex = 166;
            // 
            // comboBoxParts
            // 
            this.comboBoxParts.FormattingEnabled = true;
            this.comboBoxParts.Location = new System.Drawing.Point(251, 342);
            this.comboBoxParts.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxParts.Name = "comboBoxParts";
            this.comboBoxParts.Size = new System.Drawing.Size(164, 21);
            this.comboBoxParts.Sorted = true;
            this.comboBoxParts.TabIndex = 167;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(34, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 168;
            this.label1.Text = "Oficina:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(248, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 169;
            this.label2.Text = "Peça:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 170;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxParts);
            this.Controls.Add(this.comboBoxGarages);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.comboBoxMecClient);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.bttnReparar);
            this.Controls.Add(this.bttnComprar);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientSideForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bttnComprar;
        private System.Windows.Forms.Button bttnReparar;
        internal System.Windows.Forms.Label Label11;
        private System.Windows.Forms.ComboBox comboBoxMecClient;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.ComboBox comboBoxGarages;
        private System.Windows.Forms.ComboBox comboBoxParts;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}