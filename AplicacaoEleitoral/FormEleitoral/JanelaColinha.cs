using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormEleitoral.Properties;

namespace FormEleitoral
{
    public partial class JanelaColinha : Form
    {
        public JanelaColinha()
        {
            InitializeComponent();
        }

        private void comboBoxColinha_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxColinha.Text)
            {
                case "Jar Jar Binks" :
                    pictureBoxCandidatoColinha.Image = Properties.Resources.JarJar;
                    lbNumeroCandidato.Text = "10";
                    break;
                case "Darth Vader":
                    pictureBoxCandidatoColinha.Image = Properties.Resources.Vader;
                    lbNumeroCandidato.Text = "11";
                    break;
                case "Senadora Padmé":
                    pictureBoxCandidatoColinha.Image = Properties.Resources.Padme;
                    lbNumeroCandidato.Text = "12";
                    break;
                
                case "Mestre Yoda":
                    pictureBoxCandidatoColinha.Image = Properties.Resources.Yoda;
                    lbNumeroCandidato.Text = "13";
                    break;
                    default:
                    lbNumeroCandidato.Text = "--";
                    break;
            }
        }
    }
}
