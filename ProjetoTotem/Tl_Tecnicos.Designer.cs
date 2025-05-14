namespace ProjetoTotem
{
    partial class Tl_Tecnicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tl_Tecnicos));
            this.DataGrid_Pendentes = new System.Windows.Forms.DataGridView();
            this.dataGrid_EmAtendimento_T = new System.Windows.Forms.DataGridView();
            this.dataGrid_Prioritarios = new System.Windows.Forms.DataGridView();
            this.dataGrid_atendidos = new System.Windows.Forms.DataGridView();
            this.FINALIZAR = new System.Windows.Forms.Button();
            this.Batender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Pendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_EmAtendimento_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Prioritarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_atendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Pendentes
            // 
            this.DataGrid_Pendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Pendentes.Location = new System.Drawing.Point(210, 259);
            this.DataGrid_Pendentes.Name = "DataGrid_Pendentes";
            this.DataGrid_Pendentes.Size = new System.Drawing.Size(515, 411);
            this.DataGrid_Pendentes.TabIndex = 0;
            this.DataGrid_Pendentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Pendentes_CellContentClick);
            // 
            // dataGrid_EmAtendimento_T
            // 
            this.dataGrid_EmAtendimento_T.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_EmAtendimento_T.Location = new System.Drawing.Point(1243, 259);
            this.dataGrid_EmAtendimento_T.Name = "dataGrid_EmAtendimento_T";
            this.dataGrid_EmAtendimento_T.Size = new System.Drawing.Size(497, 340);
            this.dataGrid_EmAtendimento_T.TabIndex = 1;
            this.dataGrid_EmAtendimento_T.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_EmAtendimento_T_CellContentClick);
            // 
            // dataGrid_Prioritarios
            // 
            this.dataGrid_Prioritarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Prioritarios.Location = new System.Drawing.Point(227, 835);
            this.dataGrid_Prioritarios.Name = "dataGrid_Prioritarios";
            this.dataGrid_Prioritarios.Size = new System.Drawing.Size(474, 150);
            this.dataGrid_Prioritarios.TabIndex = 2;
            // 
            // dataGrid_atendidos
            // 
            this.dataGrid_atendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_atendidos.Location = new System.Drawing.Point(1243, 835);
            this.dataGrid_atendidos.Name = "dataGrid_atendidos";
            this.dataGrid_atendidos.Size = new System.Drawing.Size(506, 150);
            this.dataGrid_atendidos.TabIndex = 3;
            this.dataGrid_atendidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_atendidos_CellContentClick);
            // 
            // FINALIZAR
            // 
            this.FINALIZAR.Location = new System.Drawing.Point(1550, 658);
            this.FINALIZAR.Name = "FINALIZAR";
            this.FINALIZAR.Size = new System.Drawing.Size(75, 23);
            this.FINALIZAR.TabIndex = 5;
            this.FINALIZAR.Text = "FINALIZAR";
            this.FINALIZAR.UseVisualStyleBackColor = true;
            this.FINALIZAR.Click += new System.EventHandler(this.FINALIZAR_Click);
            // 
            // Batender
            // 
            this.Batender.BackColor = System.Drawing.Color.Transparent;
            this.Batender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Batender.BackgroundImage")));
            this.Batender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Batender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Batender.ForeColor = System.Drawing.Color.Transparent;
            this.Batender.Location = new System.Drawing.Point(904, 391);
            this.Batender.Name = "Batender";
            this.Batender.Size = new System.Drawing.Size(127, 75);
            this.Batender.TabIndex = 7;
            this.Batender.UseVisualStyleBackColor = false;
            this.Batender.Click += new System.EventHandler(this.Batender_Click);
            // 
            // Tl_Tecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Batender);
            this.Controls.Add(this.FINALIZAR);
            this.Controls.Add(this.dataGrid_atendidos);
            this.Controls.Add(this.dataGrid_Prioritarios);
            this.Controls.Add(this.dataGrid_EmAtendimento_T);
            this.Controls.Add(this.DataGrid_Pendentes);
            this.Name = "Tl_Tecnicos";
            this.Text = "Tl_Tecnicos";
            this.Load += new System.EventHandler(this.Tl_Tecnicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Pendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_EmAtendimento_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Prioritarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_atendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Pendentes;
        private System.Windows.Forms.DataGridView dataGrid_EmAtendimento_T;
        private System.Windows.Forms.DataGridView dataGrid_Prioritarios;
        private System.Windows.Forms.DataGridView dataGrid_atendidos;
        private System.Windows.Forms.Button FINALIZAR;
        private System.Windows.Forms.Button Batender;
    }
}