// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================

using System.Reflection;

//Variables
int cantidadProductos = 0;
decimal valorTotalDelInventario = 0.00m;
bool sistemaActivo = true;

MostarBanner();
bool continuar = true;

while(continuar)
{
    Mostrarmenu();
    string comando = LeerEntrada("Inventario ");
    Console.WriteLine($"Comando ingresado: {comando}");

    continuar = false;
}
//Funciones
bool ProcesarComando(string comando)
{
    switch (comando.ToLower())
    {
        case "listar":
            ListarProductos();
            return true;
        case "agregar":
            AgregarProducto();
            return true;
        case "buscar":
            BuscarProducto();
            return true;
        case "salir":
            return false;
        default:
            Console.WriteLine($"Error: comando desconocido '{comando}'");
            return true;
    }
}
void ListarProductos()
{
    Console.WriteLine($"Total: {cantidadProductos} de productos en el inventario");
    Console.WriteLine($"Valor : ${valorTotalDelInventario:N2}");
}
void AgregarProducto()
{
    Console.WriteLine("Funcionalidad de agregar producto (en desarrollo)");
}
void BuscarProducto()
{
    Console.WriteLine("Funcionalidad de buscar producto (en desarrollo)");
}
string LeerEntrada(string prompt)
{
    string salida = "El propmpt ingresado es: " + prompt;
    return salida;
}
void MostarBanner()
{
    Console.WriteLine("==========================================");
    Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
    Console.WriteLine("==========================================");
    Console.WriteLine();
}
void Mostrarmenu()
{
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1.  listar  - Muestra el estado del inventario");
    Console.WriteLine("2.  agregar  - Agrega un nuevo producto al inventario");
    Console.WriteLine("3.  buscar   - Busca un producto en el inventario");
    Console.WriteLine("4.  salir    - Salir del programa");
    Console.WriteLine();
}