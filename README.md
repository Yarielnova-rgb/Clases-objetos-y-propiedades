Control de inventario de TecnoPunto

Datos del autor 

Nombre: Yariel Israel Nova Moreta

Matrícula: 2025

Asignatura: Programación Básica

Profesor: Gamalier Reyes del Carmen

Descripción del programa

Aplicación de consola en C# que registra productos de la tienda TecnoPunto y muestra su información de forma confiable. Utiliza la clase Producto, cuyas propiedades validan los datos para evitar precios negativos, cantidades inválidas y productos sin nombre. Cada producto calcula por sí mismo el valor total que tiene en existencia.

Datos de entrada

Por cada producto (se registran 3), el usuario ingresa por teclado:

Código (texto)
Nombre (texto)
Precio (número decimal)
Cantidad (número entero)
Datos que procesa
Nombre: no puede estar vacío.
Precio: debe ser mayor que 0.
Cantidad: no puede ser negativa (0 es válido).
ValorTotal: propiedad de solo lectura que calcula Precio × Cantidad.
Si un dato es inválido, se captura la excepción, se muestra un mensaje claro y se vuelven a pedir los datos del producto, sin cerrar el programa.
Datos de salida

Para cada producto se muestra: código, nombre, precio, cantidad y valor total en existencia.

Estructura del repositorio
apellido-clases-objetos/
├── Producto.cs
├── Program.cs
└── README.md
Capturas de ejecución
1. Datos válidos

<img width="713" height="611" alt="image" src="https://github.com/user-attachments/assets/76c193b8-3119-40ad-bf38-0bfc3583ba0e" />


2. Precio negativo

<img width="974" height="500" alt="image" src="https://github.com/user-attachments/assets/fcad792b-5cf7-46ca-bcc8-88419964aa43" />


3. Nombre vacío

<img width="831" height="215" alt="image" src="https://github.com/user-attachments/assets/2132d44d-3d2b-4d0f-ad9a-00bd0da039ac" />


4. Cantidad cero

<img width="872" height="596" alt="image" src="https://github.com/user-attachments/assets/c0ed73e5-9ec2-4fd9-a7f9-b05d09378ef6" />
