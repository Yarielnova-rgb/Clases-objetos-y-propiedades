using System;

namespace TecnoPunto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inventario TecnoPunto ===");

            // Un objeto por variable, sin arreglos ni listas
            Producto producto1 = RegistrarProducto(1);
            Producto producto2 = RegistrarProducto(2);
            Producto producto3 = RegistrarProducto(3);

            Console.WriteLine();
            Console.WriteLine("=== Productos registrados ===");
            producto1.MostrarInfo();
            producto2.MostrarInfo();
            producto3.MostrarInfo();

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }

        // Pide los datos de un producto y lo crea.
        // Si algo sale mal, avisa y lo vuelve a pedir en lugar de cerrar el programa
        static Producto RegistrarProducto(int numero)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine($"--- Producto {numero} ---");

                    Console.Write("Código: ");
                    string codigo = Console.ReadLine();

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Precio: ");
                    decimal precio = LeerDecimal(Console.ReadLine());

                    Console.Write("Cantidad: ");
                    int cantidad = LeerEntero(Console.ReadLine());

                    // Si algún dato no cumple las reglas, aquí salta la excepción
                    return new Producto(codigo, nombre, precio, cantidad);
                }
                catch (ArgumentException ex)
                {
                    // Algún dato rompió una validación de Producto
                    Console.WriteLine($"Dato inválido: {ex.Message} Intente de nuevo.");
                }
                catch (FormatException ex)
                {
                    // El usuario escribió letras donde iba un número
                    Console.WriteLine($"Formato incorrecto: {ex.Message} Intente de nuevo.");
                }
            }
        }

        // Pasa el texto a decimal; si no es un número, avisa con una excepción
        static decimal LeerDecimal(string texto)
        {
            if (!decimal.TryParse(texto, out decimal resultado))
            {
                throw new FormatException("El precio debe ser un número.");
            }
            return resultado;
        }

        // Igual que el anterior, pero para números enteros
        static int LeerEntero(string texto)
        {
            if (!int.TryParse(texto, out int resultado))
            {
                throw new FormatException("La cantidad debe ser un número entero.");
            }
            return resultado;
        }
    }
}
