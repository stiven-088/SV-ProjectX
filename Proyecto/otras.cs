using System.Security.AccessControl;

public class Bar
{
    // creamos una lista que almacenara objetos de tipo persona
    List<Persona> personas = new List<Persona>();
    public void entrar(Persona stiven)
    {
        personas.Add(stiven);
        stiven.Accion();
        

    }
    
}

// creamos 3 clases hijas de la clase persona y cada una con su constructor
public class Cliente : Persona
{
    public Cliente(string Nombre) : base(Nombre)
    {
    }
    
    public override void Accion()
    {
        Console.WriteLine("toma tragos y se gasta todo el dinero");
    }
}
public class Mesero : Persona
{
    public Mesero(string Nombre) : base(Nombre)
    {
    }
    public override void Accion()
    {
        Console.WriteLine("Atiende mesas ");
    }
}
public class Cantinero : Persona
{
    public Cantinero(String Nombre) : base(Nombre)
    {

    }
}

public class Brogram
{
    static void Main(String[] args)
    {
        Bar obar = new Bar();

        Persona omesero = new Mesero("pocholo");
        Persona ocliente = new Cliente("james");
        obar.entrar(omesero);
        obar.entrar(ocliente);


    }


}
