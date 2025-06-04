using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace tbTest
{
    public partial class Form1: Form
    {
        public static SqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;\r\n\r\n");
                conexao.Open();
                MessageBox.Show("Conectado!!!");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados = " + ex.Message);
                throw ex;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Outro Erro = " + ex.Message);
                throw ex;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
