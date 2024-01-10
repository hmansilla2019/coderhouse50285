// See https://aka.ms/new-console-template for more information
using Clase5Objetos;

Console.WriteLine("Hello, World!");

// Crear una instancia de la clase producto (objeto)
Producto producto = new Producto();
Producto producto2 = new Producto(1, "Pepsi", 5000, 10000, "Gaseosa");

bool tieneprecio1 = producto.HayPreciodeVenta();
bool tieneprecio2 = producto2.HayPreciodeVenta();

producto2.Descripcion = "Manaos";
producto2.PrecioCompra = 2500;
producto2.PrecioVenta = 5000;
producto2.Codigo = 3;

Console.WriteLine("Ingrese Codigo");
producto2.Codigo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese Descripcion");
producto2.Descripcion =Console.ReadLine();
Console.WriteLine("Ingrese Codigo");
producto2.PrecioVenta = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese Codigo"); 
producto2.PrecioCompra = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Codigo:  " + producto2.Codigo);
Console.WriteLine("Descripcion:  " + producto2.Descripcion);
Console.WriteLine("Precio Compra:  " + producto2.PrecioCompra);
Console.WriteLine("Precio Venta:  " + producto2.PrecioVenta);
Console.WriteLine("Categoria:  " + producto2.Categoria);

Console.ReadKey();