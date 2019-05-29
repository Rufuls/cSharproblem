using System;
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
    public partial class Pedidoatt : Form
    { }
}
       /* public Pedidoatt()
        {
            



                    /*private void bttatt_Click(object sender, EventArgs e)
                    {

                        string strconexao = @"Server = localhost; Database = dbsistema;
                          Uid = Miranha; Pwd = 123";
                        string strSql = "SELECT * FROM tbusuarios";
                        MySqlConnection con = new MySqlConnection(strconexao);
                        MySqlCommand cmd = new MySqlCommand(strSql, con);
                        con.Open();
                        cmd.CommandType = CommandType.Text;
                        MySqlDataReader dr = cmd.ExecuteReader();
                        int nColunas = dr.FieldCount;
                        for (int i = 0; i < nColunas; i++)

                            dgvpedidos.Columns.Add(dr.GetName(i).ToString(), dr.GetName(i).ToString());
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
                                    linhaDados[a] = dr.GetDateTime(a).ToString();


                }


            }
            dgvpedidos.Rows.Add(linhaDados);


        }
    }
}

       /* private void Pedidoatt_Load(object sender, EventArgs e)
        {
            
        }
    }*/

        
