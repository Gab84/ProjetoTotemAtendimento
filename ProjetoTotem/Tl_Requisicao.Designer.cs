namespace ProjetoTotem
{
    partial class Tl_Requisicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tl_Requisicao));
            this.DBrequisicoes = new System.Windows.Forms.ComboBox();
            this.TBstatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DBrequisicoes
            // 
            this.DBrequisicoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.DBrequisicoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DBrequisicoes.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold);
            this.DBrequisicoes.FormattingEnabled = true;
            this.DBrequisicoes.Location = new System.Drawing.Point(1180, 448);
            this.DBrequisicoes.Name = "DBrequisicoes";
            this.DBrequisicoes.Size = new System.Drawing.Size(335, 42);
            this.DBrequisicoes.Sorted = true;
            this.DBrequisicoes.TabIndex = 2;
            this.DBrequisicoes.SelectedIndexChanged += new System.EventHandler(this.DBrequisicoes_SelectedIndexChanged);
            // 
            // TBstatus
            // 
            this.TBstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.TBstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBstatus.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBstatus.Location = new System.Drawing.Point(635, 565);
            this.TBstatus.Margin = new System.Windows.Forms.Padding(0);
            this.TBstatus.MaxLength = 23;
            this.TBstatus.Name = "TBstatus";
            this.TBstatus.ReadOnly = true;
            this.TBstatus.Size = new System.Drawing.Size(259, 34);
            this.TBstatus.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Horizon", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(629, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "__________________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1151, 668);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 116);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tl_Requisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoTotem.Properties.Resources.tela_requisição_aprovada;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DBrequisicoes);
            this.Name = "Tl_Requisicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tl_Requisicao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DBrequisicoes;
        private System.Windows.Forms.TextBox TBstatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}