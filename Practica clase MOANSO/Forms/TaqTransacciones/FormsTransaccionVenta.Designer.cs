namespace Practica_clase_MOANSO
{
    partial class FormsTransaccionVenta
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
            this.gbx_datoscliente_venta = new System.Windows.Forms.GroupBox();
            this.cmb_idcliente_venta = new System.Windows.Forms.ComboBox();
            this.btn_buscar_cliente = new System.Windows.Forms.Button();
            this.txt_nombrecliente_venta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbx_datosvendedor_venta = new System.Windows.Forms.GroupBox();
            this.cmb_idvendedor_venta = new System.Windows.Forms.ComboBox();
            this.btn_buscar_vendedor = new System.Windows.Forms.Button();
            this.txt_nombrevendedor_venta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbx_datosproducto_venta = new System.Windows.Forms.GroupBox();
            this.cmb_idproductos_venta = new System.Windows.Forms.ComboBox();
            this.txt_ptotalproductos_venta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_precioproductos_venta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cantidadproductos_venta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_stockproductos_venta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nombreproductos_venta = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_agregarproducto_venta = new System.Windows.Forms.Button();
            this.btn_quitarproducto_venta = new System.Windows.Forms.Button();
            this.dgv_venta = new System.Windows.Forms.DataGridView();
            this.btn_grabarproducto_venta = new System.Windows.Forms.Button();
            this.gbx_datoscliente_venta.SuspendLayout();
            this.gbx_datosvendedor_venta.SuspendLayout();
            this.gbx_datosproducto_venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_datoscliente_venta
            // 
            this.gbx_datoscliente_venta.Controls.Add(this.cmb_idcliente_venta);
            this.gbx_datoscliente_venta.Controls.Add(this.btn_buscar_cliente);
            this.gbx_datoscliente_venta.Controls.Add(this.txt_nombrecliente_venta);
            this.gbx_datoscliente_venta.Controls.Add(this.label2);
            this.gbx_datoscliente_venta.Controls.Add(this.label3);
            this.gbx_datoscliente_venta.Location = new System.Drawing.Point(11, 69);
            this.gbx_datoscliente_venta.Name = "gbx_datoscliente_venta";
            this.gbx_datoscliente_venta.Size = new System.Drawing.Size(419, 106);
            this.gbx_datoscliente_venta.TabIndex = 9;
            this.gbx_datoscliente_venta.TabStop = false;
            this.gbx_datoscliente_venta.Text = "Datos Cliente";
            // 
            // cmb_idcliente_venta
            // 
            this.cmb_idcliente_venta.FormattingEnabled = true;
            this.cmb_idcliente_venta.Location = new System.Drawing.Point(74, 32);
            this.cmb_idcliente_venta.Name = "cmb_idcliente_venta";
            this.cmb_idcliente_venta.Size = new System.Drawing.Size(112, 24);
            this.cmb_idcliente_venta.TabIndex = 8;
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.Location = new System.Drawing.Point(327, 32);
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Size = new System.Drawing.Size(82, 61);
            this.btn_buscar_cliente.TabIndex = 4;
            this.btn_buscar_cliente.Text = "Buscar";
            this.btn_buscar_cliente.UseVisualStyleBackColor = true;
            // 
            // txt_nombrecliente_venta
            // 
            this.txt_nombrecliente_venta.Location = new System.Drawing.Point(74, 71);
            this.txt_nombrecliente_venta.Name = "txt_nombrecliente_venta";
            this.txt_nombrecliente_venta.Size = new System.Drawing.Size(230, 22);
            this.txt_nombrecliente_venta.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // gbx_datosvendedor_venta
            // 
            this.gbx_datosvendedor_venta.Controls.Add(this.cmb_idvendedor_venta);
            this.gbx_datosvendedor_venta.Controls.Add(this.btn_buscar_vendedor);
            this.gbx_datosvendedor_venta.Controls.Add(this.txt_nombrevendedor_venta);
            this.gbx_datosvendedor_venta.Controls.Add(this.label5);
            this.gbx_datosvendedor_venta.Controls.Add(this.label4);
            this.gbx_datosvendedor_venta.Location = new System.Drawing.Point(437, 69);
            this.gbx_datosvendedor_venta.Name = "gbx_datosvendedor_venta";
            this.gbx_datosvendedor_venta.Size = new System.Drawing.Size(382, 106);
            this.gbx_datosvendedor_venta.TabIndex = 10;
            this.gbx_datosvendedor_venta.TabStop = false;
            this.gbx_datosvendedor_venta.Text = "Datos vendedor";
            // 
            // cmb_idvendedor_venta
            // 
            this.cmb_idvendedor_venta.FormattingEnabled = true;
            this.cmb_idvendedor_venta.Location = new System.Drawing.Point(83, 32);
            this.cmb_idvendedor_venta.Name = "cmb_idvendedor_venta";
            this.cmb_idvendedor_venta.Size = new System.Drawing.Size(98, 24);
            this.cmb_idvendedor_venta.TabIndex = 9;
            // 
            // btn_buscar_vendedor
            // 
            this.btn_buscar_vendedor.Location = new System.Drawing.Point(294, 32);
            this.btn_buscar_vendedor.Name = "btn_buscar_vendedor";
            this.btn_buscar_vendedor.Size = new System.Drawing.Size(82, 61);
            this.btn_buscar_vendedor.TabIndex = 8;
            this.btn_buscar_vendedor.Text = "Buscar";
            this.btn_buscar_vendedor.UseVisualStyleBackColor = true;
            // 
            // txt_nombrevendedor_venta
            // 
            this.txt_nombrevendedor_venta.Location = new System.Drawing.Point(74, 71);
            this.txt_nombrevendedor_venta.Name = "txt_nombrevendedor_venta";
            this.txt_nombrevendedor_venta.Size = new System.Drawing.Size(214, 22);
            this.txt_nombrevendedor_venta.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vendedor";
            // 
            // gbx_datosproducto_venta
            // 
            this.gbx_datosproducto_venta.Controls.Add(this.cmb_idproductos_venta);
            this.gbx_datosproducto_venta.Controls.Add(this.txt_ptotalproductos_venta);
            this.gbx_datosproducto_venta.Controls.Add(this.label11);
            this.gbx_datosproducto_venta.Controls.Add(this.txt_precioproductos_venta);
            this.gbx_datosproducto_venta.Controls.Add(this.label10);
            this.gbx_datosproducto_venta.Controls.Add(this.txt_cantidadproductos_venta);
            this.gbx_datosproducto_venta.Controls.Add(this.label9);
            this.gbx_datosproducto_venta.Controls.Add(this.txt_stockproductos_venta);
            this.gbx_datosproducto_venta.Controls.Add(this.label8);
            this.gbx_datosproducto_venta.Controls.Add(this.txt_nombreproductos_venta);
            this.gbx_datosproducto_venta.Controls.Add(this.button5);
            this.gbx_datosproducto_venta.Controls.Add(this.label6);
            this.gbx_datosproducto_venta.Controls.Add(this.label7);
            this.gbx_datosproducto_venta.Location = new System.Drawing.Point(14, 181);
            this.gbx_datosproducto_venta.Name = "gbx_datosproducto_venta";
            this.gbx_datosproducto_venta.Size = new System.Drawing.Size(663, 158);
            this.gbx_datosproducto_venta.TabIndex = 12;
            this.gbx_datosproducto_venta.TabStop = false;
            this.gbx_datosproducto_venta.Text = "Datos Productos";
            // 
            // cmb_idproductos_venta
            // 
            this.cmb_idproductos_venta.FormattingEnabled = true;
            this.cmb_idproductos_venta.Location = new System.Drawing.Point(88, 43);
            this.cmb_idproductos_venta.Name = "cmb_idproductos_venta";
            this.cmb_idproductos_venta.Size = new System.Drawing.Size(112, 24);
            this.cmb_idproductos_venta.TabIndex = 9;
            // 
            // txt_ptotalproductos_venta
            // 
            this.txt_ptotalproductos_venta.Location = new System.Drawing.Point(518, 127);
            this.txt_ptotalproductos_venta.Name = "txt_ptotalproductos_venta";
            this.txt_ptotalproductos_venta.Size = new System.Drawing.Size(128, 22);
            this.txt_ptotalproductos_venta.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(471, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Total";
            // 
            // txt_precioproductos_venta
            // 
            this.txt_precioproductos_venta.Location = new System.Drawing.Point(313, 124);
            this.txt_precioproductos_venta.Name = "txt_precioproductos_venta";
            this.txt_precioproductos_venta.Size = new System.Drawing.Size(128, 22);
            this.txt_precioproductos_venta.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(245, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Precio";
            // 
            // txt_cantidadproductos_venta
            // 
            this.txt_cantidadproductos_venta.Location = new System.Drawing.Point(81, 121);
            this.txt_cantidadproductos_venta.Name = "txt_cantidadproductos_venta";
            this.txt_cantidadproductos_venta.Size = new System.Drawing.Size(128, 22);
            this.txt_cantidadproductos_venta.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cantidad";
            // 
            // txt_stockproductos_venta
            // 
            this.txt_stockproductos_venta.Location = new System.Drawing.Point(374, 43);
            this.txt_stockproductos_venta.Name = "txt_stockproductos_venta";
            this.txt_stockproductos_venta.Size = new System.Drawing.Size(89, 22);
            this.txt_stockproductos_venta.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Stock";
            // 
            // txt_nombreproductos_venta
            // 
            this.txt_nombreproductos_venta.Location = new System.Drawing.Point(81, 83);
            this.txt_nombreproductos_venta.Name = "txt_nombreproductos_venta";
            this.txt_nombreproductos_venta.Size = new System.Drawing.Size(230, 22);
            this.txt_nombreproductos_venta.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(220, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 38);
            this.button5.TabIndex = 8;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Producto";
            // 
            // btn_agregarproducto_venta
            // 
            this.btn_agregarproducto_venta.Location = new System.Drawing.Point(720, 199);
            this.btn_agregarproducto_venta.Name = "btn_agregarproducto_venta";
            this.btn_agregarproducto_venta.Size = new System.Drawing.Size(82, 61);
            this.btn_agregarproducto_venta.TabIndex = 9;
            this.btn_agregarproducto_venta.Text = "Agregar";
            this.btn_agregarproducto_venta.UseVisualStyleBackColor = true;
            // 
            // btn_quitarproducto_venta
            // 
            this.btn_quitarproducto_venta.Location = new System.Drawing.Point(720, 266);
            this.btn_quitarproducto_venta.Name = "btn_quitarproducto_venta";
            this.btn_quitarproducto_venta.Size = new System.Drawing.Size(82, 61);
            this.btn_quitarproducto_venta.TabIndex = 10;
            this.btn_quitarproducto_venta.Text = "Quitar";
            this.btn_quitarproducto_venta.UseVisualStyleBackColor = true;
            // 
            // dgv_venta
            // 
            this.dgv_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_venta.Location = new System.Drawing.Point(11, 345);
            this.dgv_venta.Name = "dgv_venta";
            this.dgv_venta.RowHeadersWidth = 51;
            this.dgv_venta.RowTemplate.Height = 24;
            this.dgv_venta.Size = new System.Drawing.Size(666, 136);
            this.dgv_venta.TabIndex = 13;
            // 
            // btn_grabarproducto_venta
            // 
            this.btn_grabarproducto_venta.Location = new System.Drawing.Point(720, 386);
            this.btn_grabarproducto_venta.Name = "btn_grabarproducto_venta";
            this.btn_grabarproducto_venta.Size = new System.Drawing.Size(82, 61);
            this.btn_grabarproducto_venta.TabIndex = 14;
            this.btn_grabarproducto_venta.Text = "Grabar";
            this.btn_grabarproducto_venta.UseVisualStyleBackColor = true;
            // 
            // FormsTransaccionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 493);
            this.Controls.Add(this.btn_grabarproducto_venta);
            this.Controls.Add(this.dgv_venta);
            this.Controls.Add(this.btn_agregarproducto_venta);
            this.Controls.Add(this.btn_quitarproducto_venta);
            this.Controls.Add(this.gbx_datosproducto_venta);
            this.Controls.Add(this.gbx_datoscliente_venta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbx_datosvendedor_venta);
            this.Name = "FormsTransaccionVenta";
            this.Text = "VENTA";
            this.gbx_datoscliente_venta.ResumeLayout(false);
            this.gbx_datoscliente_venta.PerformLayout();
            this.gbx_datosvendedor_venta.ResumeLayout(false);
            this.gbx_datosvendedor_venta.PerformLayout();
            this.gbx_datosproducto_venta.ResumeLayout(false);
            this.gbx_datosproducto_venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_datoscliente_venta;
        private System.Windows.Forms.Button btn_buscar_cliente;
        private System.Windows.Forms.TextBox txt_nombrecliente_venta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbx_datosvendedor_venta;
        private System.Windows.Forms.Button btn_buscar_vendedor;
        private System.Windows.Forms.TextBox txt_nombrevendedor_venta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbx_datosproducto_venta;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ptotalproductos_venta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_precioproductos_venta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_cantidadproductos_venta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_stockproductos_venta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nombreproductos_venta;
        private System.Windows.Forms.Button btn_agregarproducto_venta;
        private System.Windows.Forms.Button btn_quitarproducto_venta;
        private System.Windows.Forms.DataGridView dgv_venta;
        private System.Windows.Forms.Button btn_grabarproducto_venta;
        private System.Windows.Forms.ComboBox cmb_idcliente_venta;
        private System.Windows.Forms.ComboBox cmb_idproductos_venta;
        private System.Windows.Forms.ComboBox cmb_idvendedor_venta;
    }
}