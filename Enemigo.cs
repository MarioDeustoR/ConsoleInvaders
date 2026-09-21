public class Enemigo : Sprite {
    private bool vivo = true;

    public Enemigo(int X, int Y) {
        this.x = X;
        this.y = Y;
        this.vivo = true;
    }

    public bool EstaVivo() {
        return vivo;
    }

    public void Morir() {
        this.vivo = false;
        this.Borrar();
    }

    public void DibujarVivo() {
        if (vivo) {
            base.Dibujar();
        }
    }

    protected override string GetImagen() {
        return "][";
    }
}
