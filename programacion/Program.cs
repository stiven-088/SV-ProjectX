using System.Data.Common;
using System.Drawing;
using System.Net.WebSockets;


Console.ForegroundColor = ConsoleColor.DarkCyan;

Console.WriteLine("hola maquina");


;

// crea objetos
Autos auto = new Autos();
var autos2 = new Autos();


// atributos de la clase llenados
auto.fechaFabrica = DateTime.Now;
auto.id = 11181818;
auto.Modelo = new Modelos() {id=23455, Nombre="rx7" };
auto.estado = true;
autos2.fechaFabrica = DateTime.Now;
auto.Precio = 23.00000M;
auto.Nombre = "bugatti";
auto.videojuegos = new List<Videojuegos>();

auto.videojuegos.Add (new Videojuegos (){id=8 ,Nombre="fifa" });


Console.WriteLine(autos2.fechaFabrica);
Console.WriteLine(auto.Modelo.Nombre);

foreach (var elemento in auto.videojuegos)
{
    Console.WriteLine(elemento.Nombre);

}



public class Modelos
{
    public int id=0;
    public string? Nombre="";
}
public class Videojuegos
{
    public int id=0;
    public string? Nombre="";
}

public class Autos
{
    public int id;
    public string? Nombre;
    public bool estado;
    public DateTime fechaFabrica;
    public decimal Precio;
    public Modelos? Modelo;
    public List<Videojuegos> videojuegos= new List<Videojuegos>();


}

// herencia
public class Deportivos: Autos 
{
    public string? matricula="";
}

