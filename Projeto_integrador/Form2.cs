using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_integrador
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
            
            
        }

        public frmPedidos(string text)
        {
            
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedidoatt frmPA = new Pedidoatt();
            frmPA.ShowDialog();
        }

        private void btnaltfun_Click(object sender, EventArgs e)
        {
            Formfunc frmPA = new Formfunc();
            frmPA.ShowDialog();
            
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {

        }

        private void atttable_Tick(object sender, EventArgs e)
        {

           dgvatt.DataSource = null;
            //dgvatt.Rows.Clear();
            dgvatt.Columns.Clear();
            dgvatt.Refresh();

            string strconexao = @"Server = localhost; Database = dbsistema;
              Uid = Miranha; Pwd = 123";
            string strSql = "SELECT * FROM tbusuarios";
            MySqlConnection con = new MySqlConnection(strconexao);
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable tbusuarios = new DataTable();
            da.Fill(tbusuarios);
            dgvatt.DataSource = tbusuarios;

            /*MySqlDataReader dr = cmd.ExecuteReader();
            int nColunas = dr.FieldCount;
            for (int i = 0; i < nColunas; i++)

                dgvatt.Columns.Add(dr.GetName(i).ToString(), dr.GetName(i).ToString());
            string[] linhaDados = new string[nColunas];

            while (dr.Read())
            {
                for (int a = 0; a < nColunas; a++)
                {
                    if (dr.GetFieldType(a).ToString() == "System.Int32")
                    {

                        linhaDados[a] = dr.GetInt32(a).ToString();
                    }
                    if (dr.GetFieldType(a).ToString() == "System.String")
                    {
                        linhaDados[a] = dr.GetString(a).ToString();
                    }
                    if (dr.GetFieldType(a).ToString() == "System.DateTime")
                    {
                        linhaDados[a] = dr.GetDateTime(a).ToString();*/


                    }
                }

            }

            /*dgvatt.Rows.Add(linhaDados);

        }
    }
}*/
