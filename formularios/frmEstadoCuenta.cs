using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRUPO_C.formularios
{
    public partial class frmEstadoCuenta : Form
    {
        // Lista ordenes de servicio
        List<OrdenDeServicio> listaOrdenesdeServicio = new List<OrdenDeServicio>();

        // Lista Facturas pendientes de pago
        List<Factura> listaFacturasPendientesPago = new List<Factura>();

        // Lista Facturas pagas
        List<Factura> listaFacturasPagas = new List<Factura>();

        public frmEstadoCuenta()
        {
            InitializeComponent();
        }

        // CLAVE:VALOR -> Num de envio - Tarifa PARA EL PROTOTIPO
        //Dictionary<int, float> FacturasPagadas = new Dictionary<int, float>(); // CLAVE:VALOR -> Num de envio - Tarifa PARA EL PROTOTIPO
        //Dictionary<int, float> FacturasPendientesPago = new Dictionary<int, float>();
        //Dictionary<int, float> EnviosPendientesFacturar = new Dictionary<int, float>();
        //float saldoTotal;
        private void frmEstadoCuenta_Load(object sender, EventArgs e)
        {
            CargarEstadoCuenta();
        }

        private void CargarEstadoCuenta()
        {

            // 1ERO FACTURO AQUELLAS ORDENES NO FACTURADAS (1 VEZ AL MES SE FACTURA, POR LO QUE FACTURO LAS QUE NO PERTENEZCAN AL MES ACTUAL (MESES ANTERIORES) Y NO ESTAN FACTURADAS)

            // Acceder al archivo de esta manera si el proyecto se esta ejecutando desde la carpeta bin
            string path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\", "Archivos/OrdenDeServicio.txt");

            //string path = "Archivos/OrdenDeServicio.txt"; LA RUTA DEPENDE DE LA PC, USAR ESTE SI LA DE ARRIBA NO FUNCIONA

            // ABRO ARCHIVO ORDENES DE SERVICIO Y ALMACENO LAS ORDENES EN LA LISTA listaOrdenesdeServicio
            using (StreamReader sr = new StreamReader(path))

                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] vector = linea.Split(';');
                    OrdenDeServicio ordendeservicio = new OrdenDeServicio();
                    ordendeservicio.IdOrden = int.Parse(vector[0]);
                    ordendeservicio.NumeroCliente = int.Parse(vector[1]);
                    ordendeservicio.Fecha = DateTime.Parse(vector[2]);
                    ordendeservicio.Prioridad = vector[3];
                    ordendeservicio.Peso = vector[4];
                    ordendeservicio.ProvinciaOrigen = vector[5];
                    ordendeservicio.RegionOrigen = vector[6];
                    ordendeservicio.LocalidadOrigen = vector[7];
                    ordendeservicio.ModalidadOrigen = vector[8];
                    ordendeservicio.PaisDestino = vector[9];
                    ordendeservicio.ProvinciaDestino = vector[10];
                    ordendeservicio.RegionDestino = vector[11];
                    ordendeservicio.LocalidadDestino = vector[12];
                    ordendeservicio.ModalidadDestino = vector[13];
                    ordendeservicio.DireccionOrigen = vector[14];
                    ordendeservicio.DireccionDestino = vector[15];
                    ordendeservicio.Tarifa = float.Parse(vector[16]);
                    ordendeservicio.EstaFacturada = bool.Parse(vector[17]);
                    ordendeservicio.DescripcionEstadoOrdenServicio = vector[18];
                    listaOrdenesdeServicio.Add(ordendeservicio);
  
                }


            // Acceder al archivo de esta manera si el proyecto se esta ejecutando desde la carpeta bin
            string pathFacturas = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\", "Archivos/Facturas.txt");
            //string path = "Archivos/Facturas.txt"; LA RUTA DEPENDE DE LA PC, USAR ESTE SI LA DE ARRIBA NO FUNCIONA


            // ABRO ARCHIVO FACTURAS Y VERIFICO PARA CADA ORDEN DE SERVICIO SI ESTA FACTURADA O NO. SI NO LO ESTA y cumple requisitos, GENERO FACTURA, La guardo en archivo Y CAMBIO EL ATRIBUTO ESTA FACTURADA de orden A TRUE
            using (StreamWriter swfactura = new StreamWriter(pathFacturas,true))

            foreach (OrdenDeServicio orden in listaOrdenesdeServicio)
            {
                    int mesOrden = orden.Fecha.Month;
                    int añoOrden = orden.Fecha.Year;

                    if ((orden.EstaFacturada == false) && ((mesOrden < DateTime.Now.Month && añoOrden == DateTime.Now.Year) || (añoOrden < DateTime.Now.Year)))
                    {
                        Factura f = new Factura();
                        f.IdOrden = orden.IdOrden;

                        DateTime fechaorden = orden.Fecha;
                        f.Fecha = new DateTime(fechaorden.Year, fechaorden.Month, 28, 23, 59, 0); // Se factura el 28 de cada mes la orden (mensual)
                        f.NumeroCliente = orden.NumeroCliente;
                        f.Estado = "Pendiente de Pago";
                        f.Importe = orden.Tarifa;

                        swfactura.WriteLine(f.ToCSV());
                        orden.EstaFacturada = true;
                    }
            }

            // Guardo todas las ordenes de servicio otra vez en archivo, actualizadas con su estado estaFacturada
            using (StreamWriter sworden = new StreamWriter(path))
                foreach (OrdenDeServicio orden in listaOrdenesdeServicio)
                    {
                        sworden.WriteLine(orden.ToCSV());
                    }

            listaOrdenesdeServicio.Clear();


            // DESCARGO ORDENES DE SERVICIO ACTUALIZADAS (SOLO DEL USUARIO) Y LAS GUARDO EN LISTA

            using (StreamReader sr = new StreamReader(path))

                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] vector = linea.Split(';');

                    if(frmMenuPrincipal.numerocliente == int.Parse(vector[1]))
                    {
                        OrdenDeServicio ordendeservicio = new OrdenDeServicio();
                        ordendeservicio.IdOrden = int.Parse(vector[0]);
                        ordendeservicio.NumeroCliente = int.Parse(vector[1]);
                        ordendeservicio.Fecha = DateTime.Parse(vector[2]);
                        ordendeservicio.Prioridad = vector[3];
                        ordendeservicio.Peso = vector[4];
                        ordendeservicio.ProvinciaOrigen = vector[5];
                        ordendeservicio.RegionOrigen = vector[6];
                        ordendeservicio.LocalidadOrigen = vector[7];
                        ordendeservicio.ModalidadOrigen = vector[8];
                        ordendeservicio.PaisDestino = vector[9];
                        ordendeservicio.ProvinciaDestino = vector[10];
                        ordendeservicio.RegionDestino = vector[11];
                        ordendeservicio.LocalidadDestino = vector[12];
                        ordendeservicio.ModalidadDestino = vector[13];
                        ordendeservicio.DireccionOrigen = vector[14];
                        ordendeservicio.DireccionDestino = vector[15];
                        ordendeservicio.Tarifa = float.Parse(vector[16]);
                        ordendeservicio.EstaFacturada = bool.Parse(vector[17]);
                        ordendeservicio.DescripcionEstadoOrdenServicio = vector[18];
                        listaOrdenesdeServicio.Add(ordendeservicio);
                    }
                }

            // DESCARGO FACTURAS
            using (StreamReader srfacturas = new StreamReader(pathFacturas))

                while (!srfacturas.EndOfStream)
                {
                    string linea = srfacturas.ReadLine();
                    string[] vector = linea.Split(';');
                    Factura f = new Factura();

                    f.IdOrden = int.Parse(vector[0]);
                    f.Fecha = DateTime.Parse(vector[1]);
                    f.NumeroCliente = int.Parse(vector[2]);
                    f.Estado = vector[3];
                    f.Importe = float.Parse(vector[4]);

                    if(vector[3] == "Pendiente de Pago")
                    {
                        listaFacturasPendientesPago.Add(f);
                    }
                    else
                    {
                        listaFacturasPagas.Add(f);
                    }

                }


            // MUESTRO ESTADO DE CUENTA
            foreach(Factura f in listaFacturasPendientesPago)
            {
                lstFacturasAPagar.Items.Add(f.ToCSV());
            }
            foreach (Factura f in listaFacturasPagas)
            {
                lvwFacturasPagadas.Items.Add(f.ToCSV());
            }
            foreach (OrdenDeServicio o in listaOrdenesdeServicio)
            {
                lvwPendienteFacturar.Items.Add(o.ToCSV());
            }

            if (listaFacturasPendientesPago.Count == 0)
            {
                lblSaldoEstadodeCuenta.Text = "Estado: No tiene facturas pendientes de pago.";
            }
            else
            {
                float saldoTotal = 0;
                saldoTotal = CalcularSaldo(saldoTotal);
                lblSaldoEstadodeCuenta.Text = "Estado: Tiene facturas pendientes de pago por un total de: $" + saldoTotal;
            }
        }

        private float CalcularSaldo(float saldoTotal)
        {
            foreach(Factura f in listaFacturasPendientesPago)
            {
                saldoTotal += f.Importe;
            }
            return saldoTotal;
        }

        private void btnFacturasAPagar_Click(object sender, EventArgs e)
        {
            if (lstFacturasAPagar.Items.Count == 0)
            {
                MessageBox.Show("No hay facturas a pagar en su cuenta.", "Error.");
            }
            else if (lstFacturasAPagar.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una factura a pagar.", "Error.");
            } else
            {
                // FALTA ESTO

                string facturaSeleccionada = lstFacturasAPagar.Text;
                int indiceSeleccionado = lstFacturasAPagar.SelectedIndex;



                int indexguion = facturaSeleccionada.IndexOf("-");
                int lengthfacturanum = indexguion - 1 - 9;

                int numFactura = Convert.ToInt32(facturaSeleccionada.Substring(9, lengthfacturanum));
                float valorFactura = Convert.ToSingle(facturaSeleccionada.Substring(facturaSeleccionada.IndexOf("$")+1));

                frmMenuPrincipal.FacturasPendientesPago.Remove(numFactura);
                lstFacturasAPagar.Items.RemoveAt(indiceSeleccionado);
                frmMenuPrincipal.FacturasPagadas.Add(numFactura, valorFactura);
                lvwFacturasPagadas.Items.Add(facturaSeleccionada);

                if(frmMenuPrincipal.FacturasPendientesPago.Count == 0)
                {
                    lblSaldoEstadodeCuenta.Text = "Estado: No tiene facturas pendientes de pago.";
                } else if (frmMenuPrincipal.FacturasPendientesPago.Count >= 0)
                {
                    frmMenuPrincipal.saldoTotal -= valorFactura;
                    lblSaldoEstadodeCuenta.Text = "Estado: Tiene facturas pendientes de pago por un total de: $" + frmMenuPrincipal.saldoTotal;
                }

                MessageBox.Show("Se pagó la factura " + numFactura +" de valor $" + valorFactura + " con éxito!", "Éxito!");
            }
        }

    }
}
