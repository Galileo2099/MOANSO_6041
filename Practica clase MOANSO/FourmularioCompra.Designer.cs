namespace CapaEntidad
{
    partial class FourmularioCompra
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
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.btnAgregar_Compra = new System.Windows.Forms.Button();
            this.btnEliminar_Compra = new System.Windows.Forms.Button();
            this.btnLimpiar_Compra = new System.Windows.Forms.Button();
            this.groupBoxdatoscliente_Compra = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnIngresarDatos_Compra = new System.Windows.Forms.Button();
            this.btnCancelar_Compra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.groupBoxdatoscliente_Compra.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(13, 15);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.RowTemplate.Height = 24;
            this.dgvCompras.Size = new System.Drawing.Size(586, 231);
            this.dgvCompras.TabIndex = 0;
            // 
            // btnAgregar_Compra
            // 
            this.btnAgregar_Compra.Location = new System.Drawing.Point(645, 15);
            this.btnAgregar_Compra.Name = "btnAgregar_Compra";
            this.btnAgregar_Compra.Size = new System.Drawing.Size(121, 53);
            this.btnAgregar_Compra.TabIndex = 1;
            this.btnAgregar_Compra.Text = "Agregar";
            this.btnAgregar_Compra.UseVisualStyleBackColor = true;
            // 
            // btnEliminar_Compra
            // 
            this.btnEliminar_Compra.Location = new System.Drawing.Point(645, 111);
            this.btnEliminar_Compra.Name = "btnEliminar_Compra";
            this.btnEliminar_Compra.Size = new System.Drawing.Size(121, 53);
            this.btnEliminar_Compra.TabIndex = 2;
            this.btnEliminar_Compra.Text = "Eliminar";
            this.btnEliminar_Compra.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar_Compra
            // 
            this.btnLimpiar_Compra.Location = new System.Drawing.Point(645, 193);
            this.btnLimpiar_Compra.Name = "btnLimpiar_Compra";
            this.btnLimpiar_Compra.Size = new System.Drawing.Size(121, 53);
            this.btnLimpiar_Compra.TabIndex = 3;
            this.btnLimpiar_Compra.Text = "Limpiar";
            this.btnLimpiar_Compra.UseVisualStyleBackColor = true;
            // 
            // groupBoxdatoscliente_Compra
            // 
            this.groupBoxdatoscliente_Compra.Controls.Add(this.btnCancelar_Compra);
            this.groupBoxdatoscliente_Compra.Controls.Add(this.btnIngresarDatos_Compra);
            this.groupBoxdatoscliente_Compra.Controls.Add(this.comboBox1);
            this.groupBoxdatoscliente_Compra.Controls.Add(this.textBox2);
            this.groupBoxdatoscliente_Compra.Controls.Add(this.textBox1);
            this.groupBoxdatoscliente_Compra.Controls.Add(this.label3);
            this.groupBoxdatoscliente_Compra.Controls.Add(this.label2);
            this.groupBoxdatoscliente_Compra.Controls.Add(this.label1);
            this.groupBoxdatoscliente_Compra.Location = new System.Drawing.Point(12, 268);
            this.groupBoxdatoscliente_Compra.Name = "groupBoxdatoscliente_Compra";
            this.groupBoxdatoscliente_Compra.Size = new System.Drawing.Size(776, 182);
            this.groupBoxdatoscliente_Compra.TabIndex = 4;
            this.groupBoxdatoscliente_Compra.TabStop = false;
            this.groupBoxdatoscliente_Compra.Text = "Datos del Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Modo de pago";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // btnIngresarDatos_Compra
            // 
            this.btnIngresarDatos_Compra.Location = new System.Drawing.Point(633, 29);
            this.btnIngresarDatos_Compra.Name = "btnIngresarDatos_Compra";
            this.btnIngresarDatos_Compra.Size = new System.Drawing.Size(121, 36);
            this.btnIngresarDatos_Compra.TabIndex = 11;
            this.btnIngresarDatos_Compra.Text = "Ingresar";
            this.btnIngresarDatos_Compra.UseVisualStyleBackColor = true;
            // 
            // btnCancelar_Compra
            // 
            this.btnCancelar_Compra.Location = new System.Drawing.Point(633, 90);
            this.btnCancelar_Compra.Name = "btnCancelar_Compra";
            this.btnCancelar_Compra.Size = new System.Drawing.Size(121, 36);
            this.btnCancelar_Compra.TabIndex = 12;
            this.btnCancelar_Compra.Text = "Cancelar";
            this.btnCancelar_Compra.UseVisualStyleBackColor = true;
            // 
            // FourmularioCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxdatoscliente_Compra);
            this.Controls.Add(this.btnLimpiar_Compra);
            this.Controls.Add(this.btnEliminar_Compra);
            this.Controls.Add(this.btnAgregar_Compra);
            this.Controls.Add(this.dgvCompras);
            this.Name = "FourmularioCompra";
            this.Text = "FourmularioCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.groupBoxdatoscliente_Compra.ResumeLayout(false);
            this.groupBoxdatoscliente_Compra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button btnAgregar_Compra;
        private System.Windows.Forms.Button btnEliminar_Compra;
        private System.Windows.Forms.Button btnLimpiar_Compra;
        private System.Windows.Forms.GroupBox groupBoxdatoscliente_Compra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCancelar_Compra;
        private System.Windows.Forms.Button btnIngresarDatos_Compra;
    }
}