﻿namespace Projeto_integrador
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmarc = new System.Windows.Forms.TextBox();
            this.numuni = new System.Windows.Forms.NumericUpDown();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtatt = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.txtdel = new System.Windows.Forms.TextBox();
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
            this.dgvestoque.Size = new System.Drawing.Size(566, 306);
            this.dgvestoque.TabIndex = 0;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(598, 392);
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
            this.btnInserir.Location = new System.Drawing.Point(42, 392);
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
            this.txtpro.TextChanged += new System.EventHandler(this.txtpro_TextChanged);
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.BackColor = System.Drawing.Color.Transparent;
            this.lblprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprod.ForeColor = System.Drawing.Color.Silver;
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
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(38, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unidade -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(64, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reabastecer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(38, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca -";
            // 
            // txtmarc
            // 
            this.txtmarc.Location = new System.Drawing.Point(136, 178);
            this.txtmarc.Name = "txtmarc";
            this.txtmarc.Size = new System.Drawing.Size(120, 20);
            this.txtmarc.TabIndex = 9;
            // 
            // numuni
            // 
            this.numuni.Location = new System.Drawing.Point(136, 223);
            this.numuni.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numuni.Name = "numuni";
            this.numuni.Size = new System.Drawing.Size(120, 20);
            this.numuni.TabIndex = 6;
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(136, 262);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(120, 20);
            this.txtmoney.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(38, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preço -";
            // 
            // txtatt
            // 
            this.txtatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtatt.Location = new System.Drawing.Point(241, 392);
            this.txtatt.Name = "txtatt";
            this.txtatt.Size = new System.Drawing.Size(80, 23);
            this.txtatt.TabIndex = 12;
            this.txtatt.Text = "Atualizar";
            this.txtatt.UseVisualStyleBackColor = true;
            this.txtatt.Click += new System.EventHandler(this.txtatt_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Transparent;
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Image = ((System.Drawing.Image)(resources.GetObject("btndel.Image")));
            this.btndel.Location = new System.Drawing.Point(41, 298);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(58, 55);
            this.btndel.TabIndex = 13;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // txtdel
            // 
            this.txtdel.Location = new System.Drawing.Point(136, 317);
            this.txtdel.Name = "txtdel";
            this.txtdel.Size = new System.Drawing.Size(48, 20);
            this.txtdel.TabIndex = 14;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 447);
            this.Controls.Add(this.txtdel);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.txtatt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmoney);
            this.Controls.Add(this.txtmarc);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmarc;
        private System.Windows.Forms.NumericUpDown numuni;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txtatt;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.TextBox txtdel;
    }
}