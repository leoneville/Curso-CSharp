using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public int count = 0;
        public Form1()
        {
            
            InitializeComponent();
            //this.Text = "Neville Barbosa";
            //this.Size = new Size(400, 200);
            //this.ControlBox = true;
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
                lblTitulo.Text = $"Clicou no botão {count} vez";
            else
                lblTitulo.Text = $"Clicou no botão {count} vezes";
        }

        private void bnt1_MouseEnter(object sender, EventArgs e)
        {
            lblTitulo.Text = "Evento mouse enter acionado";
        }

        private void bnt1_MouseLeave(object sender, EventArgs e)
        {
            lblTitulo.Text = "Evento mouse leave acionado";
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            bnt1.Size = new Size(300, 150);
        }
    }
}
