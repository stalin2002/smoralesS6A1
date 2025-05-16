using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smoralesS6A1.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string clave { get; set; }
        public DateTime fecha { get; set; } 
        public string estado { get; set; }  
    }
}
