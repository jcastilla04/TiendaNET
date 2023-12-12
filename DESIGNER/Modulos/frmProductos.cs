using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BOL;
using DESIGNER.Tools;
using ENTITIES;

namespace DESIGNER.Modulos
{
    public partial class frmProductos : Form
    {
        Producto producto = new Producto();
        Categoria categoria = new Categoria();
        Subcategoria subcategoria = new Subcategoria();
        EProducto entproducto = new EProducto();
        Marca marca = new Marca();

        //ESTO ES UNA BANDERA = VARIABLE LOGICA QUE CONTROLA ESTADOS
        bool categoriasListas = false;
        public frmProductos()
        {
            InitializeComponent();
        }

        #region Métodos para carga de datos

        private void actualizarMarca()
        {
            cbomarcas.DataSource = marca.Listar();
            cbomarcas.DisplayMember = "marca"; //MOSTRAR | DEBE COINCIDIR CON LA CONSULTA
            cbomarcas.ValueMember = "idmarca"; //MOSTRAR | DEBE COINCIDIR CON LA CONSULTA
            cbomarcas.Refresh();
            //cbocategorias.Text = "";
        }


        private void actualizarCategorias()
        {
            cbocategorias.DataSource = categoria.listar();
            cbocategorias.DisplayMember = "categoria";
            cbocategorias.ValueMember = "idcategoria";
            cbocategorias.Refresh();
        }

        private void actualizarProductos()
        {
            gridProductos.DataSource = producto.listar();
            gridProductos.Refresh();
        }

        #endregion

        private void frmProductos_Load(object sender, EventArgs e)
        {
            actualizarProductos();
            actualizarMarca();
            actualizarCategorias();

            gridProductos.Columns[0].Visible = false;
            gridProductos.Columns[1].Width = 130;
            gridProductos.Columns[2].Width = 130;
            gridProductos.Columns[3].Width = 140;
            gridProductos.Columns[4].Width = 240;
            gridProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridProductos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridProductos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            categoriasListas = true;
        }

        private void cbocategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriasListas)
            {
                //Invocar al método que carga las subcategorias
                int idcategoria = Convert.ToInt32(cbocategorias.SelectedValue.ToString());
                cbosucategorias.DataSource = subcategoria.Listar(idcategoria);
                cbosucategorias.DisplayMember = "subcategoria";
                cbosucategorias.ValueMember = "idsubcategoria";
                cbosucategorias.Refresh();
                cbosucategorias.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void reiniciarInterfaz()
        {
            cbomarcas.Text = "";
            cbocategorias.Text = "";
            cbosucategorias.Text = "";
            txtDescripcion.Clear();
            txtgarantia.Clear();
            txtprecio.Clear();
            txtstock.Clear();
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Aviso.Preguntar("¿Estas seguro de registrar un nuevo producto?") == DialogResult.Yes)
            {
                entproducto.idmarca = Convert.ToInt32(cbomarcas.SelectedValue.ToString());
                entproducto.idsubcategoria = Convert.ToInt32(cbosucategorias.SelectedValue.ToString());
                entproducto.descripcion = txtDescripcion.Text;
                entproducto.garantia = Convert.ToInt32(txtgarantia.Text);
                entproducto.precio = Convert.ToDouble(txtprecio.Text);
                entproducto.stock = Convert.ToInt32(txtstock.Text);

                if(producto.registrar(entproducto) > 0)
                {
                    reiniciarInterfaz();
                    actualizarProductos();
                }
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            // 1. Crear instancia del reporte (CrystalReport)
            Reportes.rptProductos reporte = new Reportes.rptProductos();

            // 2. Asignar los datos al objeto reporte (creado en el paso 1)
            reporte.SetDataSource(producto.listar());
            reporte.Refresh();

            // 3. Instanciar el formulario donde se mostrará los reportes
            Reportes.frmVisorReportes formulario = new Reportes.frmVisorReportes();

            // 4. Pasamos el formulario al visor
            formulario.visor.ReportSource = reporte;
            formulario.visor.Refresh();

            formulario.ShowDialog();
        }
        /// <summary>
        /// Genera un archivo fisico del reporte
        /// </summary>
        /// <param name="extension">Utilice: XLS o PDF</param>
        private void ExportarDatos(string extension)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Title = "Reporte de productos";
            sd.Filter = $"Archivos en formato {extension.ToUpper()}|*.{extension.ToLower()}";

            if (sd.ShowDialog() == DialogResult.OK)
            {
                //CREAMOS UNA VERSION DEL REPORTE EN FOMRATO PDF
                // 1. Instancia del objeto reporte (CryptalReport)
                Reportes.rptProductos reporte = new Reportes.rptProductos();

                //2. Asignar los datos al objeto reporte
                reporte.SetDataSource(producto.listar());
                reporte.Refresh();

                // 3. El reporte creado y en memoria se ESCRIBIRÁ en el STORAGE
                if(extension.ToUpper() == "PDF")
                {
                    reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sd.FileName);
                }
                else if(extension.ToUpper() == "XLSX"){

                }
                reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.ExcelWorkbook, sd.FileName);

                //4. Notificar el usuario la creacion
                Aviso.Informar("Se ha creado el reporte correctamente");
            }
        }

        private void btnexportarpdf_Click(object sender, EventArgs e)
        {
            ExportarDatos("PDF");
        }

        private void btnexportarxls_Click(object sender, EventArgs e)
        {
            ExportarDatos("XLSX");
        }
    }
}