namespace att
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_demonstracaoKey = new System.Windows.Forms.Button();
            this.Btn_HelloWorld = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_ValidaSenha = new System.Windows.Forms.Button();
            this.Btn_ValidaCPF2 = new System.Windows.Forms.Button();
            this.Btn_ValidadeCPF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_demonstracaoKey
            // 
            this.Btn_demonstracaoKey.Location = new System.Drawing.Point(12, 12);
            this.Btn_demonstracaoKey.Name = "Btn_demonstracaoKey";
            this.Btn_demonstracaoKey.Size = new System.Drawing.Size(114, 48);
            this.Btn_demonstracaoKey.TabIndex = 0;
            this.Btn_demonstracaoKey.Text = "Demontraçao Key";
            this.Btn_demonstracaoKey.UseVisualStyleBackColor = true;
            this.Btn_demonstracaoKey.Click += new System.EventHandler(this.Btn_demonstracaoKey_Click);
            // 
            // Btn_HelloWorld
            // 
            this.Btn_HelloWorld.Location = new System.Drawing.Point(132, 12);
            this.Btn_HelloWorld.Name = "Btn_HelloWorld";
            this.Btn_HelloWorld.Size = new System.Drawing.Size(114, 48);
            this.Btn_HelloWorld.TabIndex = 1;
            this.Btn_HelloWorld.Text = "Hello World";
            this.Btn_HelloWorld.UseVisualStyleBackColor = true;
            this.Btn_HelloWorld.Click += new System.EventHandler(this.Btn_HelloWorld_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Máscara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_ValidaSenha
            // 
            this.Btn_ValidaSenha.Location = new System.Drawing.Point(252, 66);
            this.Btn_ValidaSenha.Name = "Btn_ValidaSenha";
            this.Btn_ValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaSenha.TabIndex = 3;
            this.Btn_ValidaSenha.Text = "Valida Senha";
            this.Btn_ValidaSenha.UseVisualStyleBackColor = true;
            this.Btn_ValidaSenha.Click += new System.EventHandler(this.Btn_ValidaSenha_Click);
            // 
            // Btn_ValidaCPF2
            // 
            this.Btn_ValidaCPF2.Location = new System.Drawing.Point(132, 66);
            this.Btn_ValidaCPF2.Name = "Btn_ValidaCPF2";
            this.Btn_ValidaCPF2.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaCPF2.TabIndex = 4;
            this.Btn_ValidaCPF2.Text = "Valida CPF2";
            this.Btn_ValidaCPF2.UseVisualStyleBackColor = true;
            this.Btn_ValidaCPF2.Click += new System.EventHandler(this.Btn_ValidaCPF2_Click);
            // 
            // Btn_ValidadeCPF
            // 
            this.Btn_ValidadeCPF.Location = new System.Drawing.Point(12, 66);
            this.Btn_ValidadeCPF.Name = "Btn_ValidadeCPF";
            this.Btn_ValidadeCPF.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidadeCPF.TabIndex = 5;
            this.Btn_ValidadeCPF.Text = "Valida CPF";
            this.Btn_ValidadeCPF.UseVisualStyleBackColor = true;
            this.Btn_ValidadeCPF.Click += new System.EventHandler(this.button6_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 126);
            this.Controls.Add(this.Btn_ValidadeCPF);
            this.Controls.Add(this.Btn_ValidaCPF2);
            this.Controls.Add(this.Btn_ValidaSenha);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btn_HelloWorld);
            this.Controls.Add(this.Btn_demonstracaoKey);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_demonstracaoKey;
        private System.Windows.Forms.Button Btn_HelloWorld;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_ValidaSenha;
        private System.Windows.Forms.Button Btn_ValidaCPF2;
        private System.Windows.Forms.Button Btn_ValidadeCPF;
    }
}