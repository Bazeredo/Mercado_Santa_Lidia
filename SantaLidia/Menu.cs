using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SantaLidia
{
    public partial class Menu : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataReader dr;

        string strSQL;

        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       
         

    }
}
