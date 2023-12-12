
namespace DESIGNER.Modulos
{
    partial class frmProductos
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
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtgarantia = new System.Windows.Forms.TextBox();
            this.cbosucategorias = new System.Windows.Forms.ComboBox();
            this.cbocategorias = new System.Windows.Forms.ComboBox();
            this.cbomarcas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnexportarxls = new System.Windows.Forms.Button();
            this.btnexportarpdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(12, 43);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(1043, 364);
            this.gridProductos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.txtgarantia);
            this.groupBox1.Controls.Add(this.cbosucategorias);
            this.groupBox1.Controls.Add(this.cbocategorias);
            this.groupBox1.Controls.Add(this.cbomarcas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del producto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(180, 32);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(634, 23);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Descripcion";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(644, 110);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(170, 23);
            this.txtprecio.TabIndex = 11;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(644, 141);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(170, 23);
            this.txtstock.TabIndex = 13;
            this.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtgarantia
            // 
            this.txtgarantia.Location = new System.Drawing.Point(644, 73);
            this.txtgarantia.Name = "txtgarantia";
            this.txtgarantia.Size = new System.Drawing.Size(170, 23);
            this.txtgarantia.TabIndex = 9;
            this.txtgarantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbosucategorias
            // 
            this.cbosucategorias.FormattingEnabled = true;
            this.cbosucategorias.Location = new System.Drawing.Point(180, 139);
            this.cbosucategorias.Name = "cbosucategorias";
            this.cbosucategorias.Size = new System.Drawing.Size(337, 25);
            this.cbosucategorias.TabIndex = 7;
            // 
            // cbocategorias
            // 
            this.cbocategorias.FormattingEnabled = true;
            this.cbocategorias.Location = new System.Drawing.Point(180, 107);
            this.cbocategorias.Name = "cbocategorias";
            this.cbocategorias.Size = new System.Drawing.Size(337, 25);
            this.cbocategorias.TabIndex = 5;
            this.cbocategorias.SelectedIndexChanged += new System.EventHandler(this.cbocategorias_SelectedIndexChanged);
            // 
            // cbomarcas
            // 
            this.cbomarcas.FormattingEnabled = true;
            this.cbomarcas.Location = new System.Drawing.Point(180, 76);
            this.cbomarcas.Name = "cbomarcas";
            this.cbomarcas.Size = new System.Drawing.Size(337, 25);
            this.cbomarcas.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Garantia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subcategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca:";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(895, 431);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(114, 23);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(895, 475);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(114, 23);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(895, 515);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(114, 23);
            this.btnmodificar.TabIndex = 4;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(895, 553);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(114, 23);
            this.btnimprimir.TabIndex = 5;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnexportarxls
            // 
            this.btnexportarxls.Location = new System.Drawing.Point(895, 591);
            this.btnexportarxls.Name = "btnexportarxls";
            this.btnexportarxls.Size = new System.Drawing.Size(54, 23);
            this.btnexportarxls.TabIndex = 6;
            this.btnexportarxls.Text = "XLS";
            this.btnexportarxls.UseVisualStyleBackColor = true;
            this.btnexportarxls.Click += new System.EventHandler(this.btnexportarxls_Click);
            // 
            // btnexportarpdf
            // 
            this.btnexportarpdf.Location = new System.Drawing.Point(955, 591);
            this.btnexportarpdf.Name = "btnexportarpdf";
            this.btnexportarpdf.Size = new System.Drawing.Size(54, 23);
            this.btnexportarpdf.TabIndex = 7;
            this.btnexportarpdf.Text = "PDF";
            this.btnexportarpdf.UseVisualStyleBackColor = true;
            this.btnexportarpdf.Click += new System.EventHandler(this.btnexportarpdf_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 637);
            this.Controls.Add(this.btnexportarpdf);
            this.Controls.Add(this.btnexportarxls);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridProductos);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtgarantia;
        private System.Windows.Forms.ComboBox cbosucategorias;
        private System.Windows.Forms.ComboBox cbocategorias;
        private System.Windows.Forms.ComboBox cbomarcas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnexportarxls;
        private System.Windows.Forms.Button btnexportarpdf;
    }
}