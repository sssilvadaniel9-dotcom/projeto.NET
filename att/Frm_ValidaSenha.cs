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
    public partial class Frm_ValidaSenha : Form
    {
        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private bool VerSenhaTxt = false;
        private void Txt_Senha_KeyUp(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = verifica.GetForcaSenha();
            if (Lbl_Resultado.Text == "Inaceitável" || Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }
            else if (Lbl_Resultado.Text == "Aceitável")
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }
            else if (Lbl_Resultado.Text == "Forte" || Lbl_Resultado.Text == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void Frm_ValidaSenha_Load(object sender, EventArgs e)
        {

        }
        public class ChecaForcaSenha
        {
            private string forcaSenha;

            public ChecaForcaSenha(string forcaSenha)
            {
                this.forcaSenha = forcaSenha;
            }

            public string GetForcaSenha()
            {
                if (forcaSenha.Length == 0)
                {
                    return "";
                }
                else if (forcaSenha.Length >= 1 && forcaSenha.Length <= 2)
                {
                    return "Inaceitável";
                }
                else if (forcaSenha.Length >= 3 && forcaSenha.Length <= 4)
                {
                    return "Fraca";
                }
                else if (forcaSenha.Length >= 5 && forcaSenha.Length <= 6)
                {
                    return "Aceitável";
                }
                else if (forcaSenha.Length >= 7 && forcaSenha.Length <= 8)
                {
                    return "Forte";
                }
                else
                {
                    return "Segura";
                }
            }
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                Txt_Senha.PasswordChar = '\0';
                VerSenhaTxt = true;
                Btn_VerSenha.Text = "Esconder Senha";
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                VerSenhaTxt = false;
                Btn_VerSenha.Text = "Ver Senha";
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Senha.Clear();
           
        }
    }
}
