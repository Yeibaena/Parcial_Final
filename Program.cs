
internal class Program
{
    private static void Main(string[] args)
    {
        // Tamaño predeterminado de la matriz
        int rows = 5;
        int cols = 5;

        // Crear y llenar la matriz
        int[,] matriz = new int[rows, cols];
        LlenarMatrizConAleatorios(matriz);

        // Variables para el recorrido y la suma
        int sumaTotal = 0;
        int posX = 0, posY = 0;

        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            MostrarMatriz(matriz, posX, posY, sumaTotal);

            Console.WriteLine($"\nSuma acumulada: {sumaTotal}");
            Console.WriteLine("Presione las flechas para moverse o 'Esc' para salir.");
            var tecla = Console.ReadKey(true);

            // Movimiento basado en la tecla
            switch (tecla.Key)
            {
                case ConsoleKey.UpArrow:
                    if (posX > 0) Mover(ref posX, ref posY, posX - 1, posY, matriz, ref sumaTotal);
                    break;

                case ConsoleKey.DownArrow:
                    if (posX < rows - 1) Mover(ref posX, ref posY, posX + 1, posY, matriz, ref sumaTotal);
                    break;

                case ConsoleKey.LeftArrow:
                    if (posY > 0) Mover(ref posX, ref posY, posX, posY - 1, matriz, ref sumaTotal);
                    break;

                case ConsoleKey.RightArrow:
                    if (posY < cols - 1) Mover(ref posX, ref posY, posX, posY + 1, matriz, ref sumaTotal);
                    break;

                case ConsoleKey.Escape:
                    salir = true;
                    break;
            }
        }



    }
}



