public class Jugador : Persona
{
    public string Consola { get; set; }
    public int Rank { get; set; }

    public Jugador()
    {
        System.Console.WriteLine("Constructor por defecto de Jugador inicializado");
    }

    public Jugador(string nombre, int anioNacimiento, string ciudad, string correo, string consola, int rank)
        : base(nombre, anioNacimiento, ciudad, correo)
    {
        Consola = consola;
        Rank = rank;
    }

    public override string ToString()
    {
        return base.ToString() + $", Consola: {Consola}, Rank: {Rank}";
    }
}
