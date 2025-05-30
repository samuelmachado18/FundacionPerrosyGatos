using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fundacion_Animales
{

    public class Solicitud
    {
        private int id_solicitud;
        private int id_usuario;
        private int id_animal;
        private DateTime fecha_solicitud;
        private string alégias_familiares;
        private string motivo_adopcion;
        private string habitat_Animal;
        private string tiene_otros_animales;
        private string tiempo_libre;
        private string estado_solicitud;
        private string observaciones_admin;
        private DateTime fecha_revision ;

        public int Id_solicitud { get => id_solicitud; set => id_solicitud = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_animal { get => id_animal; set => id_animal = value; }
        public DateTime Fecha_solicitud { get => fecha_solicitud; set => fecha_solicitud = value; }
        public string Alégias_familiares { get => alégias_familiares; set => alégias_familiares = value; }
        public string Motivo_adopcion { get => motivo_adopcion; set => motivo_adopcion = value; }
        public string Habitat_Animal { get => habitat_Animal; set => habitat_Animal = value; }
        public string Tiene_otros_animales { get => tiene_otros_animales; set => tiene_otros_animales = value; }
        public string Tiempo_libre { get => tiempo_libre; set => tiempo_libre = value; }
        public string Estado_solicitud { get => estado_solicitud; set => estado_solicitud = value; }
        public string Observaciones_admin { get => observaciones_admin; set => observaciones_admin = value; }
        public DateTime Fecha_revision { get => fecha_revision; set => fecha_revision = value; }

        public Solicitud(int Id_usuario, int Id_animal, DateTime fecha_solicitud, string Alégias_familiares, string Motivo_adopcion, string Habitat_Animal, string Tiene_otros_animales, string tiempo_libre, string estado_solicitud, string Observaciones_admin, DateTime Fecha_revision)
        {

            this.id_usuario = Id_usuario;
            this.id_animal = Id_animal;
            this.fecha_solicitud = fecha_solicitud;
            this.alégias_familiares = Alégias_familiares;
            this.motivo_adopcion = Motivo_adopcion;
            this.habitat_Animal = Habitat_Animal;
            this.tiene_otros_animales = Tiene_otros_animales;
            this.tiempo_libre = tiempo_libre;
            this.estado_solicitud = estado_solicitud;
            this.observaciones_admin = Observaciones_admin;
            this.fecha_revision = Fecha_revision;
        }
        public Solicitud(int id_solicitud,int Id_usuario, int Id_animal, DateTime fecha_solicitud, string Alégias_familiares, string Motivo_adopcion, string Habitat_Animal, string Tiene_otros_animales, string tiempo_libre, string estado_solicitud, string Observaciones_admin, DateTime Fecha_revision)
        {
            this.id_solicitud =id_solicitud;
            this.id_usuario = Id_usuario;
            this.id_animal = Id_animal;
            this.fecha_solicitud = fecha_solicitud;
            this.alégias_familiares = Alégias_familiares;
            this.motivo_adopcion = Motivo_adopcion;
            this.habitat_Animal = Habitat_Animal;
            this.tiene_otros_animales = Tiene_otros_animales;
            this.tiempo_libre = tiempo_libre;
            this.estado_solicitud = estado_solicitud;
            this.observaciones_admin = Observaciones_admin;
            this.fecha_revision = Fecha_revision;
        }


    }
}
