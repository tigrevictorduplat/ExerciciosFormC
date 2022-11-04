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
    public partial class JanelaConversor : Form
    {
        public JanelaConversor()
        {
            InitializeComponent();
        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int intervaloComeco = Convert.ToInt32(txtIntervaloPrimeiro.Text);
            int intervaloFim = Convert.ToInt32(txtIntervaloSegundo.Text);
            int i = intervaloComeco;
            int contadorLinha = 0;
            dt.Columns.Add("F°", typeof(int));
            dt.Columns.Add("C°", typeof(double));
            while (i >= intervaloComeco && i <= intervaloFim)
            {
                double grausCelcius = (5 * (i - 32)) / 9;
                dt.Rows.Add();
                dt.Rows[contadorLinha]["F°"] = i;
                dt.Rows[contadorLinha]["C°"] = grausCelcius;
                i++;
                contadorLinha++;
            };
            JanelaResultadoTabela resultado = new JanelaResultadoTabela();
            resultado.setDadosTabela(dt);
            resultado.setTituloResultado("Temperaturas Convertidas");
            resultado.ShowDialog();
        }
    }
}
