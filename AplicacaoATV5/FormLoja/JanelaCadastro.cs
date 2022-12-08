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
    public partial class JanelaCadastro : Form
    {
        private string commonPath = "C:\\Users\\cinco\\OneDrive\\Documentos" +
            "\\GitHub\\ProjetosCSharp\\Exercicios4ano\\ExerciciosFormsC\\" +
            "ExerciciosFormC\\AplicacaoATV5\\";
        public JanelaCadastro()
        {
            InitializeComponent();
        }

        private void limparCampos(TextBox campo1, TextBox campo2, TextBox campo3)
        {
            campo1.Text = "";
            campo2.Text = "";
            campo3.Text = "";
        }
        private void limparCampos(TextBox campo1, TextBox campo2)
        {
            campo1.Text = "";
            campo2.Text = "";
        }
        private void toolStripLabelCliente_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(commonPath + "IFBACliente\\cliente.txt"))
            {
                sw.WriteLine("Nome: Víctor Tigre");
                sw.WriteLine("Idade: 19 anos");
                sw.WriteLine("Telefone: (71)99318-6783");
            }
        }
        private void btnCadastrarVendedor_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(commonPath+"IFBAVendedor\\cadastro.txt"))
            {
                sw.WriteLine(lbNomeVendedor.Text+": "+txtNomeVendedor.Text);
                sw.WriteLine(lbComissaoVendedor.Text+": "+txtComissaoVendedor.Text);
                sw.WriteLine(lbAreaVendedor.Text+": " + txtAreaVendedor.Text);
            }
            limparCampos(txtNomeVendedor,txtComissaoVendedor, txtAreaVendedor);
        }

        private void btnCadastrarSocio_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(commonPath + "IFBASocio\\cadastro.txt"))
            {
                sw.WriteLine(lbNomeSocio.Text + ": " + txtNomeSocio.Text);
                sw.WriteLine(lbDataNascimentoSocio.Text + ": " + dataTimePicker.Text);
                sw.WriteLine(lbAreaSocio.Text + ": " + txtAreaSocio.Text);
            }
            limparCampos(txtNomeSocio, txtAreaSocio);
            dataTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaProduto janelaProduto = new JanelaProduto();
            janelaProduto.ShowDialog();
        }

    }
}
