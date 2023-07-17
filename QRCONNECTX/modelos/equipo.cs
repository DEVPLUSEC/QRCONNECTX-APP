using System;
using System.Collections.Generic;
using System.Text;

namespace QRCONNECTX.modelos
{
    public class Equipo
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public int tipo { get; set; }
        public string marca { get; set; }
        public string caracteristicas { get; set; }
        public string descripcion { get; set; }
        public string observaciones { get; set; }
        public string evidencia { get; set; }
        public string estado { get; set; }
        public int usuario_modificacion { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime fecha_actualizacion { get; set; }
        public string codigo_qr { get; set; }
    }

}
