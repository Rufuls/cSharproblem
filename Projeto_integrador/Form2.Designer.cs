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
            this.btnfaturamento = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.atttable = new System.Windows.Forms.Timer(this.components);
            this.ppdfatu = new System.Windows.Forms.PrintPreviewDialog();
            this.pdc_imprimir = new System.Drawing.Printing.PrintDocument();
            this.btnentregue = new System.Windows.Forms.Button();
            this.btnsaiu = new System.Windows.Forms.Button();
            this.btnpendente = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnatt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvatt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvatt
            // 
            this.dgvatt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvatt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvatt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvatt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvatt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvatt.Location = new System.Drawing.Point(143, 76);
            this.dgvatt.Name = "dgvatt";
            this.dgvatt.Size = new System.Drawing.Size(536, 264);
            this.dgvatt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pedidos";
            // 
            // btnfaturamento
            // 
            this.btnfaturamento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnfaturamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfaturamento.Location = new System.Drawing.Point(248, 348);
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
            this.btnEstoque.Location = new System.Drawing.Point(387, 348);
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
            this.btnSair.Location = new System.Drawing.Point(33, 381);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 31);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // atttable
            // 
            this.atttable.Enabled = true;
            this.atttable.Interval = 10000;
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
            this.btnentregue.AutoSize = true;
            this.btnentregue.BackColor = System.Drawing.Color.Green;
            this.btnentregue.Location = new System.Drawing.Point(722, 76);
            this.btnentregue.Name = "btnentregue";
            this.btnentregue.Size = new System.Drawing.Size(60, 30);
            this.btnentregue.TabIndex = 20;
            this.btnentregue.Text = "Entregue";
            this.btnentregue.UseVisualStyleBackColor = false;
            this.btnentregue.Click += new System.EventHandler(this.btnentregue_Click);
            // 
            // btnsaiu
            // 
            this.btnsaiu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsaiu.AutoSize = true;
            this.btnsaiu.BackColor = System.Drawing.Color.Yellow;
            this.btnsaiu.Location = new System.Drawing.Point(719, 134);
            this.btnsaiu.Name = "btnsaiu";
            this.btnsaiu.Size = new System.Drawing.Size(63, 30);
            this.btnsaiu.TabIndex = 21;
            this.btnsaiu.Text = "Pendente";
            this.btnsaiu.UseVisualStyleBackColor = false;
            this.btnsaiu.Click += new System.EventHandler(this.btnsaiu_Click);
            // 
            // btnpendente
            // 
            this.btnpendente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpendente.AutoSize = true;
            this.btnpendente.BackColor = System.Drawing.Color.Red;
            this.btnpendente.Location = new System.Drawing.Point(714, 193);
            this.btnpendente.Name = "btnpendente";
            this.btnpendente.Size = new System.Drawing.Size(68, 30);
            this.btnpendente.TabIndex = 22;
            this.btnpendente.Text = "Cancelado";
            this.btnpendente.UseVisualStyleBackColor = false;
            this.btnpendente.Click += new System.EventHandler(this.btnpendente_Click);
            // 
            // btndel
            // 
            this.btndel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btndel.BackColor = System.Drawing.Color.Transparent;
            this.btndel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.ForeColor = System.Drawing.Color.Transparent;
            this.btndel.Image = ((System.Drawing.Image)(resources.GetObject("btndel.Image")));
            this.btndel.Location = new System.Drawing.Point(722, 262);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(47, 46);
            this.btndel.TabIndex = 23;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnatt
            // 
            this.btnatt.AutoSize = true;
            this.btnatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatt.Location = new System.Drawing.Point(-1, 193);
            this.btnatt.Name = "btnatt";
            this.btnatt.Size = new System.Drawing.Size(138, 27);
            this.btnatt.TabIndex = 24;
            this.btnatt.Text = "Atualizar Rapido";
            this.btnatt.UseVisualStyleBackColor = true;
            this.btnatt.Click += new System.EventHandler(this.btnatt_Click);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(867, 424);
            this.ControlBox = false;
            this.Controls.Add(this.btnatt);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnpendente);
            this.Controls.Add(this.btnsaiu);
            this.Controls.Add(this.btnentregue);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnfaturamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvatt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvatt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvatt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnfaturamento;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer atttable;
        private System.Windows.Forms.PrintPreviewDialog ppdfatu;
        private System.Drawing.Printing.PrintDocument pdc_imprimir;
        private System.Windows.Forms.Button btnentregue;
        private System.Windows.Forms.Button btnsaiu;
        private System.Windows.Forms.Button btnpendente;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnatt;
    }
}