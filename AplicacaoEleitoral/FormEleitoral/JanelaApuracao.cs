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
    public partial class JanelaApuracao : Form
    {
        private List<int> resultadoVotacao = new List<int>(6);
        public JanelaApuracao()
        {
            InitializeComponent();
            this.resultadoVotacao = JanelaUrnaVotacao.instancia.getVotosCandidatos();
            //Vencedor - Nome e Votos
            this.lblNomeCandidatoVencedor.Text = encontraNomeVencedor(this.resultadoVotacao);
            this.lblValorVotosVencedor.Text = this.resultadoVotacao.Max().ToString();
            //Nulo - Valor e Porcentagem
            this.lblValorVotosNulo.Text = resultadoVotacao[4].ToString();
            this.lblApuracaoPorCentoNulo.Text = calculaPorcentagem(4).ToString("F") + "%";
            //Branco - Valor e Porcentagem
            this.lblValorVotosBranco.Text = resultadoVotacao[5].ToString();
            this.lblApuracaoPorCentoBranco.Text = calculaPorcentagem(5).ToString("F") + "%";
        }

        private float calculaPorcentagem(int indexCandidato)
        {
            float totalVotacao = this.resultadoVotacao.Sum();
            float resultadoPorcentagem = (this.resultadoVotacao[indexCandidato] / totalVotacao) * 100;
            return resultadoPorcentagem;
        }
        private string encontraNomeVencedor(List<int> listaResultado)
        {
            int votosGanhador = listaResultado.Max();
            int indexGanhador = listaResultado.FindIndex(item => item == votosGanhador);
            string ganhadorVotacao="";
            
            switch (indexGanhador)
            {
                case 0:
                    ganhadorVotacao = "Jar Jar Binks";
                    break;
                case 1:
                    ganhadorVotacao = "Darth Vader";
                    break;
                case 2:
                    ganhadorVotacao = "Senadora Padmé";
                    break;
                case 3:
                    ganhadorVotacao = "Mestre Yoda";
                    break;
                default:
                    ganhadorVotacao = "Segundo Turno";
                    break;
            }
            return ganhadorVotacao;
        }
    }
    
    
}
