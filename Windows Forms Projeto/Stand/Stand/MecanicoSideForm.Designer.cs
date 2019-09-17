namespace Stand
{
    partial class MecanicoSideForm
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
            this.bttnReparar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMec = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bttnEntregar = new System.Windows.Forms.Button();
            this.labelEntregar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 63);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 264);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bttnReparar
            // 
            this.bttnReparar.Location = new System.Drawing.Point(316, 254);
            this.bttnReparar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnReparar.Name = "bttnReparar";
            this.bttnReparar.Size = new System.Drawing.Size(93, 56);
            this.bttnReparar.TabIndex = 10;
            this.bttnReparar.Text = "Reparar Carro";
            this.bttnReparar.UseVisualStyleBackColor = true;
            this.bttnReparar.Click += new System.EventHandler(this.bttnReparar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 171;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 165;
            this.label1.Text = "Funcionário:";
            // 
            // comboBoxMec
            // 
            this.comboBoxMec.FormattingEnabled = true;
            this.comboBoxMec.Location = new System.Drawing.Point(316, 95);
            this.comboBoxMec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMec.Name = "comboBoxMec";
            this.comboBoxMec.Size = new System.Drawing.Size(173, 21);
            this.comboBoxMec.TabIndex = 172;
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label11.Location = new System.Drawing.Point(32, 44);
            this.Label11.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(147, 19);
            this.Label11.TabIndex = 159;
            this.Label11.Text = "Veiculos para reparar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Reparar Carros",
            "Entregar Carros"});
            this.comboBox1.Location = new System.Drawing.Point(34, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 173;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bttnEntregar
            // 
            this.bttnEntregar.Location = new System.Drawing.Point(316, 254);
            this.bttnEntregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnEntregar.Name = "bttnEntregar";
            this.bttnEntregar.Size = new System.Drawing.Size(93, 56);
            this.bttnEntregar.TabIndex = 174;
            this.bttnEntregar.Text = "Entregar Carro";
            this.bttnEntregar.UseVisualStyleBackColor = true;
            this.bttnEntregar.Click += new System.EventHandler(this.bttnEntregar_Click);
            // 
            // labelEntregar
            // 
            this.labelEntregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEntregar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelEntregar.Location = new System.Drawing.Point(32, 44);
            this.labelEntregar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.labelEntregar.Name = "labelEntregar";
            this.labelEntregar.Size = new System.Drawing.Size(280, 15);
            this.labelEntregar.TabIndex = 175;
            this.labelEntregar.Text = "Veiculos prontos para ser entregues:";
            // 
            // MecanicoSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 343);
            this.Controls.Add(this.labelEntregar);
            this.Controls.Add(this.bttnEntregar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxMec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.bttnReparar);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MecanicoSideForm";
            this.Text = "Mecânicos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bttnReparar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMec;
        internal System.Windows.Forms.Label Label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bttnEntregar;
        internal System.Windows.Forms.Label labelEntregar;
    }
}