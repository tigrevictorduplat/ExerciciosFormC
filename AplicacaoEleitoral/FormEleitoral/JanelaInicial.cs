using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FormEleitoral
{
    public partial class JanelaInicial : Form
    {
        Thread th;
        public JanelaInicial()
        {
            InitializeComponent();
        }
        private void abrirJanela()
        {
            Application.Run(new JanelaUrnaVotacao());
        }
        private void btColinha_Click(object sender, EventArgs e)
        {
            JanelaColinha janelaColinha = new JanelaColinha();
            janelaColinha.ShowDialog();
        }

        private void btComecar_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(abrirJanela);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

    }
}
