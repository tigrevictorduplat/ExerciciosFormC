using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            String modulosEscolhidos = "";

            foreach (CheckBox checkBox in this.panelModulos.Controls)
            {
                if (checkBox.Checked)
                {
                    modulosEscolhidos+= checkBox.Text+", ";
                }

            }
            dataGridView.Rows.Add(
                this.txtBoxLogin.Text,
                this.txtBoxSenha.Text,
                this.cBoxStatus.Text,
                this.panelTipo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text,
                this.dateTimePicker.Text,
                this.panelPerfil.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text,
                modulosEscolhidos,
                this.richTxtObs.Text,
                "Mostrar"
                
                ) ;
            limparInfos();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                senderGrid.Columns[colunaSenha.Index].Visible = (senderGrid.Columns[colunaSenha.Index].Visible) ? false : true;
                senderGrid.Columns[colunaOBS.Index].Visible = (senderGrid.Columns[colunaOBS.Index].Visible) ? false : true;
            }
        }
    }
}
