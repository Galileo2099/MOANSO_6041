namespace Practica_clase_MOANSO
{
    partial class FormsMenuReportes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_eliminar_reporterpedidoproducto = new System.Windows.Forms.Button();
            this.btn_nuevo_reporterpedidoproducto = new System.Windows.Forms.Button();
            this.dgv_pedidoproducto = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eliminar_reportesalida = new System.Windows.Forms.Button();
            this.btn_nuevo_reportesalida = new System.Windows.Forms.Button();
            this.dgv_reportersalida = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidoproducto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportersalida)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.panel7);
            this.tabPage7.Controls.Add(this.dgv_pedidoproducto);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(818, 460);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Pedido Producto";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_eliminar_reporterpedidoproducto);
            this.panel7.Controls.Add(this.btn_nuevo_reporterpedidoproducto);
            this.panel7.Location = new System.Drawing.Point(574, 113);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 233);
            this.panel7.TabIndex = 1;
            // 
            // btn_eliminar_reporterpedidoproducto
            // 
            this.btn_eliminar_reporterpedidoproducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_eliminar_reporterpedidoproducto.Location = new System.Drawing.Point(0, 111);
            this.btn_eliminar_reporterpedidoproducto.Name = "btn_eliminar_reporterpedidoproducto";
            this.btn_eliminar_reporterpedidoproducto.Size = new System.Drawing.Size(200, 111);
            this.btn_eliminar_reporterpedidoproducto.TabIndex = 1;
            this.btn_eliminar_reporterpedidoproducto.Text = "Eliminar";
            this.btn_eliminar_reporterpedidoproducto.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo_reporterpedidoproducto
            // 
            this.btn_nuevo_reporterpedidoproducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nuevo_reporterpedidoproducto.Location = new System.Drawing.Point(0, 0);
            this.btn_nuevo_reporterpedidoproducto.Name = "btn_nuevo_reporterpedidoproducto";
            this.btn_nuevo_reporterpedidoproducto.Size = new System.Drawing.Size(200, 111);
            this.btn_nuevo_reporterpedidoproducto.TabIndex = 0;
            this.btn_nuevo_reporterpedidoproducto.Text = "Nuevo";
            this.btn_nuevo_reporterpedidoproducto.UseVisualStyleBackColor = true;
            this.btn_nuevo_reporterpedidoproducto.Click += new System.EventHandler(this.btn_nuevo_reporterpedidoproducto_Click);
            // 
            // dgv_pedidoproducto
            // 
            this.dgv_pedidoproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidoproducto.Location = new System.Drawing.Point(6, 6);
            this.dgv_pedidoproducto.Name = "dgv_pedidoproducto";
            this.dgv_pedidoproducto.RowHeadersWidth = 51;
            this.dgv_pedidoproducto.RowTemplate.Height = 24;
            this.dgv_pedidoproducto.Size = new System.Drawing.Size(490, 448);
            this.dgv_pedidoproducto.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dgv_reportersalida);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Salida";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_eliminar_reportesalida);
            this.panel1.Controls.Add(this.btn_nuevo_reportesalida);
            this.panel1.Location = new System.Drawing.Point(574, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 233);
            this.panel1.TabIndex = 4;
            // 
            // btn_eliminar_reportesalida
            // 
            this.btn_eliminar_reportesalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_eliminar_reportesalida.Location = new System.Drawing.Point(0, 109);
            this.btn_eliminar_reportesalida.Name = "btn_eliminar_reportesalida";
            this.btn_eliminar_reportesalida.Size = new System.Drawing.Size(200, 109);
            this.btn_eliminar_reportesalida.TabIndex = 3;
            this.btn_eliminar_reportesalida.Text = "Eliminar";
            this.btn_eliminar_reportesalida.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo_reportesalida
            // 
            this.btn_nuevo_reportesalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nuevo_reportesalida.Location = new System.Drawing.Point(0, 0);
            this.btn_nuevo_reportesalida.Name = "btn_nuevo_reportesalida";
            this.btn_nuevo_reportesalida.Size = new System.Drawing.Size(200, 109);
            this.btn_nuevo_reportesalida.TabIndex = 2;
            this.btn_nuevo_reportesalida.Text = "Nuevo";
            this.btn_nuevo_reportesalida.UseVisualStyleBackColor = true;
            this.btn_nuevo_reportesalida.Click += new System.EventHandler(this.btn_nuevo_reportesalida_Click);
            // 
            // dgv_reportersalida
            // 
            this.dgv_reportersalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reportersalida.Location = new System.Drawing.Point(6, 6);
            this.dgv_reportersalida.Name = "dgv_reportersalida";
            this.dgv_reportersalida.RowHeadersWidth = 51;
            this.dgv_reportersalida.RowTemplate.Height = 24;
            this.dgv_reportersalida.Size = new System.Drawing.Size(490, 448);
            this.dgv_reportersalida.TabIndex = 0;
            // 
            // FormsMenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormsMenuReportes";
            this.Text = "REPORTES";
            this.tabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidoproducto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportersalida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_reportersalida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_eliminar_reportesalida;
        private System.Windows.Forms.Button btn_nuevo_reportesalida;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_eliminar_reporterpedidoproducto;
        private System.Windows.Forms.Button btn_nuevo_reporterpedidoproducto;
        private System.Windows.Forms.DataGridView dgv_pedidoproducto;
    }
}