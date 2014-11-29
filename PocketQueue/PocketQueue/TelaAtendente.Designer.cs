namespace PocketQueue
{
    partial class TelaAtendente
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Guichelabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UltimaSenhaChamada_textBox = new System.Windows.Forms.TextBox();
            this.UltimaSenhaGerada_textBox = new System.Windows.Forms.TextBox();
            this.ultimasenhachamadalabel = new System.Windows.Forms.Label();
            this.ultimasenhageradalabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TempoFinal_Label = new System.Windows.Forms.Label();
            this.Cronometro_Label = new System.Windows.Forms.Label();
            this.ChamarSenha_Button = new System.Windows.Forms.Button();
            this.FinalizarAtendimento_Button = new System.Windows.Forms.Button();
            this.Cronometro_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Guichê Nº";
            // 
            // Guichelabel
            // 
            this.Guichelabel.AutoSize = true;
            this.Guichelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guichelabel.Location = new System.Drawing.Point(646, 9);
            this.Guichelabel.Name = "Guichelabel";
            this.Guichelabel.Size = new System.Drawing.Size(26, 17);
            this.Guichelabel.TabIndex = 55;
            this.Guichelabel.Text = "??";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.UltimaSenhaChamada_textBox);
            this.groupBox4.Controls.Add(this.UltimaSenhaGerada_textBox);
            this.groupBox4.Controls.Add(this.ultimasenhachamadalabel);
            this.groupBox4.Controls.Add(this.ultimasenhageradalabel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.Location = new System.Drawing.Point(138, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 159);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Senha";
            // 
            // UltimaSenhaChamada_textBox
            // 
            this.UltimaSenhaChamada_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.UltimaSenhaChamada_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UltimaSenhaChamada_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UltimaSenhaChamada_textBox.Enabled = false;
            this.UltimaSenhaChamada_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltimaSenhaChamada_textBox.Location = new System.Drawing.Point(52, 102);
            this.UltimaSenhaChamada_textBox.Name = "UltimaSenhaChamada_textBox";
            this.UltimaSenhaChamada_textBox.ReadOnly = true;
            this.UltimaSenhaChamada_textBox.Size = new System.Drawing.Size(285, 38);
            this.UltimaSenhaChamada_textBox.TabIndex = 47;
            this.UltimaSenhaChamada_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UltimaSenhaGerada_textBox
            // 
            this.UltimaSenhaGerada_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.UltimaSenhaGerada_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UltimaSenhaGerada_textBox.CausesValidation = false;
            this.UltimaSenhaGerada_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UltimaSenhaGerada_textBox.Enabled = false;
            this.UltimaSenhaGerada_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltimaSenhaGerada_textBox.Location = new System.Drawing.Point(52, 37);
            this.UltimaSenhaGerada_textBox.Name = "UltimaSenhaGerada_textBox";
            this.UltimaSenhaGerada_textBox.ReadOnly = true;
            this.UltimaSenhaGerada_textBox.Size = new System.Drawing.Size(285, 38);
            this.UltimaSenhaGerada_textBox.TabIndex = 46;
            this.UltimaSenhaGerada_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ultimasenhachamadalabel
            // 
            this.ultimasenhachamadalabel.AutoSize = true;
            this.ultimasenhachamadalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimasenhachamadalabel.Location = new System.Drawing.Point(124, 82);
            this.ultimasenhachamadalabel.Name = "ultimasenhachamadalabel";
            this.ultimasenhachamadalabel.Size = new System.Drawing.Size(156, 17);
            this.ultimasenhachamadalabel.TabIndex = 45;
            this.ultimasenhachamadalabel.Text = "Última Senha Chamada";
            // 
            // ultimasenhageradalabel
            // 
            this.ultimasenhageradalabel.AutoSize = true;
            this.ultimasenhageradalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimasenhageradalabel.Location = new System.Drawing.Point(124, 17);
            this.ultimasenhageradalabel.Name = "ultimasenhageradalabel";
            this.ultimasenhageradalabel.Size = new System.Drawing.Size(144, 17);
            this.ultimasenhageradalabel.TabIndex = 44;
            this.ultimasenhageradalabel.Text = "Última Senha Gerada";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.ChamarSenha_Button);
            this.groupBox3.Controls.Add(this.FinalizarAtendimento_Button);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(34, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 159);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Atendimento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TempoFinal_Label);
            this.groupBox1.Controls.Add(this.Cronometro_Label);
            this.groupBox1.Location = new System.Drawing.Point(6, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 131);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Tempo do Ultimo Atendimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Tempo de Atendimento Atual";
            // 
            // TempoFinal_Label
            // 
            this.TempoFinal_Label.AutoSize = true;
            this.TempoFinal_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempoFinal_Label.Location = new System.Drawing.Point(46, 97);
            this.TempoFinal_Label.Name = "TempoFinal_Label";
            this.TempoFinal_Label.Size = new System.Drawing.Size(104, 20);
            this.TempoFinal_Label.TabIndex = 58;
            this.TempoFinal_Label.Text = "00:00:00:00";
            // 
            // Cronometro_Label
            // 
            this.Cronometro_Label.AutoSize = true;
            this.Cronometro_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cronometro_Label.Location = new System.Drawing.Point(46, 32);
            this.Cronometro_Label.Name = "Cronometro_Label";
            this.Cronometro_Label.Size = new System.Drawing.Size(104, 20);
            this.Cronometro_Label.TabIndex = 58;
            this.Cronometro_Label.Text = "00:00:00:00";
            // 
            // ChamarSenha_Button
            // 
            this.ChamarSenha_Button.Location = new System.Drawing.Point(300, 37);
            this.ChamarSenha_Button.Name = "ChamarSenha_Button";
            this.ChamarSenha_Button.Size = new System.Drawing.Size(285, 45);
            this.ChamarSenha_Button.TabIndex = 5;
            this.ChamarSenha_Button.Text = "Chamar Senha";
            this.ChamarSenha_Button.UseVisualStyleBackColor = true;
            this.ChamarSenha_Button.Click += new System.EventHandler(this.ChamarSenha_Button_Click);
            // 
            // FinalizarAtendimento_Button
            // 
            this.FinalizarAtendimento_Button.Location = new System.Drawing.Point(300, 102);
            this.FinalizarAtendimento_Button.Name = "FinalizarAtendimento_Button";
            this.FinalizarAtendimento_Button.Size = new System.Drawing.Size(285, 45);
            this.FinalizarAtendimento_Button.TabIndex = 6;
            this.FinalizarAtendimento_Button.Text = "Finalizar Atendimento";
            this.FinalizarAtendimento_Button.UseVisualStyleBackColor = true;
            this.FinalizarAtendimento_Button.Click += new System.EventHandler(this.FinalizarAtendimento_Button_Click);
            // 
            // Cronometro_timer
            // 
            this.Cronometro_timer.Enabled = true;
            this.Cronometro_timer.Interval = 1;
            this.Cronometro_timer.Tick += new System.EventHandler(this.Cronometro_Timer_Tick);
            // 
            // TelaAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guichelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento";
            this.Load += new System.EventHandler(this.TelaAtendente_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Guichelabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox UltimaSenhaChamada_textBox;
        private System.Windows.Forms.TextBox UltimaSenhaGerada_textBox;
        private System.Windows.Forms.Label ultimasenhachamadalabel;
        private System.Windows.Forms.Label ultimasenhageradalabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ChamarSenha_Button;
        private System.Windows.Forms.Button FinalizarAtendimento_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Cronometro_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TempoFinal_Label;
        private System.Windows.Forms.Timer Cronometro_timer;

    }
}