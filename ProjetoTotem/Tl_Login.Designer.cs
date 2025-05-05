namespace ProjetoTotem
{
    partial class Tl_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tl_Login));
            this.TBsenha = new System.Windows.Forms.TextBox();
            this.Blogin = new System.Windows.Forms.Button();
            this.Bsair = new System.Windows.Forms.Button();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBsenha
            // 
            this.TBsenha.Location = new System.Drawing.Point(847, 689);
            this.TBsenha.Multiline = true;
            this.TBsenha.Name = "TBsenha";
            this.TBsenha.Size = new System.Drawing.Size(235, 31);
            this.TBsenha.TabIndex = 1;
            // 
            // Blogin
            // 
            this.Blogin.Location = new System.Drawing.Point(1075, 851);
            this.Blogin.Name = "Blogin";
            this.Blogin.Size = new System.Drawing.Size(166, 55);
            this.Blogin.TabIndex = 2;
            this.Blogin.Text = "ENTRAR";
            this.Blogin.UseVisualStyleBackColor = true;
            this.Blogin.Click += new System.EventHandler(this.Blogin_Click);
            // 
            // Bsair
            // 
            this.Bsair.Location = new System.Drawing.Point(703, 851);
            this.Bsair.Name = "Bsair";
            this.Bsair.Size = new System.Drawing.Size(166, 55);
            this.Bsair.TabIndex = 3;
            this.Bsair.Text = "SAIR";
            this.Bsair.UseVisualStyleBackColor = true;
            // 
            // TBusuario
            // 
            this.TBusuario.Location = new System.Drawing.Point(847, 496);
            this.TBusuario.Multiline = true;
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(235, 31);
            this.TBusuario.TabIndex = 4;
            // 
            // Tl_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.TBusuario);
            this.Controls.Add(this.Bsair);
            this.Controls.Add(this.Blogin);
            this.Controls.Add(this.TBsenha);
            this.Name = "Tl_Login";
            this.Text = "Tl_Login";
            this.Load += new System.EventHandler(this.Tl_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBsenha;
        private System.Windows.Forms.Button Blogin;
        private System.Windows.Forms.Button Bsair;
        private System.Windows.Forms.TextBox TBusuario;
    }
}