using System;
using System.Collections.Generic;
using System.Text;

namespace QRCONNECTX.modelos
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public DateTime? fecha_verificacion_correo { get; set; }
        public string password { get; set; }
        public string remember_token { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public int genero { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public int provincia { get; set; }
        public int canton { get; set; }
        public int tipo_usuario { get; set; }
        public string estado { get; set; }
        public string imagen_perfil { get; set; }
        public int empresa { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime? fecha_actualizacion { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? created_at { get; set; }
    }
}
