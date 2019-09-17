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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(49, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 276);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bttnComprar
            // 
            this.bttnComprar.Location = new System.Drawing.Point(559, 378);
            this.bttnComprar.Name = "bttnComprar";
            this.bttnComprar.Size = new System.Drawing.Size(124, 69);
            this.bttnComprar.TabIndex = 9;
            this.bttnComprar.Text = "Comprar Carro";
            this.bttnComprar.UseVisualStyleBackColor = true;
            this.bttnComprar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnReparar
            // 
            this.bttnReparar.Location = new System.Drawing.Point(559, 378);
            this.bttnReparar.Name = "bttnReparar";
            this.bttnReparar.Size = new System.Drawing.Size(124, 69);
            this.bttnReparar.TabIndex = 10;
            this.bttnReparar.Text = "Mandar Reparar Carro";
            this.bttnReparar.UseVisualStyleBackColor = true;
            this.bttnReparar.Click += new System.EventHandler(this.bttnReparar_Click);
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label11.Location = new System.Drawing.Point(46, 18);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(445, 23);
            this.Label11.TabIndex = 159;
            this.Label11.Text = "Escolha uma opção para a visualização de veículos:";
            // 
            // comboBoxMecClient
            // 
            this.comboBoxMecClient.FormattingEnabled = true;
            this.comboBoxMecClient.Items.AddRange(new object[] {
            "Comprar",
            "Mandar Reparar"});
            this.comboBoxMecClient.Location = new System.Drawing.Point(49, 48);
            this.comboBoxMecClient.Name = "comboBoxMecClient";
            this.comboBoxMecClient.Size = new System.Drawing.Size(218, 24);
            this.comboBoxMecClient.TabIndex = 163;
            this.comboBoxMecClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxMecClient_SelectedIndexChanged);
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 16;
            this.listBoxCars.Location = new System.Drawing.Point(385, 87);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(298, 276);
            this.listBoxCars.TabIndex = 165;
            // 
            // ClientSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 477);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.comboBoxMecClient);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.bttnReparar);
            this.Controls.Add(this.bttnComprar);
            this.Controls.Add(this.listBox1);
            this.Name = "ClientSideForm";
            this.Text = "Client Side";
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
    }
}