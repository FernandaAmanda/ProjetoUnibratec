namespace PocketQueue
{
    partial class TelaGerente
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
            this.gerentelabel = new System.Windows.Forms.Label();
            this.cadastrarusuariobutton = new System.Windows.Forms.Button();
            this.consultarusuariobutton = new System.Windows.Forms.Button();
            this.alterarusuariobutton = new System.Windows.Forms.Button();
            this.removerusuariobutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.relatoriolabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.chcmarsenhagerentebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.finalizaratendimentogerentebutton = new System.Windows.Forms.Button();
            this.ultimasenhageradalabel = new System.Windows.Forms.Label();
            this.ultimasenhachamadalabel = new System.Windows.Forms.Label();
            this.fechargerentebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gerentelabel
            // 
            this.gerentelabel.AutoSize = true;
            this.gerentelabel.ForeColor = System.Drawing.Color.Olive;
            this.gerentelabel.Location = new System.Drawing.Point(157, 9);
            this.gerentelabel.Name = "gerentelabel";
            this.gerentelabel.Size = new System.Drawing.Size(138, 13);
            this.gerentelabel.TabIndex = 27;
            this.gerentelabel.Text = "Bem Vindo PocketQueQue.";
            this.gerentelabel.Click += new System.EventHandler(this.gerentelabel_Click);
            // 
            // cadastrarusuariobutton
            // 
            this.cadastrarusuariobutton.Location = new System.Drawing.Point(40, 102);
            this.cadastrarusuariobutton.Name = "cadastrarusuariobutton";
            this.cadastrarusuariobutton.Size = new System.Drawing.Size(75, 23);
            this.cadastrarusuariobutton.TabIndex = 28;
            this.cadastrarusuariobutton.Text = "Cadastrar";
            this.cadastrarusuariobutton.UseVisualStyleBackColor = true;
            this.cadastrarusuariobutton.Click += new System.EventHandler(this.inserirusuariobutton_Click);
            // 
            // consultarusuariobutton
            // 
            this.consultarusuariobutton.Location = new System.Drawing.Point(132, 102);
            this.consultarusuariobutton.Name = "consultarusuariobutton";
            this.consultarusuariobutton.Size = new System.Drawing.Size(75, 23);
            this.consultarusuariobutton.TabIndex = 29;
            this.consultarusuariobutton.Text = "Consultar";
            this.consultarusuariobutton.UseVisualStyleBackColor = true;
            this.consultarusuariobutton.Click += new System.EventHandler(this.consultarusuariobutton_Click);
            // 
            // alterarusuariobutton
            // 
            this.alterarusuariobutton.Location = new System.Drawing.Point(40, 140);
            this.alterarusuariobutton.Name = "alterarusuariobutton";
            this.alterarusuariobutton.Size = new System.Drawing.Size(75, 23);
            this.alterarusuariobutton.TabIndex = 30;
            this.alterarusuariobutton.Text = "Alterar";
            this.alterarusuariobutton.UseVisualStyleBackColor = true;
            // 
            // removerusuariobutton
            // 
            this.removerusuariobutton.Location = new System.Drawing.Point(132, 140);
            this.removerusuariobutton.Name = "removerusuariobutton";
            this.removerusuariobutton.Size = new System.Drawing.Size(75, 23);
            this.removerusuariobutton.TabIndex = 31;
            this.removerusuariobutton.Text = "Remover";
            this.removerusuariobutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Usuários";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Gerar Relatório";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // relatoriolabel
            // 
            this.relatoriolabel.AutoSize = true;
            this.relatoriolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatoriolabel.Location = new System.Drawing.Point(39, 202);
            this.relatoriolabel.Name = "relatoriolabel";
            this.relatoriolabel.Size = new System.Drawing.Size(168, 17);
            this.relatoriolabel.TabIndex = 34;
            this.relatoriolabel.Text = "Relatorio de Atendimento";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(478, 342);
            this.shapeContainer1.TabIndex = 35;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(257, 61);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(197, 266);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(31, 61);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(186, 212);
            // 
            // chcmarsenhagerentebutton
            // 
            this.chcmarsenhagerentebutton.Location = new System.Drawing.Point(285, 102);
            this.chcmarsenhagerentebutton.Name = "chcmarsenhagerentebutton";
            this.chcmarsenhagerentebutton.Size = new System.Drawing.Size(141, 23);
            this.chcmarsenhagerentebutton.TabIndex = 36;
            this.chcmarsenhagerentebutton.Text = "Chamar Senha";
            this.chcmarsenhagerentebutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Atendimento";
            // 
            // finalizaratendimentogerentebutton
            // 
            this.finalizaratendimentogerentebutton.Location = new System.Drawing.Point(285, 140);
            this.finalizaratendimentogerentebutton.Name = "finalizaratendimentogerentebutton";
            this.finalizaratendimentogerentebutton.Size = new System.Drawing.Size(141, 23);
            this.finalizaratendimentogerentebutton.TabIndex = 38;
            this.finalizaratendimentogerentebutton.Text = "Finalizar Atendimento";
            this.finalizaratendimentogerentebutton.UseVisualStyleBackColor = true;
            // 
            // ultimasenhageradalabel
            // 
            this.ultimasenhageradalabel.AutoSize = true;
            this.ultimasenhageradalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimasenhageradalabel.Location = new System.Drawing.Point(282, 190);
            this.ultimasenhageradalabel.Name = "ultimasenhageradalabel";
            this.ultimasenhageradalabel.Size = new System.Drawing.Size(144, 17);
            this.ultimasenhageradalabel.TabIndex = 39;
            this.ultimasenhageradalabel.Text = "Última Senha Gerada";
            // 
            // ultimasenhachamadalabel
            // 
            this.ultimasenhachamadalabel.AutoSize = true;
            this.ultimasenhachamadalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimasenhachamadalabel.Location = new System.Drawing.Point(282, 257);
            this.ultimasenhachamadalabel.Name = "ultimasenhachamadalabel";
            this.ultimasenhachamadalabel.Size = new System.Drawing.Size(156, 17);
            this.ultimasenhachamadalabel.TabIndex = 40;
            this.ultimasenhachamadalabel.Text = "Última Senha Chamada";
            // 
            // fechargerentebutton
            // 
            this.fechargerentebutton.Location = new System.Drawing.Point(31, 307);
            this.fechargerentebutton.Name = "fechargerentebutton";
            this.fechargerentebutton.Size = new System.Drawing.Size(187, 23);
            this.fechargerentebutton.TabIndex = 41;
            this.fechargerentebutton.Text = "Fechar Usuário";
            this.fechargerentebutton.UseVisualStyleBackColor = true;
            this.fechargerentebutton.Click += new System.EventHandler(this.fechargerentebutton_Click);
            // 
            // TelaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 342);
            this.Controls.Add(this.fechargerentebutton);
            this.Controls.Add(this.ultimasenhachamadalabel);
            this.Controls.Add(this.ultimasenhageradalabel);
            this.Controls.Add(this.finalizaratendimentogerentebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chcmarsenhagerentebutton);
            this.Controls.Add(this.relatoriolabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removerusuariobutton);
            this.Controls.Add(this.alterarusuariobutton);
            this.Controls.Add(this.consultarusuariobutton);
            this.Controls.Add(this.cadastrarusuariobutton);
            this.Controls.Add(this.gerentelabel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "TelaGerente";
            this.Text = "Tela de Gerente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gerentelabel;
        private System.Windows.Forms.Button cadastrarusuariobutton;
        private System.Windows.Forms.Button consultarusuariobutton;
        private System.Windows.Forms.Button alterarusuariobutton;
        private System.Windows.Forms.Button removerusuariobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label relatoriolabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Button chcmarsenhagerentebutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button finalizaratendimentogerentebutton;
        private System.Windows.Forms.Label ultimasenhageradalabel;
        private System.Windows.Forms.Label ultimasenhachamadalabel;
        private System.Windows.Forms.Button fechargerentebutton;
    }
}