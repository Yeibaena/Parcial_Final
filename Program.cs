
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



            }
}



