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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bt_problema = new System.Windows.Forms.Button();
            this.bt_chamado = new System.Windows.Forms.Button();
            this.bt_etiqueta = new System.Windows.Forms.Button();
            this.bt_requisicao = new System.Windows.Forms.Button();
            this.bt_incidente = new System.Windows.Forms.Button();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoTotem.Properties.Resources.img_bv;
            this.pictureBox1.Location = new System.Drawing.Point(148, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bt_problema
            // 
            this.bt_problema.BackgroundImage = global::ProjetoTotem.Properties.Resources.bt_11;
            this.bt_problema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_problema.Location = new System.Drawing.Point(168, 615);
            this.bt_problema.Name = "bt_problema";
            this.bt_problema.Size = new System.Drawing.Size(364, 116);
            this.bt_problema.TabIndex = 6;
            this.bt_problema.UseVisualStyleBackColor = true;
            this.bt_problema.Click += new System.EventHandler(this.bt_problema_Click);
            // 
            // bt_chamado
            // 
            this.bt_chamado.BackgroundImage = global::ProjetoTotem.Properties.Resources.bt_21;
            this.bt_chamado.Location = new System.Drawing.Point(682, 615);
            this.bt_chamado.Name = "bt_chamado";
            this.bt_chamado.Size = new System.Drawing.Size(364, 116);
            this.bt_chamado.TabIndex = 7;
            this.bt_chamado.UseVisualStyleBackColor = true;
            this.bt_chamado.Click += new System.EventHandler(this.bt_chamado_Click);
            // 
            // bt_etiqueta
            // 
            this.bt_etiqueta.BackgroundImage = global::ProjetoTotem.Properties.Resources.bt_31;
            this.bt_etiqueta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_etiqueta.Location = new System.Drawing.Point(168, 778);
            this.bt_etiqueta.Name = "bt_etiqueta";
            this.bt_etiqueta.Size = new System.Drawing.Size(364, 116);
            this.bt_etiqueta.TabIndex = 8;
            this.bt_etiqueta.UseVisualStyleBackColor = true;
            this.bt_etiqueta.Click += new System.EventHandler(this.bt_etiqueta_Click);
            // 
            // bt_requisicao
            // 
            this.bt_requisicao.BackgroundImage = global::ProjetoTotem.Properties.Resources.bt_41;
            this.bt_requisicao.Location = new System.Drawing.Point(682, 778);
            this.bt_requisicao.Name = "bt_requisicao";
            this.bt_requisicao.Size = new System.Drawing.Size(364, 116);
            this.bt_requisicao.TabIndex = 9;
            this.bt_requisicao.UseVisualStyleBackColor = true;
            this.bt_requisicao.Click += new System.EventHandler(this.bt_requisicao_Click);
            // 
            // bt_incidente
            // 
            this.bt_incidente.BackgroundImage = global::ProjetoTotem.Properties.Resources.bt_51;
            this.bt_incidente.Location = new System.Drawing.Point(1349, 686);
            this.bt_incidente.Name = "bt_incidente";
            this.bt_incidente.Size = new System.Drawing.Size(364, 116);
            this.bt_incidente.TabIndex = 10;
            this.bt_incidente.UseVisualStyleBackColor = true;
            this.bt_incidente.Click += new System.EventHandler(this.bt_incidente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}

