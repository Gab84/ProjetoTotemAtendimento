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
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.PictureBox pictureBox2;
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tsenha = new System.Windows.Forms.Label();
            this.numSenha = new System.Windows.Forms.Label();
            this.tipoSenha = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Azure;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new System.Drawing.Point(1228, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(599, 352);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.BackGround_1);
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Azure;
            pictureBox2.Enabled = false;
            pictureBox2.Location = new System.Drawing.Point(1228, 570);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(599, 431);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Impact", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1880, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Central de atendimentos TI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1113, 881);
            this.dataGridView1.TabIndex = 1;
            // 
            // Tsenha
            // 
            this.Tsenha.AutoSize = true;
            this.Tsenha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tsenha.Location = new System.Drawing.Point(1501, 160);
            this.Tsenha.Name = "Tsenha";
            this.Tsenha.Size = new System.Drawing.Size(69, 24);
            this.Tsenha.TabIndex = 4;
            this.Tsenha.Text = "label2";
            this.Tsenha.Click += new System.EventHandler(this.TituloSenhas_click);
            // 
            // numSenha
            // 
            this.numSenha.AutoSize = true;
            this.numSenha.Font = new System.Drawing.Font("Arial Black", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSenha.Location = new System.Drawing.Point(1431, 281);
            this.numSenha.Name = "numSenha";
            this.numSenha.Size = new System.Drawing.Size(265, 95);
            this.numSenha.TabIndex = 5;
            this.numSenha.Text = "label3";
            // 
            // tipoSenha
            // 
            this.tipoSenha.AutoSize = true;
            this.tipoSenha.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoSenha.Location = new System.Drawing.Point(1481, 446);
            this.tipoSenha.Name = "tipoSenha";
            this.tipoSenha.Size = new System.Drawing.Size(132, 46);
            this.tipoSenha.TabIndex = 6;
            this.tipoSenha.Text = "label4";
            this.tipoSenha.Click += new System.EventHandler(this.label4_Click);
            // 
            // Tl_Senhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tipoSenha);
            this.Controls.Add(this.numSenha);
            this.Controls.Add(this.Tsenha);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Tl_Senhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tl_Senhas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tl_Senhas_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Tsenha;
        private System.Windows.Forms.Label numSenha;
        private System.Windows.Forms.Label tipoSenha;
    }
}