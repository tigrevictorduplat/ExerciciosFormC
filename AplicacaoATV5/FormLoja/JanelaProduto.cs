using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoja
{
    public partial class JanelaProduto : Form
    {
        private string commonPath = "C:\\Users\\cinco\\OneDrive\\Documentos" +
            "\\GitHub\\ProjetosCSharp\\Exercicios4ano\\ExerciciosFormsC\\" +
            "ExerciciosFormC\\AplicacaoATV5\\";
        public JanelaProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(commonPath + "IFBAProdutos\\produto.txt"))
            {
                sw.WriteLine(lbDescricaoProduto.Text + ": " + txtDescricaoProduto.Text);
                sw.WriteLine(lbDataValidade.Text + ": " + dataTimePickerProduto.Text);
                sw.WriteLine(lbQuantidade.Text + ": " + txtQuantidade.Text);
                sw.WriteLine(lbPreco.Text + ": " + txtPreco.Text);
            }
            this.Close();
        }
    }
}
