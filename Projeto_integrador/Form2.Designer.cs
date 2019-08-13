namespace Projeto_integrador
{
    partial class frmPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            this.dgvatt = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnaltfun = new System.Windows.Forms.Button();
            this.btnfaturamento = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.textfunc1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.atttable = new System.Windows.Forms.Timer(this.components);
            this.ppdfatu = new System.Windows.Forms.PrintPreviewDialog();
            this.pdc_imprimir = new System.Drawing.Printing.PrintDocument();
            this.btnentregue = new System.Windows.Forms.Button();
            this.btnsaiu = new System.Windows.Forms.Button();
            this.btnpendente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvatt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvatt
            // 
            this.dgvatt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvatt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvatt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvatt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvatt.Location = new System.Drawing.Point(71, 76);
            this.dgvatt.Name = "dgvatt";
            this.dgvatt.Size = new System.Drawing.Size(518, 206);
            this.dgvatt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pedidos";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Funcionarios";
            // 
            // btnaltfun
            // 
            this.btnaltfun.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnaltfun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaltfun.Location = new System.Drawing.Point(639, 252);
            this.btnaltfun.Name = "btnaltfun";
            this.btnaltfun.Size = new System.Drawing.Size(95, 30);
            this.btnaltfun.TabIndex = 6;
            this.btnaltfun.Text = "Alterar";
            this.btnaltfun.UseVisualStyleBackColor = true;
            this.btnaltfun.Click += new System.EventHandler(this.btnaltfun_Click);
            // 
            // btnfaturamento
            // 
            this.btnfaturamento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnfaturamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfaturamento.Location = new System.Drawing.Point(218, 290);
            this.btnfaturamento.Name = "btnfaturamento";
            this.btnfaturamento.Size = new System.Drawing.Size(142, 31);
            this.btnfaturamento.TabIndex = 11;
            this.btnfaturamento.Text = "Faturamento";
            this.btnfaturamento.UseVisualStyleBackColor = true;
            this.btnfaturamento.Click += new System.EventHandler(this.btnfaturamento_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Location = new System.Drawing.Point(357, 290);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(141, 31);
            this.btnEstoque.TabIndex = 13;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(71, 290);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 31);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // textfunc1
            // 
            this.textfunc1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textfunc1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textfunc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textfunc1.Location = new System.Drawing.Point(634, 76);
            this.textfunc1.Name = "textfunc1";
            this.textfunc1.ReadOnly = true;
            this.textfunc1.Size = new System.Drawing.Size(100, 23);
            this.textfunc1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(634, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(634, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 19;
            // 
            // atttable
            // 
            this.atttable.Enabled = true;
            this.atttable.Interval = 5000;
            this.atttable.Tick += new System.EventHandler(this.atttable_Tick);
            // 
            // ppdfatu
            // 
            this.ppdfatu.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdfatu.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdfatu.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdfatu.Document = this.pdc_imprimir;
            this.ppdfatu.Enabled = true;
            this.ppdfatu.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdfatu.Icon")));
            this.ppdfatu.Name = "ppdfatu";
            this.ppdfatu.Visible = false;
            // 
            // pdc_imprimir
            // 
            this.pdc_imprimir.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdc_imprimir_PrintPage);
            // 
            // btnentregue
            // 
            this.btnentregue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnentregue.BackColor = System.Drawing.Color.Lime;
            this.btnentregue.Location = new System.Drawing.Point(595, 76);
            this.btnentregue.Name = "btnentregue";
            this.btnentregue.Size = new System.Drawing.Size(30, 30);
            this.btnentregue.TabIndex = 20;
            this.btnentregue.Text = "   ";
            this.btnentregue.UseVisualStyleBackColor = false;
            this.btnentregue.Click += new System.EventHandler(this.btnentregue_Click);
            // 
            // btnsaiu
            // 
            this.btnsaiu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsaiu.BackColor = System.Drawing.Color.Yellow;
            this.btnsaiu.Location = new System.Drawing.Point(595, 135);
            this.btnsaiu.Name = "btnsaiu";
            this.btnsaiu.Size = new System.Drawing.Size(30, 30);
            this.btnsaiu.TabIndex = 21;
            this.btnsaiu.UseVisualStyleBackColor = false;
            this.btnsaiu.Click += new System.EventHandler(this.btnsaiu_Click);
            // 
            // btnpendente
            // 
            this.btnpendente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpendente.BackColor = System.Drawing.Color.Red;
            this.btnpendente.Location = new System.Drawing.Point(595, 196);
            this.btnpendente.Name = "btnpendente";
            this.btnpendente.Size = new System.Drawing.Size(30, 30);
            this.btnpendente.TabIndex = 22;
            this.btnpendente.UseVisualStyleBackColor = false;
            this.btnpendente.Click += new System.EventHandler(this.btnpendente_Click);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(806, 366);
            this.Controls.Add(this.btnpendente);
            this.Controls.Add(this.btnsaiu);
            this.Controls.Add(this.btnentregue);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textfunc1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnfaturamento);
            this.Controls.Add(this.btnaltfun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvatt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvatt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvatt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnaltfun;
        private System.Windows.Forms.Button btnfaturamento;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textfunc1;
        private System.Windows.Forms.Timer atttable;
        private System.Windows.Forms.PrintPreviewDialog ppdfatu;
        private System.Drawing.Printing.PrintDocument pdc_imprimir;
        private System.Windows.Forms.Button btnentregue;
        private System.Windows.Forms.Button btnsaiu;
        private System.Windows.Forms.Button btnpendente;
    }
}