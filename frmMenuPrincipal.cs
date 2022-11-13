using System;
using System.IO;

namespace GRUPO_C
{
    public partial class frmMenuPrincipal : Form
    {
        // LOGIN
        List<ClienteCorporativo> listaClientesCorporativos = new List<ClienteCorporativo>();
        ClienteCorporativo cliente;
        public static int numerocliente; // IMPORTANTE: ESTE VA A SER EL NUMERO DE CLIENTE DEL USUARIO LOGEADO. LOS OTROS MODULOS VAN A VENIR A LEERLO.

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void SolicitudCancelacionEnvioMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (formularios.frmSolicitudServicio frmSolicitudServicio = new formularios.frmSolicitudServicio())
            frmSolicitudServicio.ShowDialog();
            Show();
        }

        private void EstadoServicioMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (formularios.frmEstadoServicio frmEstadoServicio = new formularios.frmEstadoServicio())
            frmEstadoServicio.ShowDialog();
            Show();
        }
        private void estadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (formularios.frmEstadoCuenta frmEstadoCuenta = new formularios.frmEstadoCuenta())
            frmEstadoCuenta.ShowDialog();
            Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            listaClientesCorporativos.Clear();

            // Ir al archivo a buscar los clientes corporativos y guardar cada objeto ClienteCorporativo en la lista

            // Acceder al archivo de esta manera si el proyecto se esta ejecutando desde la carpeta bin
            string path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\", "Archivos/ClienteCorporativo.txt");

            //string path = "Archivos/ClienteCorporativo.txt"; LA RUTA DEPENDE DE LA PC, USAR ESTE SI LA DE ARRIBA NO FUNCIONA

            using (StreamReader sr = new StreamReader(path))

            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                string[] vector = linea.Split(';');

                ClienteCorporativo clientecorporativo = new ClienteCorporativo();
                clientecorporativo.NumeroCliente = int.Parse(vector[0]);
                clientecorporativo.RazonSocial = vector[1];
                clientecorporativo.CUIT = vector[2];
                clientecorporativo.Direccion = vector[3];
                clientecorporativo.Contraseña = vector[4];

                listaClientesCorporativos.Add(clientecorporativo);
            }


            string errores = "";
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errores += "Debe ingresar un CUIL" + "\n";
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errores += "Debe ingresar una contraseña" + "\n";
            }

            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores, "Error.");
            }
            else
            {
                // Busco si coinicide con algun usuario de la lista (archivo que cargue de clientes corporativos)
                cliente = listaClientesCorporativos.Find(O => O.CUIT == txtUsuario.Text && O.Contraseña == txtPassword.Text);

                if (cliente == null)
                {
                    MessageBox.Show("El usuario o contraseña ingresados son incorrectos.", "Error");
                }
                else
                {
                    numerocliente = cliente.NumeroCliente;
                    MessageBox.Show("Inicio de sesión correcto.", "Sesión iniciada");
                    HabilitarMenu();

                    // Hago invisible los labels, textbox y botones de login
                    lblUsuario.Visible = false;
                    lblContraseña.Visible = false;
                    txtUsuario.Visible = false;
                    txtPassword.Visible = false;
                    btnIniciarSesion.Visible = false;
                    lblBienvenida.Text = "Bienvenido/a al Sistema: " + cliente.CUIT;
                    lblBienvenida.Visible = true;
                }
            }
        }

        public void HabilitarMenu()
        {
            SolicitudCancelacionEnvioMenu.Enabled = true;
            EstadoDelServicioMenu.Enabled = true;
            EstadoDeCuentaMenu.Enabled = true;
        }
    }
}