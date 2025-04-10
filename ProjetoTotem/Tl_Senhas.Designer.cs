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
            this.Tsenha = new System.Windows.Forms.Label();
            this.numSenha = new System.Windows.Forms.Label();
            this.tipoSenha = new System.Windows.Forms.Label();
            this.portaAtendimento = new System.Windows.Forms.Label();
            this.labelPorta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            // Tsenha
            // 
            this.Tsenha.AutoSize = true;
            this.Tsenha.BackColor = System.Drawing.Color.Azure;
            this.Tsenha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tsenha.Location = new System.Drawing.Point(1484, 166);
            this.Tsenha.Name = "Tsenha";
            this.Tsenha.Size = new System.Drawing.Size(69, 24);
            this.Tsenha.TabIndex = 4;
            this.Tsenha.Text = "label2";
            this.Tsenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tsenha.Click += new System.EventHandler(this.TituloSenhas_click);
            // 
            // numSenha
            // 
            this.numSenha.BackColor = System.Drawing.Color.Azure;
            this.numSenha.Font = new System.Drawing.Font("Arial Black", 81.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSenha.Location = new System.Drawing.Point(1308, 236);
            this.numSenha.Name = "numSenha";
            this.numSenha.Size = new System.Drawing.Size(444, 165);
            this.numSenha.TabIndex = 5;
            this.numSenha.Text = "label3";
            this.numSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoSenha
            // 
            this.tipoSenha.AutoSize = true;
            this.tipoSenha.BackColor = System.Drawing.Color.Azure;
            this.tipoSenha.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoSenha.Location = new System.Drawing.Point(1431, 445);
            this.tipoSenha.Name = "tipoSenha";
            this.tipoSenha.Size = new System.Drawing.Size(132, 46);
            this.tipoSenha.TabIndex = 6;
            this.tipoSenha.Text = "label4";
            this.tipoSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tipoSenha.Click += new System.EventHandler(this.label4_Click);
            // 
            // portaAtendimento
            // 
            this.portaAtendimento.BackColor = System.Drawing.Color.Azure;
            this.portaAtendimento.Font = new System.Drawing.Font("Arial Black", 51.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portaAtendimento.Location = new System.Drawing.Point(1251, 705);
            this.portaAtendimento.Name = "portaAtendimento";
            this.portaAtendimento.Size = new System.Drawing.Size(557, 165);
            this.portaAtendimento.TabIndex = 7;
            this.portaAtendimento.Text = "label3";
            this.portaAtendimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPorta
            // 
            this.labelPorta.AutoSize = true;
            this.labelPorta.BackColor = System.Drawing.Color.Azure;
            this.labelPorta.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPorta.Location = new System.Drawing.Point(1371, 616);
            this.labelPorta.Name = "labelPorta";
            this.labelPorta.Size = new System.Drawing.Size(339, 30);
            this.labelPorta.TabIndex = 8;
            this.labelPorta.Text = "PORTA PARA ATENDIMENTO";
            this.labelPorta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Arial Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1113, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "UTIMAS SENHAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.Size = new System.Drawing.Size(1113, 843);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Tl_Senhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPorta);
            this.Controls.Add(this.portaAtendimento);
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
        private System.Windows.Forms.Label Tsenha;
        private System.Windows.Forms.Label numSenha;
        private System.Windows.Forms.Label tipoSenha;
        private System.Windows.Forms.Label portaAtendimento;
        private System.Windows.Forms.Label labelPorta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}