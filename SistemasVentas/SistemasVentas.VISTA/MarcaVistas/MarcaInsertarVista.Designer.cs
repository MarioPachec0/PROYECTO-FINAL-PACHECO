﻿namespace SistemasVentas.VISTA.MarcaVistas
{
    partial class MarcaInsertarVista
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 27);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(14, 148);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 8;
            label2.Text = "ESTADO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 87);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 7;
            label1.Text = "NOMBRE";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(263, 185);
            button2.Name = "button2";
            button2.Size = new Size(130, 45);
            button2.TabIndex = 43;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(90, 185);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 42;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MarcaInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2024_03_26_0951043;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(433, 373);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "MarcaInsertarVista";
            Text = "MarcaInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}