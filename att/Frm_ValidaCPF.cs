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
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public bool Valida(string cpf)
        {
            return cpf[cpf.Length - 1] != '0' ? true : false;
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            bool validaCpf = false;
            validaCpf = Valida(Msk_CPF.Text);
            if (validaCpf == true)
            {
                Lbl_Resultado.Text = "CPF Válido!";
                Lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Resultado.Text = "CPF Inválido!";
                Lbl_Resultado.ForeColor = Color.Red;
            }
        }

    }
}
