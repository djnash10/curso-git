using Dapper.Contrib.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("Person")]   //Luego, es necesario que la entidad "Users" tenga los atributos correspondientes para indicar a Dapper.Contrib cómo se mapea la tabla de la base de datos. Para esto, se pueden utilizar los siguientes atributos:   [Table("NombreTabla")] : para indicar el nombre de la tabla que se mapea con la entidad.   Key] : para indicar la propiedad que corresponde a la clave primaria de la tabla.   [ExplicitKey] : para indicar una clave primaria que no sea autonumérica.
    public class Users
    {
        [Key]  // para indicar la propiedad que corresponde a la clave primaria de la tabla.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Identification { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        





    }
}
