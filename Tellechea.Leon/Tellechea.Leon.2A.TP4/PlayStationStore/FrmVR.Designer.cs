﻿namespace PlayStationStore
{
    partial class FrmVR
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
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtLanzamiento = new System.Windows.Forms.TextBox();
            this.txtAlmacenamiento = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblLanzamiento = new System.Windows.Forms.Label();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(294, 297);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(216, 20);
            this.txtPeso.TabIndex = 43;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(291, 281);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 42;
            this.lblPeso.Text = "Peso";
            // 
            // txtLanzamiento
            // 
            this.txtLanzamiento.Location = new System.Drawing.Point(294, 250);
            this.txtLanzamiento.Name = "txtLanzamiento";
            this.txtLanzamiento.Size = new System.Drawing.Size(216, 20);
            this.txtLanzamiento.TabIndex = 41;
            // 
            // txtAlmacenamiento
            // 
            this.txtAlmacenamiento.Location = new System.Drawing.Point(294, 200);
            this.txtAlmacenamiento.Name = "txtAlmacenamiento";
            this.txtAlmacenamiento.Size = new System.Drawing.Size(216, 20);
            this.txtAlmacenamiento.TabIndex = 40;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(294, 153);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(216, 20);
            this.txtPrecio.TabIndex = 39;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(294, 108);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(216, 20);
            this.txtId.TabIndex = 38;
            // 
            // lblLanzamiento
            // 
            this.lblLanzamiento.AutoSize = true;
            this.lblLanzamiento.Location = new System.Drawing.Point(291, 234);
            this.lblLanzamiento.Name = "lblLanzamiento";
            this.lblLanzamiento.Size = new System.Drawing.Size(67, 13);
            this.lblLanzamiento.TabIndex = 37;
            this.lblLanzamiento.Text = "Lanzamiento";
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.Location = new System.Drawing.Point(291, 184);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(85, 13);
            this.lblAlmacenamiento.TabIndex = 36;
            this.lblAlmacenamiento.Text = "Almacenamiento";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(291, 137);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 35;
            this.lblPrecio.Text = "Precio";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(291, 92);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 34;
            this.lblId.Text = "Id";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(435, 336);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(294, 336);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 32;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmVR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtLanzamiento);
            this.Controls.Add(this.txtAlmacenamiento);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblLanzamiento);
            this.Controls.Add(this.lblAlmacenamiento);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmVR";
            this.Text = "FrmVR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtLanzamiento;
        private System.Windows.Forms.TextBox txtAlmacenamiento;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblLanzamiento;
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}