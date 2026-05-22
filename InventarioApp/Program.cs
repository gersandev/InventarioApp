using InventarioApp.Models;
using InventarioApp.Repositories;
using InventarioApp.Factories;
using InventarioApp.Infraestructure;

Console.WriteLine("====== InventarioApp ======");
var fileManager = new FileManager();
string contenido = "Inventario actualizado";
fileManager.Escribir("inventario.txt", contenido);

string leerContenido = fileManager.Leer("inventario.txt");
Console.WriteLine($"Contenido del archivo: {leerContenido}");

var repositorio = new InMemoryProductoRepository();

var laptop = ProductoFactory.Crear("Laptop", 1500.00m, 10, CategoriaProducto.Electronica);
var mouse = ProductoFactory.Crear("Mouse", 25.00m, 50, CategoriaProducto.Electronica);
var teclado = ProductoFactory.Crear("Teclado", 45.00m, 30, CategoriaProducto.Electronica);
var silla = ProductoFactory.Crear("Silla de Oficina", 120.00m, 20, CategoriaProducto.Muebles);
var escritorio = ProductoFactory.Crear("Escritorio", 250.00m, 15, CategoriaProducto.Muebles);

repositorio.Agregar(laptop);
repositorio.Agregar(mouse);
repositorio.Agregar(teclado);
repositorio.Agregar(silla);
repositorio.Agregar(escritorio);

Console.WriteLine($"Productos agregados: {repositorio.Cantidad}\n");

var electronicos = repositorio.BuscarPorCategoria(CategoriaProducto.Electronica);
Console.WriteLine("Productos en categoría Electrónica:");

foreach (var producto in electronicos)
{
    Console.WriteLine($"- {producto.Nombre} Precio: {producto.Precio:C}");
}

var conMouse = repositorio.BuscarPorNombre("Mouse");

foreach (var producto in conMouse)
{
    Console.WriteLine($"Producto encontrado por nombre: {producto.Nombre} Precio: {producto.Precio:C}");
}

var nombres = repositorio.ObtenerNombres();

Console.WriteLine($"\nTodos los nombres: {string.Join(",", nombres)}");

var hayStockBajo = repositorio.HayStockBajo();
Console.WriteLine($"\n¿Hay productos con stock bajo? {(hayStockBajo ? "Sí" : "No")}");