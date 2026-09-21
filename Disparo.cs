public class Disparo : Sprite {
    private bool activo;
    private int velocidad;

    public Disparo() {
        this.activo = false;
    }

    protected override string GetImagen() {
        return "|";
    }

    public void Activo(int x, int y, int velocidad) {
        this.MoverA(x, y);
        this.velocidad = velocidad;
        this.activo = true;

        Dibujar();
    }

    public bool EstaActivo() {
        return activo;
    }

    public void Mover() {
        if (!activo) {
            return;
        }

        Borrar();

        int nuevaY = y + velocidad;

        if ((nuevaY <= 0) || (nuevaY >= 25)) { 
            activo = false;
        }
        else {
            y = nuevaY;

            Dibujar();
        }
    }

    public new void Dibujar() {
        if (activo) {
            base.Dibujar();
        }
    }

    public void BorrarDisparo() {
        if (activo) {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }

    public void Desaparecer() {
        activo = false;
        Borrar();
    }
}