// clase padre
public class Persona
{
    public string Nombre { get; set; }
    public int AnioNacimiento { get; set; }
    public string Ciudad { get; set; }
    public string Correo { get; set; }

    // constructor por defecto
    public Persona()
    {
        System.Console.WriteLine("Constructor por defecto inicializado");
    }

    //contructor
    public Persona(string nombre, int anioNacimiento, string ciudad, string correo)
    {
        Nombre = nombre;
        AnioNacimiento = anioNacimiento;
        Ciudad = ciudad;
        Correo = correo;
    }


    //  método  privado para calcular edad
    private int CalcularEdad()
    {
        return DateTime.Now.Year - AnioNacimiento;
    }
    //  método ToString
    public override string ToString()
    {
        return $"Nombre: {Nombre}, Año de Nacimiento: {AnioNacimiento}, Ciudad: {Ciudad}, Correo: {Correo}";
    }
}

