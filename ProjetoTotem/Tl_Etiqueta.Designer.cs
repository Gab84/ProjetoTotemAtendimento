namespace ProjetoTotem
{
    partial class Tl_Etiqueta
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
            this.ImprimirETQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImprimirETQ
            // 
            this.ImprimirETQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ImprimirETQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImprimirETQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImprimirETQ.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ImprimirETQ.FlatAppearance.BorderSize = 0;
            this.ImprimirETQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirETQ.ForeColor = System.Drawing.Color.Black;
            this.ImprimirETQ.Image = global::ProjetoTotem.Properties.Resources.icon_impressora1;
            this.ImprimirETQ.Location = new System.Drawing.Point(908, 866);
            this.ImprimirETQ.Name = "ImprimirETQ";
            this.ImprimirETQ.Size = new System.Drawing.Size(111, 129);
            this.ImprimirETQ.TabIndex = 0;
            this.ImprimirETQ.UseVisualStyleBackColor = false;
            this.ImprimirETQ.Click += new System.EventHandler(this.ImprimirETQ_Click);
            // 
            // Tl_Etiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::ProjetoTotem.Properties.Resources.tela_etiqueta;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.ImprimirETQ);
            this.Name = "Tl_Etiqueta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tl_Etiqueta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImprimirETQ;
    }
}