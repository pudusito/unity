// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Persona persona = new Persona();
Console.WriteLine(persona);
Persona p = new Persona("Luis", 1986, "Chillan", "luis@gmail.com");
System.Console.WriteLine(p);
persona.Nombre = "Benjamin";
persona.AnioNacimiento = 1996;
persona.Ciudad = "Santiago";
persona.Correo = "bm@gmail.com";

Jugador jugador = new Jugador("Ana", 1998, "Valparaiso", "ana@gmail.com", "PS5", 1);
System.Console.WriteLine(jugador);
List<Jugador> jugadores = new List<Jugador>();
jugadores.Remove(jugador);
foreach (Jugador j in jugadores)
{
    System.Console.WriteLine(j);
}