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
    public partial class JanelaResultadoTabela : Form
    {
        public JanelaResultadoTabela()
        {
            InitializeComponent();
        }

        public void addColuna(String nomeVariavelColuna, String tituloColuna)
        {
            dataGridView.Columns.Add(nomeVariavelColuna,tituloColuna);

        }

        public void addLinhas (int indexColuna , List<String> listaLinhas)
        {
            for (int i = 0; i < listaLinhas.Count; i++)
            {
                dataGridView[0,i].Value = listaLinhas[i];
            }
        }
        public List<String> converterListaEmString(List<int> listaInt)
        {
            List<String> listaEmString = new List<String>();
            foreach (int i in listaInt)
            {
                listaEmString.Add(i.ToString());
            }
            return listaEmString;
        }
    }
}
