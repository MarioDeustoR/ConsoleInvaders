public class Torre : Sprite {
    private int vida;
    private Torre[] torres;

    public Torre(int x, int y) {
        this.x = x;
        this.y = y;
        this.vida = 4;
        this.Color = ConsoleColor.Gray;
    }

    public Torre() { 
        torres = new Torre[4];

        int y = 18;

        torres[0] = new Torre(10, y);
        torres[1] = new Torre(30, y);
        torres[2] = new Torre(50, y);
        torres[3] = new Torre(70, y);
    }

    protected override string GetImagen() {
        if (vida >= 4) {
            return "████████████";
        }
        if (vida == 3) {
            return "▒▒▒▒▒▒▒▒▒▒▒▒";
        }
        if (vida == 2) {
            return "------------";
        }
        if (vida == 1) {
            return "............";
        }
        return "     ";
    }

    public void RecibirDanyo() {
        if (vida > 0) {
            vida--;

            if (vida == 0) {
                Borrar();
            }
            else {
                Dibujar();
            }
        }
    }

    public bool EstaIntacta() {
        return vida > 0;
    }

    public void DibujarTorres() {
        for (int i = 0; i < torres.Length; i++) {
            torres[i].Dibujar();
        }
    }

    public void ComprobarImpacto(Disparo disparo) {
        if (!disparo.EstaActivo()) {
            return;
        }

        for (int i = 0; i < torres.Length; i++) {
            if ((torres[i].EstaIntacta()) && (torres[i].ColisionaCon(disparo))) {
                disparo.Desaparecer();
                torres[i].RecibirDanyo();

                break;
            }
        }
    }
}