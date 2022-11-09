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
        private int[] resultadoVotacao = {0,0,0,0,0,0};
        public JanelaApuracao()
        {
            InitializeComponent();
          
            //Vencedor - Nome e Votos
            this.lblNomeCandidatoVencedor.Text = encontraNomeVencedor(resultadoVotacao);
            int indexVencedor = calculaIndexVencedor(resultadoVotacao);
            this.lblValorVotosVencedor.Text = resultadoVotacao[indexVencedor].ToString();
            //Nulo - Valor e Porcentagem
            this.lblValorVotosNulo.Text = resultadoVotacao[4].ToString();
            this.lblApuracaoPorCentoNulo.Text = calculaPorcentagem(4).ToString("F");
            //Branco - Valor e Porcentagem
            this.lblValorVotosBranco.Text = resultadoVotacao[5].ToString();
            this.lblApuracaoPorCentoBranco.Text = calculaPorcentagem(5).ToString("F");
        }

        private double calculaPorcentagem(int indexArray)
        {
            int somaVotos = 1;
            for (int i = 0; i < this.resultadoVotacao.Length; i++)
            {
                somaVotos += resultadoVotacao[i];
            }
            double resultadoPorcentagem = this.resultadoVotacao[indexArray]/(somaVotos);
            return resultadoPorcentagem;
        }
        private int calculaIndexVencedor(int[] arrayResultado)
        {
            int indexMaiorResultado = -1;
            for (int i = 0; i < (arrayResultado.Length - 1); i++)
            {
                indexMaiorResultado = (arrayResultado[i] >= arrayResultado[i + 1]) ? i : i + 1;
            }
            return indexMaiorResultado;
        }
        private string encontraNomeVencedor(int[] arrayResultado)
        {
            string ganhadorVotacao="";
            switch (calculaIndexVencedor(arrayResultado))
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
        public void recebeArrayVotos(int[] votoArray)
        {
            this.resultadoVotacao = votoArray;
        }
    }
    
    
}
