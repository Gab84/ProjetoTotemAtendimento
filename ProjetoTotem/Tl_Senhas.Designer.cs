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
            this.numSenha = new System.Windows.Forms.Label();
            this.dataGrid_Concluidos = new System.Windows.Forms.DataGridView();
            this.numSenha2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumSenhaPA = new System.Windows.Forms.Label();
            this.NumSenhaPB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Concluidos)).BeginInit();
            this.SuspendLayout();
            // 
            // numSenha
            // 
            this.numSenha.BackColor = System.Drawing.Color.Transparent;
            this.numSenha.Font = new System.Drawing.Font("Arial Black", 78F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSenha.Location = new System.Drawing.Point(1143, 271);
            this.numSenha.Name = "numSenha";
            this.numSenha.Size = new System.Drawing.Size(586, 165);
            this.numSenha.TabIndex = 5;
            this.numSenha.Text = "...";
            this.numSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.numSenha.Click += new System.EventHandler(this.numSenha_Click_1);
            // 
            // dataGrid_Concluidos
            // 
            this.dataGrid_Concluidos.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGrid_Concluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Concluidos.Location = new System.Drawing.Point(96, 236);
            this.dataGrid_Concluidos.Name = "dataGrid_Concluidos";
            this.dataGrid_Concluidos.RowHeadersWidth = 100;
            this.dataGrid_Concluidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGrid_Concluidos.Size = new System.Drawing.Size(749, 745);
            this.dataGrid_Concluidos.TabIndex = 1;
            this.dataGrid_Concluidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numSenha2
            // 
            this.numSenha2.BackColor = System.Drawing.Color.Transparent;
            this.numSenha2.Font = new System.Drawing.Font("Arial Black", 78F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSenha2.Location = new System.Drawing.Point(1143, 402);
            this.numSenha2.Name = "numSenha2";
            this.numSenha2.Size = new System.Drawing.Size(586, 165);
            this.numSenha2.TabIndex = 8;
            this.numSenha2.Text = "...";
            this.numSenha2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1143, 831);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 165);
            this.label1.TabIndex = 9;
            this.label1.Text = "PORTA B:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumSenhaPA
            // 
            this.NumSenhaPA.BackColor = System.Drawing.Color.Transparent;
            this.NumSenhaPA.Font = new System.Drawing.Font("Arial Black", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSenhaPA.Location = new System.Drawing.Point(1439, 719);
            this.NumSenhaPA.Name = "NumSenhaPA";
            this.NumSenhaPA.Size = new System.Drawing.Size(300, 165);
            this.NumSenhaPA.TabIndex = 10;
            this.NumSenhaPA.Text = "...";
            this.NumSenhaPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumSenhaPB
            // 
            this.NumSenhaPB.BackColor = System.Drawing.Color.Transparent;
            this.NumSenhaPB.Font = new System.Drawing.Font("Arial Black", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSenhaPB.Location = new System.Drawing.Point(1439, 829);
            this.NumSenhaPB.Name = "NumSenhaPB";
            this.NumSenhaPB.Size = new System.Drawing.Size(300, 165);
            this.NumSenhaPB.TabIndex = 11;
            this.NumSenhaPB.Text = "...";
            this.NumSenhaPB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1143, 719);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 165);
            this.label2.TabIndex = 12;
            this.label2.Text = "PORTA A:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Tl_Senhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProjetoTotem.Properties.Resources.tela_senhas;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumSenhaPB);
            this.Controls.Add(this.NumSenhaPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSenha2);
            this.Controls.Add(this.numSenha);
            this.Controls.Add(this.dataGrid_Concluidos);
            this.Name = "Tl_Senhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tl_Senhas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tl_Senhas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Concluidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label numSenha;
        private System.Windows.Forms.DataGridView dataGrid_Concluidos;
        private System.Windows.Forms.Label numSenha2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumSenhaPA;
        private System.Windows.Forms.Label NumSenhaPB;
        private System.Windows.Forms.Label label2;
    }
}