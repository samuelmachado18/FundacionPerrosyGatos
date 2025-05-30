using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fundacion_Animales
{
    public class Animal
    {
        private int id_animal;
        private string nombre;
        private string especie;
        private string raza;
        private string sexo;
        private DateTime fecha_nacimiento;
        private DateTime fecha_ingreso;
        private string estado;
        private byte[] foto;
        public int Id_animal { get => id_animal; set => id_animal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raza { get => raza; set => raza = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public string Estado { get => estado; set => estado = value; }
        public byte[] Foto { get => foto; set => foto = value; }

        public Animal() { }

        public void GuardarDatos( int id_animal,string nombre, string especie, string raza, string sexo, DateTime fecha_nacimiento, DateTime fecha_ingreso, string estado, byte[] foto)
        {
            this.id_animal = id_animal;
            this.nombre = nombre;
            this.especie = especie;
            this.raza = raza;
            this.sexo = sexo;
            this.fecha_nacimiento = fecha_nacimiento;
            this.fecha_ingreso = fecha_ingreso;
            this.estado = estado;
            this.foto = foto;
        
        }
        public void GuardarDatos( string nombre, string especie, string raza, string sexo, DateTime fecha_nacimiento, DateTime fecha_ingreso, string estado, byte[] foto)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.raza = raza;
            this.sexo = sexo;
            this.fecha_nacimiento = fecha_nacimiento;
            this.fecha_ingreso = fecha_ingreso;
            this.estado = estado;
            this.foto = foto;

        }
    }
}
