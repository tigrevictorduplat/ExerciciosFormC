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
    public partial class JanelaInicial : Form
    {
        public JanelaInicial()
        {
            InitializeComponent();
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            JanelaFatorial janelaFatorial = new JanelaFatorial();          
            janelaFatorial.ShowDialog();
    
            
        }

        private void btnMultiplos_Click(object sender, EventArgs e)
        {
            JanelaMultiplos janelaMultiplos = new JanelaMultiplos();
            janelaMultiplos.ShowDialog();
        }

        private void btnConversor_Click(object sender, EventArgs e)
        {
            JanelaConversor janelaConversor = new JanelaConversor();
            janelaConversor.ShowDialog();
        }
    }
}
