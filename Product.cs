using System;

namespace TecnoPunto
{
    // Esta clase guarda la información de un producto de la tienda
    public class Producto
    {
        // Aquí se guarda el valor real; desde afuera solo se accede por las propiedades
        private string _nombre;
        private decimal _precio;
        private int _cantidad;

        // El código no tiene reglas, cualquier texto sirve
        public string Codigo { get; set; }

        // Si el nombre viene vacío o solo con espacios, no lo dejamos pasar
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
                _nombre = value.Trim();
            }
        }

        // Un producto no puede costar 0 ni menos
        public decimal Precio
        {
            get { return _precio; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El precio debe ser mayor que 0.");
                }
                _precio = value;
            }
        }

        // Puede haber 0 en existencia, pero nunca una cantidad negativa
        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                }
                _cantidad = value;
            }
        }

        // Solo se puede leer: se calcula solo con el precio y la cantidad actuales
        public decimal ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        // Uso las propiedades (no los campos) para que las validaciones también se apliquen aquí
        public Producto(string codigo, string nombre, decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        // Muestra los datos del producto en la consola
        public void MostrarInfo()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Código:       {Codigo}");
            Console.WriteLine($"Nombre:       {Nombre}");
            Console.WriteLine($"Precio:       RD$ {Precio:N2}");
            Console.WriteLine($"Cantidad:     {Cantidad}");
            Console.WriteLine($"Valor total:  RD$ {ValorTotal:N2}");
            Console.WriteLine("----------------------------------");
        }
    }
}
