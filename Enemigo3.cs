public class Enemigo3 : Enemigo {
    public Enemigo3(int x, int y)
       : base(x, y) {
        this.Color = ConsoleColor.Yellow;
    }

    protected override string GetImagen() {
        return "XX";
    }
}   
