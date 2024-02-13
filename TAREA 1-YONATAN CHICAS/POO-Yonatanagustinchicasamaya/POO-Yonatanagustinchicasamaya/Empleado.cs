using System;
using System.Collections.Generic;

namespace POO_Yonatanagustinchicasamaya
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Titulo { get; set; }

        public Empleado(string nombre, string puesto, string titulo)
        {
            Nombre = nombre;
            Puesto = puesto;
            Titulo = titulo;
        }

        public static void AgregarEmpleado(List<Empleado> empleados)
        {
            Console.WriteLine("Ingrese el nombre del empleado:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el puesto del empleado:");
            string puesto = Console.ReadLine();

            Console.WriteLine("Ingrese el título del empleado:");
            string titulo = Console.ReadLine();

            Empleado nuevoEmpleado = new Empleado(nombre, puesto, titulo);
            empleados.Add(nuevoEmpleado);

            Console.WriteLine("Empleado agregado correctamente.");
        }

        public static void MostrarEmpleados(List<Empleado> empleados)
        {
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Nombre: {empleado.Nombre}, " +
                                  $"Puesto: {empleado.Puesto}, " +
                                  $"Título: {empleado.Titulo}");
            }
        }

        public static void EditarEmpleado(List<Empleado> empleados)
        {
            Console.WriteLine("Ingrese el nombre del empleado que desea editar:");
            string nombreBuscado = Console.ReadLine();

            Empleado empleadoEncontrado = empleados.Find(e => e.Nombre.Equals(nombreBuscado));

            if (empleadoEncontrado != null)
            {
                Console.WriteLine("Ingrese el nuevo nombre del empleado:");
                empleadoEncontrado.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el nuevo puesto del empleado:");
                empleadoEncontrado.Puesto = Console.ReadLine();

                Console.WriteLine("Ingrese el nuevo título del empleado:");
                empleadoEncontrado.Titulo = Console.ReadLine();

                Console.WriteLine("Empleado editado correctamente.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        public static void EliminarEmpleado(List<Empleado> empleados)
        {
            Console.WriteLine("Ingrese el nombre del empleado que desea eliminar:");
            string nombreBuscado = Console.ReadLine();

            Empleado empleadoAEliminar = empleados.Find(e => e.Nombre.Equals(nombreBuscado));

            if (empleadoAEliminar != null)
            {
                empleados.Remove(empleadoAEliminar);
                Console.WriteLine("Empleado eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        public class Calculardescuentos
        {
            double descuentoafp, descuentoiss, descuentorenta, todoslosdescuentos;

            public static void CalcularAFP(List<Empleado> lista)
            {
                string nombreempleado;
                double salariobase;
                Console.WriteLine("Ingrese el nombre del empleado");
                nombreempleado = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese el salario base");
                salariobase = Convert.ToDouble(Console.ReadLine());

                double descuentoafp = salariobase * 0.0725;
                double salarioConDescuentoAFP = salariobase - descuentoafp;

                Console.WriteLine($"Estimado {nombreempleado} su descuento de AFP es del 7.25% : {descuentoafp}");
                Console.WriteLine($"Su salario restando el Descuento AFP es de : {salarioConDescuentoAFP}");
            }

            public static void CalcularISS(List<Empleado> lista)
            {
                string nombreempleado;
                double salariobase;
                Console.WriteLine("Ingrese el nombre del empleado");
                nombreempleado = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese el salario base");
                salariobase = Convert.ToDouble(Console.ReadLine());

                double descuentoiss = salariobase * 0.075;
                double salarioConDescuentoAFP = salariobase - descuentoiss;

                Console.WriteLine($"Estimado {nombreempleado} su descuento de ISS es del 7.5% haciendo un total de : {descuentoiss}");
                Console.WriteLine($"Su salario restando el Descuento ISS es de : {salarioConDescuentoAFP}");
            }

            public static void CalcularRENTA(List<Empleado> lista)
            {
                string nombreempleado;
                double salariobase;
                Console.WriteLine("Ingrese el nombre del empleado");
                nombreempleado = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese el salario base");
                salariobase = Convert.ToDouble(Console.ReadLine());

                double descuentorenta = salariobase * 0.075;
                double salarioConDescuentoAFP = salariobase - descuentorenta;

                Console.WriteLine($"Estimado {nombreempleado} su descuento de Renta es del 10% : {descuentorenta}");
                Console.WriteLine($"Su salario restanndo el  Descuento  del impuesto sobre  la Renta es de : {salarioConDescuentoAFP}");
            }
            public static void Todoslosdescuentos(List<Empleado> lista)
            {
                string nombreempleado;
                double salariobase;
                Console.WriteLine("Ingrese el nombre del empleado");
                nombreempleado = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese el salario base");
                salariobase = Convert.ToDouble(Console.ReadLine());

                double descuentoafp = salariobase * 0.075;
                double descuentoiss = salariobase * 0.075; 
                double descuentorenta = salariobase * 0.1; 

                double todoslosdescuentos = descuentoafp + descuentoiss + descuentorenta;

                double salarioConDescuentos = salariobase - todoslosdescuentos;

                Console.WriteLine($"Estimado {nombreempleado}, su descuento de AFP es: {descuentoafp}");
                Console.WriteLine($"Su descuento de ISS es: {descuentoiss}");
                Console.WriteLine($"Su descuento de Renta es: {descuentorenta}");
                Console.WriteLine($"Su salario con todos los descuentos es de: {salarioConDescuentos}");
            }
        }
    }
}