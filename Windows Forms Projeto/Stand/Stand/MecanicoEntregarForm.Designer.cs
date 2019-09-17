namespace Stand
{
    partial class MecanicoEntregarForm
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
            this.bttnEntregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(49, 39);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 324);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bttnEntregar
            // 
            this.bttnEntregar.Location = new System.Drawing.Point(421, 294);
            this.bttnEntregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnEntregar.Name = "bttnEntregar";
            this.bttnEntregar.Size = new System.Drawing.Size(124, 69);
            this.bttnEntregar.TabIndex = 10;
            this.bttnEntregar.Text = "Entregar Carro";
            this.bttnEntregar.UseVisualStyleBackColor = true;
            this.bttnEntregar.Click += new System.EventHandler(this.bttnReparar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 171;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label11.Location = new System.Drawing.Point(45, 15);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(301, 18);
            this.Label11.TabIndex = 159;
            this.Label11.Text = "Veiculos prontos para ser entregues:";
            // 
            // MecanicoEntregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.bttnEntregar);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MecanicoEntregarForm";
            this.Text = "Mecânicos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bttnEntregar;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label Label11;
    }
}