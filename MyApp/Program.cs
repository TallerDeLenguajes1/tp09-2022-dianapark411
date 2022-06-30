// See https://aka.ms/new-console-template for more information
using System.Text.Json;

List<Producto> listaProductos = new List<Producto>();

Console.Write("Ingrese la ruta: ");
string ruta = Console.ReadLine();

if(!File.Exists(ruta + @"/index.json")){
    File.Create(ruta + @"/index.json").Close();
}

ruta += @"/index.json";

Console.Write("Ingrese la cantidad de productos: ");
int cantidad = Int32.Parse(Console.ReadLine());

for(int i = 0; i < cantidad; i++){
    listaProductos.Add(new Producto());
}

string archivoJson = JsonSerializer.Serialize(listaProductos);
File.WriteAllText(ruta, archivoJson);

listaProductos = JsonSerializer.Deserialize<List<Producto>>(File.ReadAllText(ruta));

foreach(Producto prod in listaProductos){
    Console.WriteLine(prod + "\n");
}
