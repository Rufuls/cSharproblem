﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_integrador
{





    public partial class frmPedidos : MaterialSkin.Controls.MaterialForm
    {
        public frmPedidos()
        {
            InitializeComponent();
            this.dgvatt.CellFormatting += Dgvatt_CellFormatting;



        }

        private void Dgvatt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.Equals("Cancelado"))

            {

                dgvatt.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;

            }

            if (e.Value != null && e.Value.Equals("Entregue"))
            {
                dgvatt.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }

            if (e.Value != null && e.Value.Equals("Pendente"))

            {
                dgvatt.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnaltfun_Click(object sender, EventArgs e)
        {
            Formfunc frmPA = new Formfunc();
            frmPA.Show();

            btnaltfun.Enabled = false;


            {
                btnaltfun.Enabled = true;
            }

        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            {
                
               
               
                
               

            }
            
        }


        private void atttable_Tick(object sender, EventArgs e)
        {
            atualizadgvatt();
        }

        private void atualizadgvatt()
        {
            dgvatt.DataSource = null;
            //dgvatt.Rows.Clear();
            dgvatt.Columns.Clear();
            dgvatt.Refresh();

            string strconexao = @"Server = 10.23.49.33; Database = bd_agp;
              Uid = zangado; Pwd = agp321";
            string strSql = "SELECT * FROM tbvendas";
            MySqlConnection con = new MySqlConnection(strconexao);
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable tbvendas = new DataTable();
            da.Fill(tbvendas);

            dgvatt.DataSource = tbvendas;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque frmes = new Estoque();
            
            frmes.ShowDialog();
            

        }

        private void btnfaturamento_Click(object sender, EventArgs e)
        {
            ppdfatu.ShowDialog();
        }

        private void pdc_imprimir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            {

                int X = 50;
                int Y = 50;

                Font minhafonte = new Font("Arial", 14, FontStyle.Bold);
                e.Graphics.DrawString(this.Text, minhafonte, Brushes.Blue, X, Y);
                e.Graphics.DrawString(DateTime.Now.ToString(), minhafonte, Brushes.Blue, X + 500, Y);
                minhafonte = new Font("Arial", 12, FontStyle.Bold);

                Y = Y + 100;
                e.Graphics.DrawString("Numero de vendas", minhafonte, Brushes.Black, X, Y);
                e.Graphics.DrawString("Itens", minhafonte, Brushes.Black, X + 250, Y);
                e.Graphics.DrawString("Faturamento", minhafonte, Brushes.Black, X + 400, Y);
                e.Graphics.DrawString("Total", minhafonte, Brushes.Black, X + 650, Y);

                minhafonte = new Font("Arial", 12, FontStyle.Regular);

                string consulta = "SELECT * FROM tbvendas ";

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = consulta;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = Conexao.abreConexao();

                MySqlDataReader DR;

                try
                {
                    DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        Y = Y + 30;
                        decimal valorTotal = Convert.ToDecimal(DR.GetValue(1)) * Convert.ToDecimal(DR.GetValue(2));
                        e.Graphics.DrawString(DR.GetValue(0).ToString(), minhafonte, Brushes.Black, X, Y);
                        e.Graphics.DrawString(DR.GetValue(1).ToString(), minhafonte, Brushes.Black, X + 250, Y);
                        e.Graphics.DrawString(DR.GetValue(2).ToString(), minhafonte, Brushes.Black, X + 400, Y);
                        e.Graphics.DrawString(valorTotal.ToString(), minhafonte, Brushes.Black, X + 650, Y);
                    }
                    DR.Close();
                    cmd.Dispose();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexao.fechaConexao();
                }
            }
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


        private void btnpendente_Click(object sender, EventArgs e)
        {
            int codigopedido = Convert.ToInt32(dgvatt.CurrentRow.Cells[0].Value);
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = String.Format("update tbvendas set Status = 'Cancelado' where cod_compra = {0}", codigopedido);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            int result = cmd.ExecuteNonQuery();
            atualizadgvatt();
        }

        private void btnentregue_Click(object sender, EventArgs e)
        {
            int codigopedido = Convert.ToInt32(dgvatt.CurrentRow.Cells[0].Value);
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = String.Format("update tbvendas set Status = 'Entregue' where cod_compra = {0}", codigopedido);
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            int result = cmd.ExecuteNonQuery();
            atualizadgvatt();
            
        }

        private void btnsaiu_Click(object sender, EventArgs e)
        {
            int codigopedido = Convert.ToInt32(dgvatt.CurrentRow.Cells[0].Value);
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = String.Format("update tbvendas set Status = 'Pendente' where cod_compra = {0}", codigopedido);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            int result = cmd.ExecuteNonQuery();
            atualizadgvatt();
        }
    }
}
