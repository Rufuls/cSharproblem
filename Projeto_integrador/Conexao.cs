﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Projeto_integrador
{
    class Conexao
    {
        private static string strconexao =
            @"Server = 10.23.49.33; Database = bd_agp;
              Uid = zangado; Pwd = agp321";
        private static MySqlConnection Cn = new MySqlConnection(strconexao);

        public static MySqlConnection abreConexao()
        {
            try
            {
                if (Cn.State.ToString() == "Closed")
                {
                    Cn.Open();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Cn;
        }

        public static void fechaConexao()
        {
            try
            {
                if (Cn.State.ToString() == "Open")
                {
                    Cn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
