using System;
using dotNetSecuencia.model;
namespace dotNetSecuencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido !!");
            Juego juego = new Juego();
            String respuestaStr;
            do {
                Console.WriteLine("La secuencia es : ");
                Console.WriteLine(" " + juego.Nro1 + " " + juego.Nro2 + "  __  " + juego.Nro4 );
                respuestaStr = Console.ReadLine();
                int respuesta = Convert.ToInt32(respuestaStr);
                if (juego.isOk(respuesta)) {
                    Console.WriteLine("Ganaste!! Tu puntaje es " + juego.Puntaje);
                } else {
                    Console.WriteLine("Perdiste!! Tu puntaje es " + juego.Puntaje);
                }
                Console.WriteLine("Quieres seguir Jugando [n/s] ? ");
                respuestaStr = Console.ReadLine();
            } while (respuestaStr != "n");
        }
    }
}
