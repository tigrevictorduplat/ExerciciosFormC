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
    public partial class JanelaFatorial : Form
    {
        public JanelaFatorial()
        {
            InitializeComponent();
        }

        private void btnCalculaFatorial_Click(object sender, EventArgs e)
        {
          int valorInserido = Convert.ToInt32(txtBoxFatorial.Text);

            // Calculo
            int comparadorAntecessor = valorInserido - 1;
            while (comparadorAntecessor != 0)
            {
                valorInserido *= comparadorAntecessor;
                comparadorAntecessor--;

            };
            String resultadoString = valorInserido.ToString();
            //Resultado
            JanelaResultado janelaResultado = new JanelaResultado();
            janelaResultado.setStringResultado(resultadoString);
            janelaResultado.ShowDialog();
            
            
        }
    }
}
