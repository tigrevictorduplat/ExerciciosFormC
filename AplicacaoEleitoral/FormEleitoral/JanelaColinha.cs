using FormEleitoral.Properties;
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
                case "Jar Jar" :
                    pictureBoxCandidatoColinha.ImageLocation = @"c:\Resources\JarJar.jpg";
                    lbNumeroCandidato.Text = "10";
                    break;
                case "Darth Vader":
                    lbNumeroCandidato.Text = "11";
                    break;
                case "Senadora Padmé":
                    lbNumeroCandidato.Text = "12";
                    break;
                
                case "Mestre Yoda":
                    lbNumeroCandidato.Text = "13";
                    break;
                    default:
                    lbNumeroCandidato.Text = "--";
                    break;
            }
        }
    }
}
