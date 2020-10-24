using System;
using System.Collections.Generic;
using System.Text;

namespace QBONETCoreM1
{
    public class Principal
    {
        static void Main(string[] arg)
        {
            string nombreCurso = "Aplicaciones Web con .NET Core & C#";
            int edad = 23;
            double num1 = 10, num2=20;

            List<Persona> listado = new List<Persona>();
            Persona per = new Persona();
            per.personaDNI = "43567255";
            per.personaNombre = "Paolo Guerrero";
            per.personaTelefono = 99288209;

            Persona per2 = new Persona("44090999", "Jefferson Farfan", 889988227);

            listado.Add(per);
            listado.Add(per2);
            listado.Add(new Persona("88272222", "Gianluca Lapadula", 929299233));

            foreach (Persona item in listado)
            {
                Console.WriteLine("DNI: " + item.personaDNI);
                Console.WriteLine("Nombre Completo: " + item.personaNombre);
                Console.WriteLine("Telefono: " + item.personaTelefono);
                Console.WriteLine("*************************************");
            }


            //Console.WriteLine("Hello World! " + nombreCurso);
            Console.ReadKey();

        }
    }
}
