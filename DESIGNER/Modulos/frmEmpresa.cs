using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CryptSharp;
using BOL;
using ENTITIES;
using DESIGNER.Tools;

namespace DESIGNER.Modulos
{
    public partial class frmEmpresa : Form
    {
        Empresa empresa = new Empresa();
        EEmpresa entEmpresa = new EEmpresa();
        DataView ep;
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Aviso.Preguntar("¿Estas seguro de guardar?") == DialogResult.Yes)
            {
                entEmpresa.razon_social = txtrazon.Text;
                entEmpresa.ruc = txtRUC.Text;
                entEmpresa.direccion = txtdireccion.Text;
                entEmpresa.telefono = txttelefono.Text;
                entEmpresa.email = txtemail.Text;
                entEmpresa.website = txtwebsite.Text;

                if (empresa.Registar(entEmpresa) > 0)
                {
                    reiniciarInterfaz();
                    actualizarDatos();
                    Aviso.Informar("Empresa registrada correctamente");
                }
                else
                {
                    Aviso.Advertir("No se ha podido registrar la empresa");
                }
            }
                }

        private void actualizarDatos()
        {
            ep = new DataView(empresa.Listar());
            gridEmpresa.DataSource = ep;
            gridEmpresa.Refresh();

            gridEmpresa.Columns[0].Visible = false; 

            gridEmpresa.Columns[1].Width = 170;      
            gridEmpresa.Columns[2].Width = 155;      
            gridEmpresa.Columns[3].Width = 155;
            gridEmpresa.Columns[4].Width = 155;
            gridEmpresa.Columns[5].Width = 160;
            gridEmpresa.Columns[6].Width = 140;
   

            //FILAS CEBRADAS
            gridEmpresa.AlternatingRowsDefaultCellStyle.BackColor = Color.SpringGreen;
        }
        private void reiniciarInterfaz()
        {
            txtrazon.Clear();
            txtRUC.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtwebsite.Clear();
        }

        private void FormularioE()
        {
            int num;
            if(txtrazon.Text.Trim() == String.Empty)
            {
                frmError.SetError(txtrazon, "Completa el campo");
                num = 1;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ep.RowFilter = "razonsocial LIKE '%" + txtBuscar.Text + "%'";
        }
    }
    }

