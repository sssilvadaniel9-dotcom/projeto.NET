using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace att
{
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void Btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            Lbl_Titulo.Text = "Label Modificado!!!";
            Lbl_Titulo.Text = Txt_ConteudoLabel.Text;
        }

        private void Txt_ConteudoLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
