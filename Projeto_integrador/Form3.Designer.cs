namespace Projeto_integrador
{
    partial class Formfunc
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
            this.btnFunc1 = new System.Windows.Forms.Button();
            this.btnfunc2 = new System.Windows.Forms.Button();
            this.btnfunc3 = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFunc1
            // 
            this.btnFunc1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFunc1.Location = new System.Drawing.Point(12, 76);
            this.btnFunc1.Name = "btnFunc1";
            this.btnFunc1.Size = new System.Drawing.Size(99, 23);
            this.btnFunc1.TabIndex = 0;
            this.btnFunc1.Text = "Funcionario1";
            this.btnFunc1.UseVisualStyleBackColor = true;
            this.btnFunc1.Click += new System.EventHandler(this.btnFunc1_Click);
            // 
            // btnfunc2
            // 
            this.btnfunc2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnfunc2.Location = new System.Drawing.Point(12, 150);
            this.btnfunc2.Name = "btnfunc2";
            this.btnfunc2.Size = new System.Drawing.Size(99, 23);
            this.btnfunc2.TabIndex = 1;
            this.btnfunc2.Text = "Funcionario2";
            this.btnfunc2.UseVisualStyleBackColor = true;
            this.btnfunc2.Click += new System.EventHandler(this.btnfunc2_Click);
            // 
            // btnfunc3
            // 
            this.btnfunc3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnfunc3.Location = new System.Drawing.Point(12, 224);
            this.btnfunc3.Name = "btnfunc3";
            this.btnfunc3.Size = new System.Drawing.Size(99, 23);
            this.btnfunc3.TabIndex = 2;
            this.btnfunc3.Text = "Funcionario3";
            this.btnfunc3.UseVisualStyleBackColor = true;
            this.btnfunc3.Click += new System.EventHandler(this.btnfunc3_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnvoltar.Location = new System.Drawing.Point(12, 290);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(99, 23);
            this.btnvoltar.TabIndex = 3;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Formfunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(123, 325);
            this.ControlBox = false;
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnfunc3);
            this.Controls.Add(this.btnfunc2);
            this.Controls.Add(this.btnFunc1);
            this.Name = "Formfunc";
            this.Text = "Funcionarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFunc1;
        private System.Windows.Forms.Button btnfunc2;
        private System.Windows.Forms.Button btnfunc3;
        private System.Windows.Forms.Button btnvoltar;
    }
}