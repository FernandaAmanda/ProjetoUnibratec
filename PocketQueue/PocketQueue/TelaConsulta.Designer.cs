﻿namespace PocketQueue
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
            this.consultalistBox.BackColor = System.Drawing.SystemColors.Control;
            this.consultalistBox.FormattingEnabled = true;
            this.consultalistBox.Location = new System.Drawing.Point(12, 12);
            this.consultalistBox.Name = "consultalistBox";
            this.consultalistBox.Size = new System.Drawing.Size(410, 355);
            this.consultalistBox.TabIndex = 0;
            // 
            // voltartelagerentebutton
            // 
            this.voltartelagerentebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.voltartelagerentebutton.Location = new System.Drawing.Point(347, 376);
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
            this.CancelButton = this.voltartelagerentebutton;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.voltartelagerentebutton);
            this.Controls.Add(this.consultalistBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios Cadastrados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox consultalistBox;
        private System.Windows.Forms.Button voltartelagerentebutton;
    }
}