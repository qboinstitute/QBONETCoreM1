using System;
using System.Collections.Generic;
using System.Text;

namespace QBONETCoreM1
{
    public class Persona
    {
        public string personaDNI { get; set; }
        public string personaNombre { get; set; }
        public int personaTelefono { get; set; }

        public Persona() { 
        
        }

        public Persona(string dni, string nombre, int telefono)
        {
            this.personaDNI = dni;
            this.personaNombre = nombre;
            this.personaTelefono = telefono;
        }


    }
}
