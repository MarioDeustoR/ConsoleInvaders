public class Marcador {     
    private int puntos;
    private int vidas;

    public Marcador() {
        this.puntos = 0;
        this.vidas = 3;
    }
    public void SumarPuntos(int puntos) {
        this.puntos += puntos;
        Dibujar();
    }

    public int GetPuntos() {
        return this.puntos;
    }   

    public void PerderVida() {
        this.vidas--;
        Dibujar();
    }

    public bool VidasQuedan() {
        return this.vidas > 0;
    }   

    public void Dibujar() {
        Console.SetCursorPosition(0, 2);
        Console.WriteLine("Puntos: {0} Vidas: {1}", this.puntos, this.vidas);
    }
}
