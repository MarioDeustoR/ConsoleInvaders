public class Sprite {
    protected int x;
    protected int y;
    public ConsoleColor Color = ConsoleColor.White;

    public Sprite() {
        x = 0;
        y = 0;
    }

    protected virtual string GetImagen() {
        return "";
    }

    public void MoverA(int x, int y) {
        this.Borrar();
        this.x = x;
        this.y = y;
    }

    public void Borrar() {
        Console.SetCursorPosition(x, y);
        Console.Write(new string(' ', GetImagen().Length));
    }

    public void Dibujar() {
        ConsoleColor colorOriginal = Console.ForegroundColor;
        Console.ForegroundColor = this.Color;

        Console.SetCursorPosition(x, y);
        Console.WriteLine(GetImagen());

        Console.ForegroundColor = colorOriginal;
    }

    public int GetX() {
        return x;
    }

    public int GetY() {
        return y;
    }

    public bool ColisionaCon(Sprite otro) {
        if (this.y != otro.GetY()) {
            return false;
        }

        int thisAncho = this.GetImagen().Length; 
        int thisX = this.x;
        int otraX = otro.GetX();

        if (otraX >= thisX && otraX < (thisX + thisAncho)) {
            return true; 
        }

        return false;
    }
}