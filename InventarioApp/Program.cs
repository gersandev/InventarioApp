// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================

using System.Reflection;
using System.Runtime.Intrinsics.Arm;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"Versión: 1.0.0");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine($"Version:{version}");
Console.WriteLine();
Console.WriteLine("Estructura del proyecto:");
Console.WriteLine("   InventarioApp/");
Console.WriteLine("    |-- Program.cs");
Console.WriteLine("    |-- InventarioApp.csproj");
Console.WriteLine("    |-- gitignore");
Console.WriteLine("    |-- README.md");
Console.WriteLine("    |-- src/");
Console.WriteLine("        |-- Models/");
Console.WriteLine("Configuración .csproj");
Console.WriteLine("Carpeta scr/ creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Próximo paso: Checpoint");
