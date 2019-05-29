namespace Projeto_integrador
{
    partial class Pedidoatt
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
            this.dgvpedidos = new System.Windows.Forms.DataGridView();
            this.bttatt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpedidos
            // 
            this.dgvpedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpedidos.Location = new System.Drawing.Point(22, 12);
            this.dgvpedidos.Name = "dgvpedidos";
            this.dgvpedidos.Size = new System.Drawing.Size(438, 277);
            this.dgvpedidos.TabIndex = 0;
            // 
            // bttatt
            // 
            this.bttatt.Location = new System.Drawing.Point(206, 295);
            this.bttatt.Name = "bttatt";
            this.bttatt.Size = new System.Drawing.Size(75, 23);
            this.bttatt.TabIndex = 1;
            this.bttatt.Text = "Atualizar";
            this.bttatt.UseVisualStyleBackColor = true;
            
            // 
            // Pedidoatt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 327);
            this.Controls.Add(this.bttatt);
            this.Controls.Add(this.dgvpedidos);
            this.Name = "Pedidoatt";
            this.Text = "Pedidosatt";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpedidos;
        private System.Windows.Forms.Button bttatt;
    }
}