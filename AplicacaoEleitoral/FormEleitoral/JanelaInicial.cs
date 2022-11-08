using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEleitoral
{
    public partial class JanelaInicial : Form
    {
        public JanelaInicial()
        {
            InitializeComponent();
        }

        private void btColinha_Click(object sender, EventArgs e)
        {
            JanelaColinha janelaColinha = new JanelaColinha();
            janelaColinha.ShowDialog();
        }
    }
}
