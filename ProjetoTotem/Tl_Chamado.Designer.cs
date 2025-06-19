namespace ProjetoTotem
{
    partial class Tl_Chamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tl_Chamado));
            this.CBtecnicos = new System.Windows.Forms.ComboBox();
            this.TextBox_defal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBtecnicos
            // 
            this.CBtecnicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.CBtecnicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBtecnicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBtecnicos.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold);
            this.CBtecnicos.FormattingEnabled = true;
            this.CBtecnicos.Location = new System.Drawing.Point(1005, 417);
            this.CBtecnicos.Name = "CBtecnicos";
            this.CBtecnicos.Size = new System.Drawing.Size(318, 42);
            this.CBtecnicos.Sorted = true;
            this.CBtecnicos.TabIndex = 1;
            // 
            // TextBox_defal
            // 
            this.TextBox_defal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.TextBox_defal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_defal.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_defal.Location = new System.Drawing.Point(1154, 526);
            this.TextBox_defal.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox_defal.MaxLength = 20;
            this.TextBox_defal.Name = "TextBox_defal";
            this.TextBox_defal.Size = new System.Drawing.Size(358, 34);
            this.TextBox_defal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1148, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "__________________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1148, 680);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 116);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Bclose
            // 
            this.Bclose.BackColor = System.Drawing.Color.Transparent;
            this.Bclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.Bclose.Location = new System.Drawing.Point(1736, 12);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(156, 92);
            this.Bclose.TabIndex = 11;
            this.Bclose.UseVisualStyleBackColor = false;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // Tl_Chamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoTotem.Properties.Resources.tela_fui_chamado;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBox_defal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBtecnicos);
            this.Name = "Tl_Chamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tl_Chamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBtecnicos;
        private System.Windows.Forms.TextBox TextBox_defal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Bclose;
    }
}