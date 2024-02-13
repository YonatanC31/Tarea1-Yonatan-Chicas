using POO_Yonatanagustinchicasamaya;

// Nombre: Yonatan Agustin Chicas Amaya Codigo: U20211000

internal class Program
{
    private static void Main(string[] args)
    {
        int opcionElegida;
        string seguir;

        List<Empleado> empleados = new List<Empleado>();

        Console.WriteLine("BIENVENIDO AL PROGRAMA DE GESTION DE EMPLEADOS");
        Console.WriteLine("**********************************************");

        do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("**********************************************");
            Console.WriteLine("OPCIONES PARA EMPLEADOS");
            Console.WriteLine("1-Agregar nuevo empleado");
            Console.WriteLine("2-Mostrar lista de empleados");
            Console.WriteLine("3-Editar empleado");
            Console.WriteLine("4-Eliminar empleado");
            Console.WriteLine("5- Calcular el salario del empleado");
            Console.WriteLine("INGRESE EL NUMERO DE LA OPCION ELEGIDA");

            opcionElegida = Convert.ToInt32(Console.ReadLine());

            switch (opcionElegida)
            {
                case 1:
                    Empleado.AgregarEmpleado(empleados);
                    break;
                case 2:
                    Empleado.MostrarEmpleados(empleados);
                    break;
                case 3:
                    Empleado.EditarEmpleado(empleados);
                    break;
                case 4:
                    Empleado.EliminarEmpleado(empleados);
                    break;
                case 5:
                    Console.WriteLine("OPCIONES DE CALCULO DE SALARIO");
                    Console.WriteLine("1-Calcular descuento AFP");
                    Console.WriteLine("2-Calcular descuento de ISS");
                    Console.WriteLine("3-Calcular descuento de la RENTA");
                    Console.WriteLine("4-Calcular Salario incluyendo todos los descuentos");

                    int opcionDescuentos = Convert.ToInt32(Console.ReadLine());

                    switch (opcionDescuentos)
                    {
                        case 1:
                            Empleado.Calculardescuentos.CalcularAFP(empleados);
                            break;
                        case 2:
                            Empleado.Calculardescuentos.CalcularISS(empleados);
                            break;
                        case 3:
                            Empleado.Calculardescuentos.CalcularRENTA(empleados);
                            break;
                        case 4:
                            Empleado.Calculardescuentos.Todoslosdescuentos(empleados);
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("¿Desea continuar? (si/no)");
            seguir = Console.ReadLine();

        } while (seguir.ToLower() == "s" || seguir.ToLower() == "si");

        Console.ReadKey();
    }
}
