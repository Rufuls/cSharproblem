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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.dgvestoque = new System.Windows.Forms.DataGridView();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtpro = new System.Windows.Forms.TextBox();
            this.lblprod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numuni = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvestoque
            // 
            this.dgvestoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvestoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestoque.Location = new System.Drawing.Point(360, 80);
            this.dgvestoque.Name = "dgvestoque";
            this.dgvestoque.Size = new System.Drawing.Size(320, 306);
            this.dgvestoque.TabIndex = 0;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(475, 392);
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
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(124, 363);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtpro
            // 
            this.txtpro.Location = new System.Drawing.Point(136, 137);
            this.txtpro.Name = "txtpro";
            this.txtpro.Size = new System.Drawing.Size(120, 20);
            this.txtpro.TabIndex = 3;
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.BackColor = System.Drawing.Color.Transparent;
            this.lblprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprod.Location = new System.Drawing.Point(38, 140);
            this.lblprod.Name = "lblprod";
            this.lblprod.Size = new System.Drawing.Size(76, 17);
            this.lblprod.TabIndex = 4;
            this.lblprod.Text = "Produto -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unidade";
            // 
            // numuni
            // 
            this.numuni.Location = new System.Drawing.Point(136, 184);
            this.numuni.Name = "numuni";
            this.numuni.Size = new System.Drawing.Size(120, 20);
            this.numuni.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reabastecer";
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numuni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblprod);
            this.Controls.Add(this.txtpro);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.dgvestoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvestoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvestoque;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtpro;
        private System.Windows.Forms.Label lblprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numuni;
        private System.Windows.Forms.Label label2;
    }
}