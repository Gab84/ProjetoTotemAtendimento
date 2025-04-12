namespace ProjetoTotem
{
    partial class Tl_Senhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tl_Senhas));
            this.numSenha = new System.Windows.Forms.Label();
            this.portaAtendimento = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numSenha
            // 
            this.numSenha.BackColor = System.Drawing.Color.Transparent;
            this.numSenha.Font = new System.Drawing.Font("Arial Black", 81.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSenha.Location = new System.Drawing.Point(1213, 308);
            this.numSenha.Name = "numSenha";
            this.numSenha.Size = new System.Drawing.Size(444, 165);
            this.numSenha.TabIndex = 5;
            this.numSenha.Text = "label3";
            this.numSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numSenha.Click += new System.EventHandler(this.numSenha_Click_1);
            // 
            // portaAtendimento
            // 
            this.portaAtendimento.BackColor = System.Drawing.Color.Transparent;
            this.portaAtendimento.Font = new System.Drawing.Font("Arial Black", 51.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portaAtendimento.Location = new System.Drawing.Point(1172, 746);
            this.portaAtendimento.Name = "portaAtendimento";
            this.portaAtendimento.Size = new System.Drawing.Size(557, 165);
            this.portaAtendimento.TabIndex = 7;
            this.portaAtendimento.Text = "label3";
            this.portaAtendimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.Size = new System.Drawing.Size(749, 745);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Tl_Senhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.portaAtendimento);
            this.Controls.Add(this.numSenha);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tl_Senhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tl_Senhas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tl_Senhas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label numSenha;
        private System.Windows.Forms.Label portaAtendimento;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}