using System;

namespace tienda
{
    partial class Form1
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
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidadVendida = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.lstVentas = new System.Windows.Forms.ListView();
            this.lblProductoMasVendido = new System.Windows.Forms.Label();
            this.lblProductoMenosIngresos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(128, 80);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(121, 21);
            this.cmbProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(128, 28);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 3;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(128, 54);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtValorUnitario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Productos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cantidad vendida";
            // 
            // txtCantidadVendida
            // 
            this.txtCantidadVendida.Location = new System.Drawing.Point(128, 107);
            this.txtCantidadVendida.Name = "txtCantidadVendida";
            this.txtCantidadVendida.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadVendida.TabIndex = 12;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(318, 25);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 13;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Location = new System.Drawing.Point(318, 56);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarProducto.TabIndex = 14;
            this.btnQuitarProducto.Text = "Quitar";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(318, 104);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarVenta.TabIndex = 15;
            this.btnAgregarVenta.Text = "Ventas";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // lstVentas
            // 
            this.lstVentas.HideSelection = false;
            this.lstVentas.Location = new System.Drawing.Point(26, 133);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(367, 163);
            this.lstVentas.TabIndex = 16;
            this.lstVentas.UseCompatibleStateImageBehavior = false;
            // 
            // lblProductoMasVendido
            // 
            this.lblProductoMasVendido.AutoSize = true;
            this.lblProductoMasVendido.Location = new System.Drawing.Point(23, 310);
            this.lblProductoMasVendido.Name = "lblProductoMasVendido";
            this.lblProductoMasVendido.Size = new System.Drawing.Size(16, 13);
            this.lblProductoMasVendido.TabIndex = 17;
            this.lblProductoMasVendido.Text = "...";
            this.lblProductoMasVendido.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblProductoMenosIngresos
            // 
            this.lblProductoMenosIngresos.AutoSize = true;
            this.lblProductoMenosIngresos.Location = new System.Drawing.Point(23, 346);
            this.lblProductoMenosIngresos.Name = "lblProductoMenosIngresos";
            this.lblProductoMenosIngresos.Size = new System.Drawing.Size(16, 13);
            this.lblProductoMenosIngresos.TabIndex = 18;
            this.lblProductoMenosIngresos.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 368);
            this.Controls.Add(this.lblProductoMenosIngresos);
            this.Controls.Add(this.lblProductoMasVendido);
            this.Controls.Add(this.lstVentas);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtCantidadVendida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidadVendida;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.ListView lstVentas;
        private EventHandler label2_Click;
        private System.Windows.Forms.Label lblProductoMasVendido;
        private System.Windows.Forms.Label lblProductoMenosIngresos;
    }
}

