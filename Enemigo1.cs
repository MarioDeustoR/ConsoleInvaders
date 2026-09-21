public class Enemigo1 : Enemigo {
    public Enemigo1(int x, int y)
       : base(x, y) {
        this.Color = ConsoleColor.Cyan;
    }

    protected override string GetImagen() {
        return "][";
    }
}   
