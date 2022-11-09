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
        List<int> listaSolicitudes = new List<int>();
        List<string> listaEstados = new List<string>();

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
                string numeroIngresado = txtIngreseNumSol.Text;
                bool flagNumero;
                int numerosolicitud;
                flagNumero = Int32.TryParse(numeroIngresado, out numerosolicitud);

                if (!flagNumero || numerosolicitud < 0)
                {
                    MessageBox.Show("El campo debe ser numérico y entero", "Error");
                }
                else if (!listaSolicitudes.Contains(numerosolicitud))
                {
                    MessageBox.Show("No se pudo encontrar la solicitud ingresada", "Error");
                }
                else
                {
                    // En el prototipo le asigno de prueba:
                    // Solicitud numero 1 le asigno el estado recibida
                    // Solicitud numero 2 le asigno el estado en transito
                    // Solicitud numero 3 le asigno el estado cerrada

                    //EN TP FINAL los datos se llenan del archivo

                    if(numerosolicitud == 1)
                    {
                        MessageBox.Show("El estado de la solictud " + numerosolicitud + " es: " + listaEstados[0] + "\n" + "\n"
                            + "Region Origen: Metropolitana"+ "\n" + "Provincia Origen: Buenos Aires" + "\n" + "Localidad Origen: Tandil" + "\n"
                            + "Modalidad Origen: Sucursal" + "\n" + "Peso (KG): 10-20" + "\n" + "Prioridad: No Urgente" + "\n"
                            + "Pais Destino: Argentina" + "\n" + "Region Destino: Metropolitana" + "\n" + "Provincia Destino: Buenos Aires" + "\n"
                            + "Localidad Destino: Tandil" + "\n" + "Modalidad Destino: Sucursal" + "\n" + "Tarifa: 4200$" + "\n");
                    } else if (numerosolicitud == 2)
                    {
                        MessageBox.Show("El estado de la solictud " + numerosolicitud + " es: " + listaEstados[1] + "\n" + "\n"
                            + "Region Origen: Metropolitana" + "\n" + "Provincia Origen: CABA" + "\n" + "Localidad Origen: CABA " + "\n"
                            + "Modalidad Origen: Sucursal" + "\n" + "Peso (KG): 20-30" + "\n" + "Prioridad: No Urgente" + "\n"
                            + "Pais Destino: España" + "\n" + "Region Destino: Europa" + "\n" + "Direccion Destino: bartolome mitre 24533" 
                            + "\n" + "Tarifa: $12825" + "\n");
                    } else if(numerosolicitud == 3)
                    {
                        MessageBox.Show("El estado de la solictud " + numerosolicitud + " es: " + listaEstados[2] + "\n" + "\n"
                            + "Region Origen: Sur" + "\n" + "Provincia Origen: Santa Cruz" + "\n" + "Localidad Origen: El Calafate" + "\n"
                            + "Modalidad Origen: Puerta" + "\n"+ "Direccion: rivadavia 34235" + "\n" + "Peso (KG): 0-0.5" + "\n" + "Prioridad: Urgente" + "\n"
                            + "Pais Destino: Argentina" + "\n" + "Region Destino: Metroplitana" + "\n" + "Provincia Destino: Buenos Aires" + "\n"
                            + "Localidad Destino: Lujan" + "\n" + "Modalidad Destino: Sucursal" + "\n" + "Tarifa: $4925" + "\n");
                    }
                }
            }
        }

        private void frmEstadoServicio_Load(object sender, EventArgs e)
        {
            CargarSolicitudes();
        }

        private void CargarSolicitudes()
        {
            // fuera del prototipo cargaria el archivo de solicitudes correspondientes al usuario y lo guardaria en una lista de objetos
            // Cargo Nrosolicitud y Estado de prueba para el prototipo

            listaSolicitudes.Add(1);
            listaSolicitudes.Add(2);
            listaSolicitudes.Add(3);

            listaEstados.Add("Recibida");
            listaEstados.Add("En Transito");
            listaEstados.Add("Cerrada");
        }
    }
}
