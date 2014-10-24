namespace PocketQueue
{
    partial class TelaConsulta
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
            this.consultalistBox = new System.Windows.Forms.ListBox();
            this.voltartelagerentebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consultalistBox
            // 
<<<<<<< HEAD
            this.consultalistBox.FormattingEnabled = true;
            this.consultalistBox.Location = new System.Drawing.Point(12, 12);
            this.consultalistBox.Name = "consultalistBox";
            this.consultalistBox.Size = new System.Drawing.Size(690, 433);
=======
            this.consultalistBox.BackColor = System.Drawing.SystemColors.Control;
            this.consultalistBox.FormattingEnabled = true;
            this.consultalistBox.Location = new System.Drawing.Point(12, 12);
            this.consultalistBox.Name = "consultalistBox";
            this.consultalistBox.Size = new System.Drawing.Size(410, 355);
>>>>>>> 5f0932a4f32660179c6da99316c64471225192d7
            this.consultalistBox.TabIndex = 0;
            // 
            // voltartelagerentebutton
            // 
<<<<<<< HEAD
            this.voltartelagerentebutton.Location = new System.Drawing.Point(627, 451);
=======
            this.voltartelagerentebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.voltartelagerentebutton.Location = new System.Drawing.Point(347, 376);
>>>>>>> 5f0932a4f32660179c6da99316c64471225192d7
            this.voltartelagerentebutton.Name = "voltartelagerentebutton";
            this.voltartelagerentebutton.Size = new System.Drawing.Size(75, 23);
            this.voltartelagerentebutton.TabIndex = 1;
            this.voltartelagerentebutton.Text = "Voltar";
            this.voltartelagerentebutton.UseVisualStyleBackColor = true;
            this.voltartelagerentebutton.Click += new System.EventHandler(this.voltartelagerentebutton_Click);
            // 
            // TelaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(714, 483);
            this.Controls.Add(this.voltartelagerentebutton);
            this.Controls.Add(this.consultalistBox);
            this.Name = "TelaConsulta";
            this.Text = "Tela de Consulta";
=======
            this.CancelButton = this.voltartelagerentebutton;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.voltartelagerentebutton);
            this.Controls.Add(this.consultalistBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios Cadastrados";
>>>>>>> 5f0932a4f32660179c6da99316c64471225192d7
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox consultalistBox;
        private System.Windows.Forms.Button voltartelagerentebutton;
    }
}