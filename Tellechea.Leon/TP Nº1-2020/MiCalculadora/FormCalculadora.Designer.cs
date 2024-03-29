﻿using System.Windows.Forms;

namespace MiCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConvertirADecimal = new System.Windows.Forms.Button();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(333, 178);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(137, 41);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConvertirADecimal
            // 
            this.btnConvertirADecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.btnConvertirADecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvertirADecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirADecimal.ForeColor = System.Drawing.Color.White;
            this.btnConvertirADecimal.Location = new System.Drawing.Point(409, 277);
            this.btnConvertirADecimal.Name = "btnConvertirADecimal";
            this.btnConvertirADecimal.Size = new System.Drawing.Size(220, 56);
            this.btnConvertirADecimal.TabIndex = 8;
            this.btnConvertirADecimal.Text = "Convertir a Decimal";
            this.btnConvertirADecimal.UseVisualStyleBackColor = false;
            this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.btnConvertirABinario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvertirABinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirABinario.ForeColor = System.Drawing.Color.White;
            this.btnConvertirABinario.Location = new System.Drawing.Point(172, 277);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(220, 56);
            this.btnConvertirABinario.TabIndex = 7;
            this.btnConvertirABinario.Text = "Convertir a Binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = false;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.btnOperar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperar.ForeColor = System.Drawing.Color.White;
            this.btnOperar.Location = new System.Drawing.Point(172, 178);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(137, 41);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(492, 178);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(137, 41);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNumero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.ForeColor = System.Drawing.Color.White;
            this.txtNumero1.Location = new System.Drawing.Point(172, 108);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 35);
            this.txtNumero1.TabIndex = 0;
            this.txtNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbOperador
            // 
            this.cmbOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbOperador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperador.ForeColor = System.Drawing.Color.White;
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            " ",
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperador.Location = new System.Drawing.Point(350, 108);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(100, 37);
            this.cmbOperador.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(344, 40);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(285, 32);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.ForeColor = System.Drawing.Color.White;
            this.txtNumero2.Location = new System.Drawing.Point(529, 108);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 35);
            this.txtNumero2.TabIndex = 3;
            this.txtNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.btnConvertirADecimal);
            this.Controls.Add(this.btnLimpiar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCalculadora";
            this.Text = "Calculadora de Leon Tellechea del curso 2°A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConvertirADecimal;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumero2;
    }
}

