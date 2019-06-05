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
    public partial class frmLogin : MaterialSkin.Controls.MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region Método pesquisa (para Botão de Entrar)

        private void pesquisa(string consulta)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = consulta;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            MySqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtLogin.Text = dr["Login"].ToString();
                    txtSenha.Text = dr["Senha"].ToString();

                }

                dr.Close();
                cmd.Dispose();
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
            Cadastro frmPA = new Cadastro();
            frmPA.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = String.Format(
                "SELECT * FROM tbusuarios WHERE Login LIKE '{0}' and Senha LIKE '{1}'", txtLogin.Text, txtSenha.Text);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            MySqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    frmPedidos frmPA = new frmPedidos();
                    frmPA.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não Existente");
                }

                cmd.Dispose();
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
    }
}