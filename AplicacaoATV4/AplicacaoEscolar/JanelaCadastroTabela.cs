using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoEscolar
{
    public partial class JanelaCadastroTabela : Form
    {
        public JanelaCadastroTabela()
        {
            InitializeComponent();
        }
        private void limparInfos()
        {
            this.txtBoxLogin.Text = "";
            this.txtBoxSenha.Text = "";
            this.cBoxStatus.Text = this.cBoxStatus.Items[0].ToString();
            this.dateTimePicker.Value = DateTime.Now;
            this.richTxtObs.Text = "";
            foreach (RadioButton radioButton in this.panelTipo.Controls)
            {
                radioButton.Checked = false;
            }
            foreach (RadioButton radioButton in this.panelPerfil.Controls)
            {
                radioButton.Checked = false;
            }
            foreach (CheckBox checkBox in this.panelModulos.Controls)
            {
                checkBox.Checked = false;
            }
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            limparInfos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparInfos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario cadastroUsuario = new Usuario(
                
                );

            DataTable dt = new DataTable();
            dt.Rows.Add(cadastroUsuario);
        }
    }
}
