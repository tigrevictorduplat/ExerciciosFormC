using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoATV3
{
    public partial class JanelaResultadoTabela : Form
    {
        public JanelaResultadoTabela()
        {
            InitializeComponent();
        }
        public void setDadosTabela(DataTable dados)
        {
            this.dataGridView.DataSource = dados;
        }

    }
}
