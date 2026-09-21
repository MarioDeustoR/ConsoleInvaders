public struct Record {
    public string nombre;
    public int puntos;
}

public class Bienvenida {
    private bool salir;
    private Record[] records = new Record[5];

    public void Lanzar() {
        Console.Clear();
        Console.WriteLine("Bienvenido a Space Invaders.");
        Console.WriteLine("---|Mejores Puntuciones:|---");

        for (int i = 0; i < records.Length; i++) {
            Console.WriteLine("{0}. {1} - {2} puntos", i + 1, records[i].nombre, records[i].puntos);
        }

        Console.WriteLine("Pulse [Intro] para jugar o [ESC] para salir.");

        bool teclaValida = false;

        do {
            ConsoleKeyInfo tecla = Console.ReadKey(true);

            if (tecla.Key == ConsoleKey.Escape) {
                salir = true;
                teclaValida = true;
            }
            else if (tecla.Key == ConsoleKey.Enter) {
                salir = false;
                teclaValida = true;
            }
        } while (!teclaValida);
    }

    public bool GetSalir() {
        return salir;
    }

    public void Record(int puntos) { 
        for (int i = 0; i < records.Length; i++) {
            if (puntos > records[i].puntos) {
                Console.Clear();
                Console.WriteLine("Esta partido está en la posición {0} de tus records", i + 1);

                Console.Write("Introduce tu nombre: ");
                string nombre = Console.ReadLine();

                for (int j = records.Length - 1; j > i; j--) {
                    records[j] = records[j - 1];
                }

                records[i].nombre = nombre;
                records[i].puntos = puntos;

                break;
            }
        }
    }
}