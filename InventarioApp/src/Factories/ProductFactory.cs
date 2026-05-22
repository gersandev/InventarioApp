namespace InventarioApp.Factories;
using InventarioApp.Models;

public static class ProductFactory
{
    private static int _nextId = 1;

    public static Producto Crear(string nombre, decimal precio, int cantidad, CategoriaProducto categoria = CategoriaProducto.Otros)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre del producto no puede estar vacío.", nameof(nombre));
        if (precio < 0)
            throw new ArgumentException("El precio del producto no puede ser negativo.", nameof(precio));
        if (cantidad < 0)
            throw new ArgumentException("La cantidad del producto no puede ser negativa.", nameof(cantidad));

        var producto = new Producto
        {
            Id = _nextId++,
            Nombre = nombre,
            Precio = precio,
            Cantidad = cantidad,
            Categoria = categoria
        };
        return producto;
    }
    public static Producto CrearConStock(string nombre, decimal precio, int cantidad)
    {
        if (cantidad <= 0)
            throw new ArgumentException("La cantidad del producto debe ser mayor que cero para crear un producto con stock.", nameof(cantidad));
        return Crear(nombre, precio, cantidad);
    }
}