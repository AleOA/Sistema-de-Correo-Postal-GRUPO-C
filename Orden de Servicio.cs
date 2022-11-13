using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GRUPO_C.formularios
{
    class OrdenDeServicio
    {
        // LocalidadDestino,Modalidad Destino,DireccionOrigen,DireccionDestino,Tarifa,EstaFacturada,DescripcionEstadoOrdenServicio
        public int IdOrden { get; set; }
        public int NumeroCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Prioridad { get; set; }
        public string Peso { get; set; } // es rango de peso
        public string ProvinciaOrigen { get; set; }
        public string RegionOrigen { get; set; }
        public string LocalidadOrigen { get; set; }
        public string ModalidadOrigen { get; set; }
        public string PaisDestino { get; set; }
        public string ProvinciaDestino { get; set; }
        public string RegionDestino { get; set; }
        public string LocalidadDestino { get; set; }
        public string ModalidadDestino { get; set; }
        public string DireccionOrigen { get; set; }
        public string DireccionDestino { get; set; }
        public decimal Tarifa { get; set; }
        public bool EstaFacturada { get; set; }
        public string DescripcionEstadoOrdenServicio { get; set; }

        public OrdenDeServicio()
        {

        }


        public override string ToString()
        {
            return string.Format("ID de orden: {0}" +
                "\nEstado de la orden: {18}" +
                "\n\nNumero de cliente: {1}" +
                "\nFecha: {2}" +
                "\nPrioridad: {3}" +
                "\nPeso: {4} Kg." +
                "\n\n--Datos de origen--" +
                "\nPrivincia: {5}" +
                "\nRegion: {6}" +
                "\nLocalidad: {7}" +
                "\nModalidad: {8}" +
                "\nDireccion origen: {14}" +
                "\n\n--Datos de destino--" +
                "\nPais: {9}" +
                "\nPrivincia: {10}" +
                "\nRegion: {11}" +
                "\nLocalidad: {12}" +
                "\nModalidad: {13}" +
                "\nDierccion destino: {15}" +
                "\n\nTarifa: ${16}",
                IdOrden, NumeroCliente, Fecha, Prioridad, Peso, ProvinciaOrigen, RegionOrigen, LocalidadOrigen, ModalidadOrigen,
               PaisDestino, ProvinciaDestino, RegionDestino, LocalidadDestino, ModalidadDestino, DireccionOrigen, DireccionDestino,
              Tarifa, EstaFacturada, DescripcionEstadoOrdenServicio);
        }

        public string ToCSV()
        {
            return string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14};{15};{16};{17};{18}",
                IdOrden, NumeroCliente, Fecha, Prioridad, Peso, ProvinciaOrigen, RegionOrigen, LocalidadOrigen, ModalidadOrigen,
                PaisDestino, ProvinciaDestino, RegionDestino, LocalidadDestino, ModalidadDestino, DireccionOrigen, DireccionDestino,
                Tarifa, EstaFacturada, DescripcionEstadoOrdenServicio);
        }
    }

}
