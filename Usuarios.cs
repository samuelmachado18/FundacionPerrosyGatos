using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Fundacion_Animales
{
   public class Usuarios
    {
        private int id_usuario;
        private string nombre_usuario;
        private string loginName;
        private string contrasena_hash;
        private string rol;
        private string estado;
        private DateTime fecha_creacion;
        private string correo;
        private string direccion;
        private string telefono;

        private byte[] foto;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string LoginName { get => loginName; set => loginName = value; }
        public string Contrasena_hash { get => contrasena_hash; set => contrasena_hash = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public byte[] Foto { get => foto; set => foto = value; }

        public void GuardarDatos(int id_usuario, string nombre_usuario, string loginName, string contrasena_hash, string rol, string estado, DateTime fecha_creacion, string correo, string direccion, string telefono, byte[] foto)
        {
            this.id_usuario = id_usuario;
            this.nombre_usuario= nombre_usuario;
            this.loginName = loginName;
            this.contrasena_hash = contrasena_hash;
            this.rol = rol;
            this.estado = estado;
            this.fecha_creacion = fecha_creacion;
            this.correo = correo;
            this.direccion = direccion;
            this.telefono = telefono;
            this.foto = foto;
        }
        public void GuardarDatos( string nombre_usuario, string loginName, string contrasena_hash, string rol, string estado, DateTime fecha_creacion, string correo, string direccion, string telefono, byte[] foto)
        {   
            this.nombre_usuario = nombre_usuario;
            this.loginName = loginName;
            this.contrasena_hash = contrasena_hash;
            this.rol = rol;
            this.estado = estado;
            this.fecha_creacion = fecha_creacion;
            this.correo = correo;
            this.direccion = direccion;
            this.telefono = telefono;
            this.foto = foto;
        }


    }
}
