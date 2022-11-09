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
        private int[] votoParcialCandidatos = { 0, 0, 0, 0, 0, 0 };
        public ConfirmacaoVoto()
        {
            InitializeComponent();
        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {
            JanelaApuracao janelaApuracao = new JanelaApuracao();
            JanelaTeste teste = new JanelaTeste();
            teste.mudaTexto(votoParcialCandidatos[0].ToString());
            teste.ShowDialog();
            teste.mudaTexto(votoParcialCandidatos[1].ToString());
            teste.ShowDialog();
            teste.mudaTexto(votoParcialCandidatos[2].ToString());
            teste.ShowDialog();
            teste.mudaTexto(votoParcialCandidatos[3].ToString());
            teste.ShowDialog();
            teste.mudaTexto(votoParcialCandidatos[4].ToString());
            teste.ShowDialog();
            teste.mudaTexto(votoParcialCandidatos[5].ToString());
            teste.ShowDialog();
            janelaApuracao.recebeArrayVotos(votoParcialCandidatos);
            janelaApuracao.ShowDialog();

        } 
        public void recebeArrayVotos(int[] votoArray)
        {
            this.votoParcialCandidatos = votoArray;
        }
    }
}
