namespace Practica_clase_MOANSO
{
    partial class FormsMenuTransacciones
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_anular_transventa = new System.Windows.Forms.Button();
            this.btn_nuevo_transventa = new System.Windows.Forms.Button();
            this.dtg_transaccion_venta = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_anular_transST = new System.Windows.Forms.Button();
            this.btn_nuevo_transST = new System.Windows.Forms.Button();
            this.dtg_transaccion_ST = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_transaccion_venta)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_transaccion_ST)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dtg_transaccion_venta);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_anular_transventa);
            this.panel1.Controls.Add(this.btn_nuevo_transventa);
            this.panel1.Location = new System.Drawing.Point(574, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 233);
            this.panel1.TabIndex = 4;
            // 
            // btn_anular_transventa
            // 
            this.btn_anular_transventa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_anular_transventa.Location = new System.Drawing.Point(0, 111);
            this.btn_anular_transventa.Name = "btn_anular_transventa";
            this.btn_anular_transventa.Size = new System.Drawing.Size(200, 111);
            this.btn_anular_transventa.TabIndex = 2;
            this.btn_anular_transventa.Text = "Anular";
            this.btn_anular_transventa.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo_transventa
            // 
            this.btn_nuevo_transventa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nuevo_transventa.Location = new System.Drawing.Point(0, 0);
            this.btn_nuevo_transventa.Name = "btn_nuevo_transventa";
            this.btn_nuevo_transventa.Size = new System.Drawing.Size(200, 111);
            this.btn_nuevo_transventa.TabIndex = 1;
            this.btn_nuevo_transventa.Text = "Nuevo";
            this.btn_nuevo_transventa.UseVisualStyleBackColor = true;
            this.btn_nuevo_transventa.Click += new System.EventHandler(this.btn_nuevo_transventa_Click);
            // 
            // dtg_transaccion_venta
            // 
            this.dtg_transaccion_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_transaccion_venta.Location = new System.Drawing.Point(6, 6);
            this.dtg_transaccion_venta.Name = "dtg_transaccion_venta";
            this.dtg_transaccion_venta.RowHeadersWidth = 51;
            this.dtg_transaccion_venta.RowTemplate.Height = 24;
            this.dtg_transaccion_venta.Size = new System.Drawing.Size(540, 431);
            this.dtg_transaccion_venta.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.dtg_transaccion_ST);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(818, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Servicio Tecnico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_anular_transST);
            this.panel3.Controls.Add(this.btn_nuevo_transST);
            this.panel3.Location = new System.Drawing.Point(574, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 233);
            this.panel3.TabIndex = 1;
            // 
            // btn_anular_transST
            // 
            this.btn_anular_transST.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_anular_transST.Location = new System.Drawing.Point(0, 111);
            this.btn_anular_transST.Name = "btn_anular_transST";
            this.btn_anular_transST.Size = new System.Drawing.Size(200, 111);
            this.btn_anular_transST.TabIndex = 1;
            this.btn_anular_transST.Text = "Anular";
            this.btn_anular_transST.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo_transST
            // 
            this.btn_nuevo_transST.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nuevo_transST.Location = new System.Drawing.Point(0, 0);
            this.btn_nuevo_transST.Name = "btn_nuevo_transST";
            this.btn_nuevo_transST.Size = new System.Drawing.Size(200, 111);
            this.btn_nuevo_transST.TabIndex = 0;
            this.btn_nuevo_transST.Text = "Nuevo";
            this.btn_nuevo_transST.UseVisualStyleBackColor = true;
            this.btn_nuevo_transST.Click += new System.EventHandler(this.btn_nuevo_transST_Click);
            // 
            // dtg_transaccion_ST
            // 
            this.dtg_transaccion_ST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_transaccion_ST.Location = new System.Drawing.Point(6, 6);
            this.dtg_transaccion_ST.Name = "dtg_transaccion_ST";
            this.dtg_transaccion_ST.RowHeadersWidth = 51;
            this.dtg_transaccion_ST.RowTemplate.Height = 24;
            this.dtg_transaccion_ST.Size = new System.Drawing.Size(540, 431);
            this.dtg_transaccion_ST.TabIndex = 0;
            // 
            // FormsMenuTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormsMenuTransacciones";
            this.Text = "TRANSACCIONES";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_transaccion_venta)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_transaccion_ST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_nuevo_transventa;
        private System.Windows.Forms.DataGridView dtg_transaccion_venta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_anular_transventa;
        private System.Windows.Forms.DataGridView dtg_transaccion_ST;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_anular_transST;
        private System.Windows.Forms.Button btn_nuevo_transST;
    }
}