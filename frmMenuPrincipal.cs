using System;
using System.IO;

namespace GRUPO_C
{
    public partial class frmMenuPrincipal : Form
    {
        // SOLICITUD DE SERVICIO
        public static List<Int32> listaSolicitudesEnvio;
        public static int ultimaSolicitud;

        //ESTADO DE CUENTA
        // CLAVE:VALOR -> Num de envio - Tarifa PARA EL PROTOTIPO
        public static Dictionary<int, float> FacturasPagadas; // CLAVE:VALOR -> Num de envio - Tarifa PARA EL PROTOTIPO
        public static Dictionary<int, float> FacturasPendientesPago;
        public static Dictionary<int, float> EnviosPendientesFacturar;
        public static float saldoTotal;
        public static bool testPrimeraVez; // solo en prototipo

        // LOGIN
        List<ClienteCorporativo> listaClientesCorporativos = new List<ClienteCorporativo>();
        ClienteCorporativo cliente;
        public static int numerocliente;

        public frmMenuPrincipal()
        {
            listaSolicitudesEnvio = new List<Int32>(); // ES LA LISTA DE SOLICITUDES DEL USUARIO QUE USA EL SISTEMA. PARA EL PROTOTIPO HAY UN USUARIO SOLO, POR ESO ES IGUAL EN TODO EL SISTEMA
            ultimaSolicitud = 1; // Inicia el sistema, el numero de solicitud es 1
            FacturasPagadas = new Dictionary<int, float>();
            FacturasPendientesPago = new Dictionary<int, float>();
            EnviosPendientesFacturar = new Dictionary<int, float>();
            testPrimeraVez = true;
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

        public void DeshabilitarMenu()
        {
            SolicitudCancelacionEnvioMenu.Enabled = false;
            EstadoDelServicioMenu.Enabled = false;
            EstadoDeCuentaMenu.Enabled = false;
        }
    }
}