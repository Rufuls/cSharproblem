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

        private void timer1_Tick(object sender, EventArgs e)
        {
            dgvestoque.DataSource = null;
            //dgvatt.Rows.Clear();
            dgvestoque.Columns.Clear();
            dgvestoque.Refresh();

            string strconexao = @"Server = localhost; Database = dbsistema;
              Uid = Miranha; Pwd = 123";
            string strSql = "SELECT * FROM tbestoque";
            MySqlConnection con = new MySqlConnection(strconexao);
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable tbusuarios = new DataTable();
            da.Fill(tbusuarios);
            dgvestoque.DataSource = tbusuarios;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
