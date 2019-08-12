using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MySql.Data.MySqlClient;

namespace Projeto_integrador
{
    public partial class frmLogin : MaterialSkin.Controls.MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
            MaterialSkinManager tema = MaterialSkinManager.Instance;
            tema.AddFormToManage(this);
            tema.Theme = MaterialSkinManager.Themes.DARK; 

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
            cmd.CommandText = String.Format("SELECT * FROM tb_funcionarios WHERE login_func LIKE '{0}' and senha_func LIKE '{1}'", txtLogin.Text, txtSenha.Text);
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

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }

        }
    }
}