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
            List<string> modulo = new List<string>();

            foreach (CheckBox checkBox in this.panelModulos.Controls)
            {
                modulo.Add(checkBox.Text);
            }

            Usuario cadastroUsuario = new Usuario(
                this.txtBoxLogin.Text,
                this.txtBoxSenha.Text,
                this.cBoxStatus,
                this.panelTipo.Controls.OfType<RadioButton>().FirstOrDefault(r=>r.Checked),
                this.panelPerfil.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked),
                this.richTxtObs.Text,
                modulo

                );

            DataTable dt = new DataTable();
            dt.Rows.Add();
            dt.Rows[dataGridView.Rows.Count - 1][colunaLogin.Index] = cadastroUsuario.Login;
            dt.Rows[dataGridView.Rows.Count - 1 ][colunaSenha.Index] = cadastroUsuario.Senha;
            dt.Rows[dataGridView.Rows.Count - 1][colunaStatus.Index] = cadastroUsuario.Stauts;
            dt.Rows[dataGridView.Rows.Count - 1][colunaTipo.Index] = cadastroUsuario.Tipo;
            dt.Rows[dataGridView.Rows.Count - 1][colunaPerfil.Index] = cadastroUsuario.Perfil;
            ComboBox cbModulo = new ComboBox();
            cbModulo.Items.Add(cadastroUsuario.ModuloEstudo);
            dt.Rows[dataGridView.Rows.Count][colunaModulos.Index] =  cbModulo;

            dataGridView.DataSource = dt;
            limparInfos();
        }
    }
}
