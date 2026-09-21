public class Nave : Sprite {

    public Nave()
        : this(40, 20) {
        this.Color = ConsoleColor.White;
    }

    public Nave(int X, int Y) {
        this.x = X;
        this.y = Y;
    }

    protected override string GetImagen() {
        return @"/\";
    }

    public void MoverDerecha() {
        this.MoverA(this.x + 1, this.y);

        if (this.x > 80) {
            this.x = 80;
        }
    }

    public void MoverIzquierda() {
        this.MoverA(this.x - 1, this.y);

        if (this.x < 0) {
            this.x = 0;
        }
    }
}
