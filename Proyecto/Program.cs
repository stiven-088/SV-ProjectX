

public class Persona
{
    public String? Nombre { get; set; }

    // este es un metodo constructor de la clase persona.
    public Persona(string Nombre)
    {
        this.Nombre = Nombre;

    }
    // metodo para una sobre escritura
    public virtual void Accion()
    {

    }
}