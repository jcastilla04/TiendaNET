using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CryptSharp;       //ENCRIPTAR
using BOL;              //LOGICA
using ENTITIES;         //ESTRUCTURA
using DESIGNER.Tools;   //HERRAMIENTA

namespace DESIGNER.Modulos
{
    public partial class frmUsuario : Form
    {
        //Objeto "usuario" contiene las funciones/lógica =>Regitsrar, listar, eliminar,etc.
        Usuario usuario = new Usuario();

        //Objeto "entUsuario" contiene los datos => apellidos, nombres,email,clave,etc
        EUsuario entUsuario = new EUsuario();

        string nivelAcceso = "INV";

        //Reservado un espacio de memoria para el objeto (Vista Datos)
        DataView dv;

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Aviso.Preguntar("¿Estas seguro de guardar?") == DialogResult.Yes)
            {
                string claveEncriptada = Crypter.Blowfish.Crypt(txtClave.Text.Trim());

                entUsuario.apellidos = txtApellido.Text;
                entUsuario.nombres = txtNombre.Text;
                entUsuario.email = txtEmail.Text;
                entUsuario.claveacceso = claveEncriptada;
                entUsuario.nivelAcceso = nivelAcceso;

                if (usuario.Registrar(entUsuario) > 0)
                {
                    reiniciarInterfaz();
                    actualizarDatos();      //ACTUALIZAR DATAGRIDIVIEW
                    Aviso.Informar("Nuevo usuario registrado");
                }
                else
                {
                    Aviso.Advertir("No hemos podido terminar el registro");
                }
            }
        }

        private void actualizarDatos()
        {
            dv = new DataView(usuario.Listar());
            gridUsuarios.DataSource = dv;
            gridUsuarios.Refresh();

            gridUsuarios.Columns[0].Visible = false;  //ID
            gridUsuarios.Columns[4].Visible = false;  //CLAVE

            gridUsuarios.Columns[1].Width = 215;      //APELLIDOS
            gridUsuarios.Columns[2].Width = 215;      //NOMBRES
            gridUsuarios.Columns[3].Width = 215;      //EMAIL
            gridUsuarios.Columns[5].Width = 215;      //NIVEL ACCESO

            //FILAS CEBRADAS
            gridUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateGray;
        }

        private void reiniciarInterfaz()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtClave.Clear();
            optInvitado.Checked = true;
            nivelAcceso = "INV";
            txtApellido.Focus();
        }

        private void optAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            nivelAcceso = "ADM";
        }

        private void optInvitado_CheckedChanged(object sender, EventArgs e)
        {
            nivelAcceso = "INV";
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private void gridUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridUsuarios.ClearSelection();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dv.RowFilter = "nombres LIKE '%" + txtBuscar.Text+ "%' OR apellidos LIKE '%" + txtBuscar.Text + "%'";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
