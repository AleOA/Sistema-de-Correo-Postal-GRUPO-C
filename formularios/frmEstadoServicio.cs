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
    public partial class frmEstadoServicio : Form
    {
        List<OrdenDeServicio> listaOrdenesdeServicioanteriores = new List<OrdenDeServicio>();
        List<int> numerosordenesusuario = new List<int>();

        public frmEstadoServicio()
        {
            InitializeComponent();
        }

        private void btnConsultarEstado_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtIngreseNumSol.Text)){
                MessageBox.Show("Debe ingresar el numero de envío", "Error");
            } 
            else
            {
                // Acceder al archivo de esta manera si el proyecto se esta ejecutando desde la carpeta bin
                string path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\", "Archivos/OrdenDeServicio.txt");

                //string path = "Archivos/OrdenDeServicio.txt"; LA RUTA DEPENDE DE LA PC, USAR ESTE SI LA DE ARRIBA NO FUNCIONA

                using (StreamReader sr = new StreamReader(path))

                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] vector = linea.Split(';');

                        if (frmMenuPrincipal.numerocliente == int.Parse(vector[1]))
                        {
                            OrdenDeServicio ordendeservicio = new OrdenDeServicio();
                            ordendeservicio.IdOrden = int.Parse(vector[0]);
                            numerosordenesusuario.Add(int.Parse(vector[0]));
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
                            ordendeservicio.Tarifa = decimal.Parse(vector[16]);
                            ordendeservicio.EstaFacturada = bool.Parse(vector[17]);
                            ordendeservicio.DescripcionEstadoOrdenServicio = vector[18];
                            listaOrdenesdeServicioanteriores.Add(ordendeservicio);
                        }
                    }

                string numeroIngresado = txtIngreseNumSol.Text;
                bool flagNumero;
                int numerosolicitud;
                flagNumero = Int32.TryParse(numeroIngresado, out numerosolicitud);

                if (!flagNumero || numerosolicitud < 0)
                {
                    MessageBox.Show("El campo debe ser numérico y entero", "Error");
                }
                else if (!numerosordenesusuario.Contains(numerosolicitud))
                {
                    MessageBox.Show("No se pudo encontrar la solicitud ingresada", "Error");
                }
                else
                {

                    OrdenDeServicio orden = listaOrdenesdeServicioanteriores.Find(o => o.IdOrden == numerosolicitud);
                    string mensaje = orden.ToString();


                    MessageBox.Show(mensaje, "Orden de servicio Nro " + numeroIngresado);
                }
            }
        }
    }
}
