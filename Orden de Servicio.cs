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
        public float Tarifa { get; set; }
        public bool EstaFacturada { get; set; }
        public string DescripcionEstadoOrdenServicio { get; set; }

        public OrdenDeServicio()
        {

        }


        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}\n{10}\n{11}\n{12}\n{13}\n{14}\n{15}\n{16}\n{17}\n{18}",
                IdOrden, NumeroCliente, Fecha, Prioridad, Peso, ProvinciaOrigen, RegionOrigen, LocalidadOrigen, ModalidadOrigen,
               PaisDestino, ProvinciaDestino, RegionDestino, LocalidadDestino, ModalidadDestino, DireccionOrigen, DireccionDestino,
              Tarifa, EstaFacturada, DescripcionEstadoOrdenServicio);
        }

        //public string ToCSV()
        //{
        //    return string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14};{15};{16};{17};{18};{19}",
        //        IdOrden, NumeroCliente, Fecha, Prioridad, Peso, ProvinciaOrigen, RegionOrigen, LocalidadOrigen, ModalidadOrigen,
        //        PaisDestino, ProvinciaDestino, RegionDestino, LocalidadDestino, ModalidadDestino, DireccionOrigen, DireccionDestino,
        //        Tarifa, EstaFacturada, DescripcionEstadoOrdenServicio);
        //}
    }

}
