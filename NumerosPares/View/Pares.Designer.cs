﻿namespace NumerosPares.View
{
    partial class Pares
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Artifakt Element Heavy", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular números pares";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_resultado.Location = new System.Drawing.Point(93, 221);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(334, 111);
            this.lbl_resultado.TabIndex = 1;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(224, 125);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(154, 23);
            this.txt_numero.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Artifakt Element Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(82, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite um número";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Artifakt Element Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calcular.Location = new System.Drawing.Point(93, 170);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(334, 23);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Pares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 462);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label1);
            this.Name = "Pares";
            this.Text = "Pares";
            this.Load += new System.EventHandler(this.Pares_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_resultado;
        private TextBox txt_numero;
        private Label label3;
        private Button btn_calcular;
    }
}