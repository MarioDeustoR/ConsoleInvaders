public class BloqueDeEnemigos {
    private Enemigo[] enemigos;
    private bool moviendoDerecha;
    private static Random random = new Random();

    public BloqueDeEnemigos() {
        enemigos = new Enemigo[30];
        moviendoDerecha = true;

        for (int i = 0; i < enemigos.Length; i++) {
        
            int fila = i / 10;
            int columna = i % 10;

            int x = 10 + (columna * 6);
            int y = 5 + (fila * 3);     

            if (fila == 0) {
                enemigos[i] = new Enemigo3(x, y);
            }
            else if (fila == 1) {
                enemigos[i] = new Enemigo2(x, y);
            }
            else {
                enemigos[i] = new Enemigo1(x, y);
            }
        }
    }

    public int Colision(Disparo disparo) {
        if (!disparo.EstaActivo()) {
            return 0;
        }

        for (int i = 0; i < enemigos.Length; i++) {

            if ((enemigos[i].EstaVivo()) && (enemigos[i].ColisionaCon(disparo))) {

                enemigos[i].Borrar();
                enemigos[i].Morir();

                disparo.Desaparecer();

                return 10;
            }
        }

        return 0;
    }

    public void Dibujar() {
        for (int i = 0; i < enemigos.Length; i++) {
            if (enemigos[i].EstaVivo()) { 
                enemigos[i].Dibujar();
            }
        }
    }

    public void Mover() {
        if (moviendoDerecha) {
            for (int i = 0; i < enemigos.Length; i++) {
                if (enemigos[i].EstaVivo() && enemigos[i].GetX() >= 75) {
                    moviendoDerecha = false;
                    break;
                }
            }
        }
        else {
            for (int i = 0; i < enemigos.Length; i++) {
                if (enemigos[i].EstaVivo() && enemigos[i].GetX() <= 2) {
                    moviendoDerecha = true;
                    break;
                }
            }
        }

        int desplazamiento;

        if (moviendoDerecha) {
            desplazamiento = 1;
        }
        else {
            desplazamiento = -1;
        }

        for (int i = 0; i < enemigos.Length; i++) {
            if (enemigos[i].EstaVivo()) {
                enemigos[i].Borrar();
                enemigos[i].MoverA(enemigos[i].GetX() + desplazamiento, enemigos[i].GetY());
            }
        }

        Dibujar();
    }

    public void IntentaDisparar(Disparo enemigo) {
        if (enemigo.EstaActivo()) {
            return;
        }

        if (random.Next(0, 100) < 5) {
            int i = random.Next(0, enemigos.Length);

            if (enemigos[i].EstaVivo()) {
                enemigo.Activo(enemigos[i].GetX(), enemigos[i].GetY() + 1, 1);
            }
        }
    }
}
