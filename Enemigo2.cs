public class Enemigo2 : Enemigo {
    public Enemigo2(int x, int y)
       : base(x, y) {
        this.Color = ConsoleColor.Red;
    }

    protected override string GetImagen() {
        return "[]";
    }
}   
