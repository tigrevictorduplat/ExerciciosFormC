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
        private List<int> resultadoVotacao;
        public JanelaApuracao()
        {
            InitializeComponent();
          
            //Vencedor - Nome e Votos
            this.lblNomeCandidatoVencedor.Text = encontraNomeVencedor(resultadoVotacao);
            this.lblValorVotosVencedor.Text = resultadoVotacao.Max().ToString();
            //Nulo - Valor e Porcentagem
            this.lblValorVotosNulo.Text = resultadoVotacao[4].ToString();
            this.lblApuracaoPorCentoNulo.Text = calculaPorcentagem(4).ToString("F");
            //Branco - Valor e Porcentagem
            this.lblValorVotosBranco.Text = resultadoVotacao[5].ToString();
            this.lblApuracaoPorCentoBranco.Text = calculaPorcentagem(5).ToString("F");
        }

        private double calculaPorcentagem(int indexCandidato)
        {
            double resultadoPorcentagem = this.resultadoVotacao[indexCandidato] / this.resultadoVotacao.Sum();
            return resultadoPorcentagem;
        }
        private string encontraNomeVencedor(List<int> listaResultado)
        {
            int indexGanhador = this.resultadoVotacao.FindIndex(item => item == resultadoVotacao.Max());
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
        public void recebeArrayVotos(List<int> votoList)
        {
            this.resultadoVotacao = votoList;
        }
    }
    
    
}
