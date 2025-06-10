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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CBtecnicos = new System.Windows.Forms.ComboBox();
            this.TextBox_defal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // CBtecnicos
            // 
            this.CBtecnicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
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
            this.TextBox_defal.Size = new System.Drawing.Size(291, 34);
            this.TextBox_defal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Horizon", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1148, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "__________________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tl_Chamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoTotem.Properties.Resources.tela_fui_chamado;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.TextBox_defal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBtecnicos);
            this.Controls.Add(this.comboBox1);
            this.Name = "Tl_Chamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tl_Chamado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tl_Chamado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox CBtecnicos;
        private System.Windows.Forms.TextBox TextBox_defal;
        private System.Windows.Forms.Label label1;
    }
}