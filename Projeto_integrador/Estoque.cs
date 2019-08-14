using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_integrador
{
    public partial class Estoque : MaterialSkin.Controls.MaterialForm
    {
        public Estoque()
        {
            InitializeComponent();
        }

        #region método Modifica (para Update, Delete e Insert)
        private void Modifica(string sql)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            try
            {
                if (MessageBox.Show("Deseja executar esta ação?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Ação realizada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao realizar esta ação!");
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            dgvestoque.DataSource = null;
            //dgvatt.Rows.Clear();
            dgvestoque.Columns.Clear();
            dgvestoque.Refresh();

            string strconexao = @"Server = 10.23.49.33; Database = bd_agp;
              Uid = zangado; Pwd = agp321";
            string strSql = "SELECT * FROM tb_estoque";
            MySqlConnection con = new MySqlConnection(strconexao);
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable tb_estoque = new DataTable();
            da.Fill(tb_estoque);
            dgvestoque.DataSource = tb_estoque;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string inserir = null;

                inserir = String.Format("INSERT INTO tb_estoque VALUES (default, '{0}', '{1}', '{2}','{3}')", txtpro.Text, txtmarc.Text, numuni.Value, txtmoney.Text);
                
                Modifica(inserir);
            
            
        }

        private void txtpro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtatt_Click(object sender, EventArgs e)
        {
            string atualiza = String.Format("UPDATE tb_estoque SET nome_prod= '{0}',marca_prod= '{1}', qtd_prod= '{2}', preco_prod= '{3}' WHERE Nome_prod = '{0}' AND marca_prod ='{1}'", txtpro.Text, txtmarc.Text, numuni.Value, txtmoney.Text);
            
            Modifica(atualiza);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string apaga = String.Format("Delete From tb_estoque Where cod_prod = '{0}'", txtdel.Text);
            Modifica(apaga);
        }
    }
}