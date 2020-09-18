using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudPer.Models
{
    public class account
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNac { get; set; }
        public string Dni { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        //public string Genero { get; set; }
    }
}
