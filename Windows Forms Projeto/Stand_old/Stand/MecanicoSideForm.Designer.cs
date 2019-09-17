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
            this.Label11 = new System.Windows.Forms.Label();
            this.comboBoxMecClient = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // bttnReparar
            // 
            this.bttnReparar.Location = new System.Drawing.Point(421, 294);
            this.bttnReparar.Name = "bttnReparar";
            this.bttnReparar.Size = new System.Drawing.Size(124, 69);
            this.bttnReparar.TabIndex = 10;
            this.bttnReparar.Text = "Reparar Carro";
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
            this.Label11.Size = new System.Drawing.Size(499, 23);
            this.Label11.TabIndex = 159;
            this.Label11.Text = "Escolha um cliente para ver se tem carros por reparar:";
            // 
            // comboBoxMecClient
            // 
            this.comboBoxMecClient.FormattingEnabled = true;
            this.comboBoxMecClient.Location = new System.Drawing.Point(49, 48);
            this.comboBoxMecClient.Name = "comboBoxMecClient";
            this.comboBoxMecClient.Size = new System.Drawing.Size(298, 24);
            this.comboBoxMecClient.TabIndex = 163;
            this.comboBoxMecClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxMecClient_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 164;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 165;
            this.label1.Text = "Insira o seu Nr de Funcionário:";
            // 
            // MecanicoSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxMecClient);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.bttnReparar);
            this.Controls.Add(this.listBox1);
            this.Name = "MecanicoSideForm";
            this.Text = "Mecânico Side";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bttnReparar;
        internal System.Windows.Forms.Label Label11;
        private System.Windows.Forms.ComboBox comboBoxMecClient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}