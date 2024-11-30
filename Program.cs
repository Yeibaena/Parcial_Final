
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
        Console.Clear();
        Console.WriteLine("Has salido del programa.");
        Console.WriteLine($"La suma total de los números recorridos es: {sumaTotal}");
    }


    /// Llena una matriz con números aleatorios entre 1 y 9.

    static void LlenarMatrizConAleatorios(int[,] matriz)
    {
        Random rand = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = rand.Next(1, 10);
            }
        }
        matriz[0, 0] = 0; // Número base en (0,0)
    }

    /// Muestra la matriz en consola, coloreando la posición actual en verde.

    static void MostrarMatriz(int[,] matriz, int posX, int posY, int sumaTotal)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i == posX && j == posY)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{sumaTotal} ");
                }
                else
                {
                    Console.ResetColor();
                    Console.Write($"{matriz[i, j]} ");
                }
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }
    /// <summary>
    /// Mueve la posición actual, suma el valor en la nueva posición y marca la posición previa con 0.
    /// </summary>
    static void Mover(ref int posX, ref int posY, int nuevoX, int nuevoY, int[,] matriz, ref int sumaTotal)
    {
        sumaTotal += matriz[nuevoX, nuevoY]; // Sumar el valor de la nueva posición
        matriz[posX, posY] = 0; // Marcar la posición previa como 0
        posX = nuevoX;
        posY = nuevoY;
        // No actualizamos la matriz[nuevoX, nuevoY] a 0, ya que la suma total se refleja en MostrarMatriz
    }
}







