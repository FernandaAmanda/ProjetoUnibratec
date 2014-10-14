namespace PocketQueue
{
    partial class TelaRecepcionista
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
            this.UltimaSenhaChamada_textBox = new System.Windows.Forms.TextBox();
            this.UltimaSenhaGerada_textBox = new System.Windows.Forms.TextBox();
            this.ultimasenhachamadalabel = new System.Windows.Forms.Label();
            this.ultimasenhageradalabel = new System.Windows.Forms.Label();
            this.GerarSenha_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UltimaSenhaChamada_textBox
            // 
            this.UltimaSenhaChamada_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.UltimaSenhaChamada_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UltimaSenhaChamada_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltimaSenhaChamada_textBox.Location = new System.Drawing.Point(129, 218);
            this.UltimaSenhaChamada_textBox.Name = "UltimaSenhaChamada_textBox";
            this.UltimaSenhaChamada_textBox.ReadOnly = true;
            this.UltimaSenhaChamada_textBox.Size = new System.Drawing.Size(178, 80);
            this.UltimaSenhaChamada_textBox.TabIndex = 47;
            this.UltimaSenhaChamada_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UltimaSenhaGerada_textBox
            // 
            this.UltimaSenhaGerada_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.UltimaSenhaGerada_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UltimaSenhaGerada_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltimaSenhaGerada_textBox.Location = new System.Drawing.Point(47, 61);
            this.UltimaSenhaGerada_textBox.Name = "UltimaSenhaGerada_textBox";
            this.UltimaSenhaGerada_textBox.ReadOnly = true;
            this.UltimaSenhaGerada_textBox.Size = new System.Drawing.Size(346, 116);
            this.UltimaSenhaGerada_textBox.TabIndex = 46;
            this.UltimaSenhaGerada_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ultimasenhachamadalabel
            // 
            this.ultimasenhachamadalabel.AutoSize = true;
            this.ultimasenhachamadalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimasenhachamadalabel.Location = new System.Drawing.Point(129, 195);
            this.ultimasenhachamadalabel.Name = "ultimasenhachamadalabel";
            this.ultimasenhachamadalabel.Size = new System.Drawing.Size(178, 20);
            this.ultimasenhachamadalabel.TabIndex = 45;
            this.ultimasenhachamadalabel.Text = "Última Senha Chamada";
            // 
            // ultimasenhageradalabel
            // 
            this.ultimasenhageradalabel.AutoSize = true;
            this.ultimasenhageradalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimasenhageradalabel.Location = new System.Drawing.Point(126, 24);
            this.ultimasenhageradalabel.Name = "ultimasenhageradalabel";
            this.ultimasenhageradalabel.Size = new System.Drawing.Size(188, 24);
            this.ultimasenhageradalabel.TabIndex = 44;
            this.ultimasenhageradalabel.Text = "Última Senha Gerada";
            // 
            // GerarSenha_button
            // 
            this.GerarSenha_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GerarSenha_button.Location = new System.Drawing.Point(129, 327);
            this.GerarSenha_button.Name = "GerarSenha_button";
            this.GerarSenha_button.Size = new System.Drawing.Size(177, 45);
            this.GerarSenha_button.TabIndex = 48;
            this.GerarSenha_button.Text = "Gerar Senha";
            this.GerarSenha_button.UseVisualStyleBackColor = true;
            // 
            // TelaRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.GerarSenha_button);
            this.Controls.Add(this.UltimaSenhaChamada_textBox);
            this.Controls.Add(this.UltimaSenhaGerada_textBox);
            this.Controls.Add(this.ultimasenhachamadalabel);
            this.Controls.Add(this.ultimasenhageradalabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaRecepcionista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepcão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UltimaSenhaChamada_textBox;
        private System.Windows.Forms.TextBox UltimaSenhaGerada_textBox;
        private System.Windows.Forms.Label ultimasenhachamadalabel;
        private System.Windows.Forms.Label ultimasenhageradalabel;
        private System.Windows.Forms.Button GerarSenha_button;




    }
}