using System;
using System.Collections;

namespace Tarea3
{
    class Persona
    {
        public string nombre;
        public string telefono;
        public string email;
        public string domicilio;

        public Persona() {
            nombre = "";
            telefono = "";
            email = "";
            domicilio = "";
        }

        static void Main(string[] args)
        {
            ArrayList Person = new ArrayList();
            Persona persona = new Persona();
            Console.WriteLine("Dame tu Nombre");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("Dame tu telefono");
            persona.telefono = Console.ReadLine();
            Console.WriteLine("Dame tu correo");
            persona.email = Console.ReadLine();
            Console.WriteLine("Dame tu domicilio");
            persona.domicilio = Console.ReadLine();
            Console.Clear();
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Datos guardados");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Nombre: " + persona.nombre);
            Console.WriteLine("Telefono:" + persona.telefono);
            Console.WriteLine("Correo: " + persona.email);
            Console.WriteLine("Domicilio: " + persona.domicilio);
            Console.ReadKey(true);
        }
    }
}
