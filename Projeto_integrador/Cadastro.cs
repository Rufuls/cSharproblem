﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_integrador
{
    public partial class Cadastro : MaterialSkin.Controls.MaterialForm
    {
        public Cadastro()
        {
            InitializeComponent();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region método modifica

        private void modifica(string sql)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();

            try
            {
                if (MessageBox.Show("Deseja executar está ação", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Ação realizada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao realiza está ação!");
                    }

                    cmd.Dispose();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }
        #endregion

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string sexo = null;
            string data = (dtp.Value).ToString("yyyy/MM/dd");

            //dtp.Format = DateTimePickerFormat.Custom;
            //// Display the date as "Mon 27 Feb 2012".  
            //dtp.CustomFormat = "yyyy/MM/dd";
            if (rbm.Checked)
            {
                sexo = "M";
            }
            else
            {
                sexo = "F";
            }
            if (txtresenha.Text == txtSenha.Text)
            {
                string Cadastrar = String.Format("INSERT INTO tb_funcionarios VALUES (default,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", txtnome.Text, txtsbn.Text, data, txtend.Text , txtrg.Text, txtcpf.Text, sexo, txtTel.Text , txtcarg.Text, txtemail.Text, txtlogin.Text, txtSenha.Text);
                MessageBox.Show(Cadastrar);
                modifica(Cadastrar);
            }
            else
            {
                MessageBox.Show("Senhas Diferentes");
            }
        }
    }
}
