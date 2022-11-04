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
            JanelaResultadoTabela janelaResultadoTabela = new JanelaResultadoTabela();
            //Calculo
            int primeiroNumero = Convert.ToInt32(txtBoxPrimeiroNumero.Text);
            int segundoNumero = Convert.ToInt32(txtBoxSegundoNumero.Text);
            int comecoIntervalo = Convert.ToInt32(txtIntervaloPrimeiro.Text);
            int finalIntervalo = Convert.ToInt32(txtIntervaloSegundo.Text);
            int i = comecoIntervalo;
            int contadorLinha = 0;
            //Data Table
            DataTable dt = new DataTable();
            dt.Columns.Add($"{primeiroNumero}");
            dt.Columns.Add($"{segundoNumero}");

            while (i >= comecoIntervalo && i <= finalIntervalo)
            {
                dt.Rows.Add();
                if (i % primeiroNumero == 0)
                {
                    dt.Rows[contadorLinha][$"{primeiroNumero}"] = i;
                }
                if (i % segundoNumero == 0)
                {
                    dt.Rows[contadorLinha][$"{segundoNumero}"] = i;
                }
                i++;
                // Check null
                if (dt.Rows[contadorLinha].IsNull(0) && dt.Rows[contadorLinha].IsNull(1))
                {
                    dt.Rows.Remove(dt.Rows[contadorLinha]);
                } else { 
                    contadorLinha++; 
                }
            }
            //Devolução do Resultado
            janelaResultadoTabela.setDadosTabela(dt);
            janelaResultadoTabela.ShowDialog();

        }
    }
}
