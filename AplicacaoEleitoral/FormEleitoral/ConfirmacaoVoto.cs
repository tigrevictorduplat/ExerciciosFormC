using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEleitoral
{
    public partial class ConfirmacaoVoto : Form
    {
        private int[] resultadoVotacao;
        public ConfirmacaoVoto()
        {
            InitializeComponent();
        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {
          JanelaApuracao janelaApuracao = new JanelaApuracao();
            janelaApuracao.setResultado(resultadoVotacao);
            janelaApuracao.ShowDialog();
            
        }

        public void setResultado(int[] arrayResultado)
        {
            this.resultadoVotacao = arrayResultado;
        }
    }
}
