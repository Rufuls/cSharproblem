namespace Projeto_integrador
{
    partial class Estoque
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
            this.components = new System.ComponentModel.Container();
            this.dgvestoque = new System.Windows.Forms.DataGridView();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvestoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvestoque
            // 
            this.dgvestoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvestoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestoque.Location = new System.Drawing.Point(34, 80);
            this.dgvestoque.Name = "dgvestoque";
            this.dgvestoque.Size = new System.Drawing.Size(450, 306);
            this.dgvestoque.TabIndex = 0;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(222, 392);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 1;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 447);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.dgvestoque);
            this.Name = "Estoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvestoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvestoque;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Timer timer1;
    }
}