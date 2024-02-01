namespace Ejercicio4Repas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] arrayNumeros = new int[3, 2];
            Random aleatorios = new Random();

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 2; columna++)
                {
                    arrayNumeros[fila, columna] = aleatorios.Next(1, 101);
                    Console.Write(arrayNumeros[fila, columna] + "\t");
                }
                Console.WriteLine();
            }

            for (int columna = 0; columna < 2; columna++)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2 - i; j++)
                    {
                        if (arrayNumeros[j, columna] > arrayNumeros[j + 1, columna])
                        {
                            int aux = arrayNumeros[j, columna];
                            arrayNumeros[j, columna] = arrayNumeros[j + 1, columna];
                            arrayNumeros[j + 1, columna] = aux;
                        }
                    }
                }
            }
            int valorMinimo = arrayNumeros[0, 0];
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 2; columna++)
                {
                    if (arrayNumeros[fila, columna] < valorMinimo)
                    {
                        valorMinimo = arrayNumeros[fila, columna];
                    }
                }
            }
            Console.WriteLine("El valor minimo es: " + valorMinimo);

            for (int columna = 0; columna < 2; columna++)
            {
                int valorMaximoColumna = arrayNumeros[0, columna];
                for (int fila = 1; fila < 3; fila++)
                {
                    if (arrayNumeros[fila, columna] > valorMaximoColumna)
                    {
                        valorMaximoColumna = arrayNumeros[fila, columna];
                    }
                }

                Console.WriteLine("El valor maximo es: " + valorMaximoColumna);
            }
            for (int fila = 0; fila < 3; fila++)
            {
                int sumaFila = 0;
                for (int columna = 0; columna < 2; columna++)
                {
                    sumaFila += arrayNumeros[fila, columna];
                }
                double mediaFila = (double)sumaFila / 2;
                Console.WriteLine("La media de la fila" + fila + "es:" + mediaFila);
            }
        }
    }
}
