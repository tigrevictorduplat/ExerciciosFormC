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

namespace AplicacaoEscolar
{
    public partial class JanelaInicial : Form
    {
        Thread th;
        public JanelaInicial()
        {
            InitializeComponent();
        }
        private void abrirCadastroTabela()
        {
            Application.Run(new JanelaCadastroTabela());
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(abrirCadastroTabela);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
    }
}
