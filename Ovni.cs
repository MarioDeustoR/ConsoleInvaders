public class Ovni : Enemigo {
    private static Random generador = new Random();
    private bool activo;

    public Ovni() : base(0, 3) {
        this.activo = false;
        this.Color = ConsoleColor.Green;
    }

    protected override string GetImagen() {
        return "<(O)>";
    }

    public void MoverOvni() {
        if (!this.EstaVivo()) return;

        if (activo) {
            Borrar();
            int nuevaX = GetX() + 1;

            if (nuevaX >= 100) {
                activo = false;
                Borrar();
                MoverA(0, GetY());
            }
            else {
                MoverA(nuevaX, GetY());
                Dibujar();
            }
        }
        else {
            int probabilidad = generador.Next(0, 100);
            if (probabilidad < 8) {
                activo = true;
                MoverA(0, GetY());
            }
        }
    }

    public new void Dibujar() {
        if ((activo) && (EstaVivo())) {
            base.Dibujar();
        }
    }

    public bool EsVisible() {
        return activo && EstaVivo();
    }

    public void Impactado() {
        this.activo = false;
        this.Borrar();
        this.MoverA(0, GetY());
    }
}