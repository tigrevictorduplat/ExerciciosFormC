using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEleitoral
{
    public partial class JanelaUrnaVotacao : Form
    {
        public static JanelaUrnaVotacao instancia;
        private int contadorDigito;
        private List<int> votoCandidatos = new List<int>(6);

        public JanelaUrnaVotacao()
        {
            InitializeComponent();
            instancia = this;
            this.votoCandidatos.Add(0);
            this.votoCandidatos.Add(0);
            this.votoCandidatos.Add(0);
            this.votoCandidatos.Add(0);
            this.votoCandidatos.Add(0);
            this.votoCandidatos.Add(0);
        }

        private void lbNumeroDigitado_TextChanged(object sender, EventArgs e)
        {
            switch (this.lbNumeroDigitado.Text)
            {
                case "10":
                    this.pictureBoxCandidato.Image = Properties.Resources.JarJar;
                    this.lblNomeCandidato.Text = "Jar Jar Binks";
                    break;
                case "11":
                    this.pictureBoxCandidato.Image = Properties.Resources.Vader;
                    this.lblNomeCandidato.Text = "Darth Vader";
                    break;
                case "12":
                    this.pictureBoxCandidato.Image = Properties.Resources.Padme;
                    this.lblNomeCandidato.Text = "Senadora Padmé";
                    break;

                case "13":
                    this.pictureBoxCandidato.Image = Properties.Resources.Yoda;
                    this.lblNomeCandidato.Text = "Mestre Yoda";
                    break;
                case "--":
                    this.pictureBoxCandidato.Image = null;
                    this.lblNomeCandidato.Text = "--";
                    break;
                default:
                    if (!lbNumeroDigitado.Text.Contains("-"))
                    {
                        this.pictureBoxCandidato.Image = Properties.Resources.Nulo;
                        this.lblNomeCandidato.Text = "NULO";
                    }
                   break;
            }
        }
        public List<int> getVotosCandidatos()
        {
            return this.votoCandidatos;
        }

        private void inserirNovoDigito(char novoDigito) {
            //Transformando em Char Array
            char[] texto = this.lbNumeroDigitado.Text.ToCharArray();
            //Mudando primeiro dígito
            texto[0] = (texto[0] == '-') ? novoDigito: texto[0];
            //Mudando o segundo dígito se o primeiro já ouver sido mudado
            if (this.contadorDigito == 1)
            {
                texto[1] = (texto[0] != '-' && texto[1] == '-') ? novoDigito : texto[1];
                this.contadorDigito = 0;
            }
            //Convertendo novamente em String 
            string novoTexto = new string(texto);
            this.lbNumeroDigitado.Text = novoTexto;

            this.contadorDigito++;
        }
        private void btnDigito1_Click(object sender, EventArgs e)

        {
            inserirNovoDigito('1'); 
        }

        private void btnDigito2_Click(object sender, EventArgs e)
        {
            inserirNovoDigito('2');

        }

        private void btnDigito3_Click(object sender, EventArgs e)
        {
            inserirNovoDigito('3');

        }

        private void btnDigito4_Click(object sender, EventArgs e)
        {
            inserirNovoDigito('4');

        }

        private void btnDigito5_Click(object sender, EventArgs e)
        {
            inserirNovoDigito('5');
        }

        private void btnDigito6_Click(object sender, EventArgs e)
        {
            inserirNovoDigito('6');
        }

        private void btnDigito7_Click(object sender, EventArgs e)
        {
            inserirNovoDigito('7');
        }

        private void btnDigito8_Click(object sender, EventArgs e)
        {
            inserirNovoDigito('8');
        }

        private void btnDigito9_Click(object sender, EventArgs e)
        {
            inserirNovoDigito('9');
        }

        private void btnDigito0_Click(object sender, EventArgs e)
        {
            inserirNovoDigito('0');

        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            String texto = this.lbNumeroDigitado.Text;
            texto = (texto != "--") ? "--" : texto;
            this.lbNumeroDigitado.Text = texto;
            this.contadorDigito = 0;
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            this.lbNumeroDigitado.Text = "  ";
            this.pictureBoxCandidato.Image = Properties.Resources.Branco;
            this.lblNomeCandidato.Text = "BRANCO";
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            switch (this.lblNomeCandidato.Text)
            {
                case "Jar Jar Binks":
                    this.votoCandidatos[0]++;
                    break;
                case "Darth Vader":
                    this.votoCandidatos[1]++;
                    break;
                case "Senadora Padmé":
                    this.votoCandidatos[2]++;
                    break;
                case "Mestre Yoda":
                    this.votoCandidatos[3]++;
                    break;
                case "NULO":
                    this.votoCandidatos[4]++;
                    break;
                case "BRANCO":
                    this.votoCandidatos[5]++;
                    break;
            }
        
            this.lbNumeroDigitado.Text = "--";
            this.contadorDigito = 0;
            ConfirmacaoVoto voto = new ConfirmacaoVoto();
            voto.ShowDialog();
        }
    }
}
