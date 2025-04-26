namespace ProjetoTotem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_incidente = new System.Windows.Forms.Button();
            this.bt_requisicao = new System.Windows.Forms.Button();
            this.bt_etiqueta = new System.Windows.Forms.Button();
            this.bt_chamado = new System.Windows.Forms.Button();
            this.bt_problema = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Tem um problema (2).png");
            this.imageList1.Images.SetKeyName(1, "Tem um problema (3).png");
            this.imageList1.Images.SetKeyName(2, "Tem um problema (4).png");
            this.imageList1.Images.SetKeyName(3, "Tem um problema (5).png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(168, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 60);
            this.label1.TabIndex = 14;
            this.label1.Text = "Algumas sugestões para você";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(1353, 615);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 43);
            this.label2.TabIndex = 15;
            this.label2.Text = "Não possui incidente ?";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjetoTotem.Properties.Resources.logoapp;
            this.pictureBox4.Location = new System.Drawing.Point(1716, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(136, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjetoTotem.Properties.Resources.arcelorpng;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(201, 94);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ProjetoTotem.Properties.Resources.linharodape;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1920, 5);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // bt_incidente
            // 
            this.bt_incidente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_incidente.BackgroundImage")));
            this.bt_incidente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_incidente.FlatAppearance.BorderSize = 0;
            this.bt_incidente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_incidente.Location = new System.Drawing.Point(1349, 686);
            this.bt_incidente.Name = "bt_incidente";
            this.bt_incidente.Size = new System.Drawing.Size(364, 116);
            this.bt_incidente.TabIndex = 10;
            this.bt_incidente.UseVisualStyleBackColor = true;
            this.bt_incidente.Click += new System.EventHandler(this.bt_incidente_Click);
            // 
            // bt_requisicao
            // 
            this.bt_requisicao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_requisicao.BackgroundImage")));
            this.bt_requisicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_requisicao.FlatAppearance.BorderSize = 0;
            this.bt_requisicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_requisicao.Location = new System.Drawing.Point(682, 778);
            this.bt_requisicao.Name = "bt_requisicao";
            this.bt_requisicao.Size = new System.Drawing.Size(364, 116);
            this.bt_requisicao.TabIndex = 9;
            this.bt_requisicao.UseVisualStyleBackColor = true;
            this.bt_requisicao.Click += new System.EventHandler(this.bt_requisicao_Click);
            // 
            // bt_etiqueta
            // 
            this.bt_etiqueta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_etiqueta.BackgroundImage")));
            this.bt_etiqueta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_etiqueta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_etiqueta.FlatAppearance.BorderSize = 0;
            this.bt_etiqueta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_etiqueta.Location = new System.Drawing.Point(168, 778);
            this.bt_etiqueta.Name = "bt_etiqueta";
            this.bt_etiqueta.Size = new System.Drawing.Size(364, 116);
            this.bt_etiqueta.TabIndex = 8;
            this.bt_etiqueta.UseVisualStyleBackColor = true;
            this.bt_etiqueta.Click += new System.EventHandler(this.bt_etiqueta_Click);
            // 
            // bt_chamado
            // 
            this.bt_chamado.BackColor = System.Drawing.Color.White;
            this.bt_chamado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_chamado.BackgroundImage")));
            this.bt_chamado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_chamado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_chamado.FlatAppearance.BorderSize = 0;
            this.bt_chamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_chamado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_chamado.Location = new System.Drawing.Point(682, 615);
            this.bt_chamado.Name = "bt_chamado";
            this.bt_chamado.Size = new System.Drawing.Size(364, 116);
            this.bt_chamado.TabIndex = 7;
            this.bt_chamado.UseVisualStyleBackColor = false;
            this.bt_chamado.Click += new System.EventHandler(this.bt_chamado_Click);
            // 
            // bt_problema
            // 
            this.bt_problema.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_problema.BackgroundImage")));
            this.bt_problema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_problema.FlatAppearance.BorderSize = 0;
            this.bt_problema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_problema.Location = new System.Drawing.Point(168, 615);
            this.bt_problema.Name = "bt_problema";
            this.bt_problema.Size = new System.Drawing.Size(364, 116);
            this.bt_problema.TabIndex = 6;
            this.bt_problema.UseVisualStyleBackColor = true;
            this.bt_problema.Click += new System.EventHandler(this.bt_problema_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bt_incidente);
            this.Controls.Add(this.bt_requisicao);
            this.Controls.Add(this.bt_etiqueta);
            this.Controls.Add(this.bt_chamado);
            this.Controls.Add(this.bt_problema);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bt_problema;
        private System.Windows.Forms.Button bt_chamado;
        private System.Windows.Forms.Button bt_etiqueta;
        private System.Windows.Forms.Button bt_requisicao;
        private System.Windows.Forms.Button bt_incidente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

