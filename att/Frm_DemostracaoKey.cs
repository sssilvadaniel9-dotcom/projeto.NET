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
    public partial class Frm_DemostracaoKey : Form
    {
        public Frm_DemostracaoKey()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_DemostracaoKey_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Input_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Lbl_Minus_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Input_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
           
            Txt_Msg.AppendText("\r\n" + "pressionei uma tecla" + e.KeyCode + "\r\n");
            Txt_Msg.AppendText("\t" + "codido da tecla" + ((int)e.KeyCode) + "\r\n");
            Txt_Msg.AppendText("\t" + "Nome da tecla" + (e.KeyData) + "\r\n");
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToLower();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Msg.Text = "";
            Txt_Input.Text = "";
            Lbl_Lower.Text = "";
            Lbl_Upper.Text = "";
        }
    }
}
