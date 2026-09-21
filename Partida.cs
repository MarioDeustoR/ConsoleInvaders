public class Partida {
    public void Lanzar() {
        Console.Clear();

        int puntos = 0;

        Console.SetCursorPosition(0, 0);

        Console.WriteLine("Pulse [ESC] para volver al menú...");
        Console.WriteLine("------------EN PARTIDA------------");

        Marcador marcador = new Marcador();
        marcador.Dibujar();

        BloqueDeEnemigos enemigo = new BloqueDeEnemigos();

        Nave nave = new Nave();
        nave.Dibujar();

        Ovni ovni = new Ovni();

        Disparo disparoNave = new Disparo();
        Disparo disparoEnemigo = new Disparo();

        Torre torre = new Torre();
        torre.DibujarTorres();

        bool salir = false;

        do {
            if (Console.KeyAvailable) { 
                ConsoleKeyInfo tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.RightArrow) {
                    nave.Borrar();
                    nave.MoverDerecha();
                    nave.Dibujar();

                }
                else if (tecla.Key == ConsoleKey.LeftArrow) {
                    nave.Borrar();
                    nave.MoverIzquierda();
                    nave.Dibujar();
                }
                else if (tecla.Key == ConsoleKey.Escape) {
                    salir = true;
                }
                else if (tecla.Key == ConsoleKey.Spacebar) {
                    if (!disparoNave.EstaActivo()) {
                        disparoNave.Activo(nave.GetX() + 2, nave.GetY() - 1, -1);
                    }
                }
            }

            enemigo.Mover();
            disparoNave.Mover();
            disparoEnemigo.Mover();
            ovni.MoverOvni();
            enemigo.IntentaDisparar(disparoEnemigo);
            torre.ComprobarImpacto(disparoNave);
            torre.ComprobarImpacto(disparoEnemigo);


            if ((ovni.EsVisible()) && (ovni.ColisionaCon(disparoNave))) {
                ovni.Impactado();
                disparoNave.Desaparecer();

                marcador.SumarPuntos(50);

                Console.SetCursorPosition(0, 0);

                Console.WriteLine("Puntos:  {0}", puntos);
            }

            int puntosObtenidos = enemigo.Colision(disparoNave);

            if (puntosObtenidos > 0) {
                marcador.SumarPuntos(puntosObtenidos);

                Console.SetCursorPosition(0, 0);

                Console.WriteLine("Puntos:  {0}", puntos);
            }

            if (disparoEnemigo.EstaActivo() && disparoEnemigo.ColisionaCon(nave)) {
                marcador.PerderVida();
                disparoEnemigo.Desaparecer();
            }

            if (!marcador.VidasQuedan()) {
                salir = true;
            }

            Thread.Sleep(100);
        } while (!salir);

        Console.Clear();
        Console.SetCursorPosition(10, 10);
        Console.WriteLine("Fin de la partida. Pulse cualquier tecla para volver al menú...");
        Console.ReadKey();
    }
}