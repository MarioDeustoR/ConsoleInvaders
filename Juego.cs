public class Juego {
    public void Lanzar() {
        Bienvenida bienvenida = new Bienvenida();

        do {
            bienvenida.Lanzar();

            if (!bienvenida.GetSalir()) {
                Partida partida = new Partida();
                partida.Lanzar();
            }
        } while (!bienvenida.GetSalir());

        Console.Clear();
        Console.WriteLine("¡Gracias por jugar a Space Invaders!");
    }
}
