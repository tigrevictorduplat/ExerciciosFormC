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
    public partial class JanelaMultiplos : Form
    {
        public JanelaMultiplos()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //Instância da Janela
            JanelaResultado janelaResultado = new JanelaResultado();
            //Calculo
            int primeiroNumero = Convert.ToInt32(txtBoxPrimeiroNumero.Text);
            int segundoNumero = Convert.ToInt32(txtBoxSegundoNumero.Text);
            int comecoIntervalo = Convert.ToInt32(txtIntervaloPrimeiro.Text);
            int finalIntervalo = Convert.ToInt32(txtIntervaloSegundo.Text);
            int i = comecoIntervalo;
            List<int> listaMultiplosNumero1 = new List<int>();
            List<int> listaMultiplosNumero2 = new List<int>();
            while (i >= comecoIntervalo && i <= finalIntervalo)
            {
                int testeModPrimeiro = i % primeiroNumero;
                int testeModSegundo = i % segundoNumero;
                if (testeModPrimeiro == 0)
                {
                    listaMultiplosNumero1.Add(i);
                }
                if (testeModSegundo == 0)
                {
                    listaMultiplosNumero2.Add(i);
                }
                i++;
            }
            //Devolução do Resultado
        }
    }
}
