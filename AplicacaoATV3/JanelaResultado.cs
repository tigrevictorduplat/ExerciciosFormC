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
    
    public partial class JanelaResultado : Form
    {
        public JanelaResultado()
        {
            InitializeComponent();
        }

        public void setStringResultado(String resultado)
        {
            this.lblResultado.Text = resultado; 
        }
    }
}
