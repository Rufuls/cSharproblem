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
                if (MessageBox.Show("Deseja executar esta ação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            string strSql = "SELECT * FROM tbestoque";
            MySqlConnection con = new MySqlConnection(strconexao);
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable tbestoque = new DataTable();
            da.Fill(tbestoque);
            dgvestoque.DataSource = tbestoque;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string cadastro = String.Format("INSERT INTO tbEstoque VALUES ('{1}','{2}','{3}')",txtpro.Text, txtmarc.Text, numuni.Value);
            MessageBox.Show(cadastro);
            Modifica(cadastro);
        }
    }
}
