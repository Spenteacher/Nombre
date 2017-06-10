using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso2
{
    class Datos
    {

        String nombre;

        public void setNombre(String n)
        {
            nombre = n;

        }
        String Apellido1;


        public void setApellido(String a)
        {
          Apellido1 = a;

        }

        public String getApellido1()
        {
            return Apellido1;
        }


        public String getNombre()
        {
            return nombre;
        }

        public void setApellido2(String e)
        {
            Apellido2 = e; 
        }

        String Apellido2;

        public String getApellido2()
        {
            return Apellido2;
        }

        }
    }

