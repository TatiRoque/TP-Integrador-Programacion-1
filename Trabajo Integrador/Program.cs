using System;
using System.Runtime.Serialization.Formatters;

namespace TrabajoIntegrador
{
    class Cancion
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
            Menu();

        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Eliga la opción que quiera ejecutar");
            Console.WriteLine("1. Teoría Musical.");
            Console.WriteLine("2. Escalas.");
            Console.WriteLine("3. Guardar mis canciones.");
            Console.WriteLine("4. Salir.");

            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    TeoriaMusical();
                    break;
                case 2:
                    Escalas();
                    break;
                case 3:
                    GuardarAcordes();
                    break;
                case 4:
                    break;
            }
        }
        static void TeoriaMusical()
        {

        }
        static void Escalas()
        {
            Console.WriteLine("Seleccione una opción");
        }
        static void GuardarAcordes()
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("1. Agregar canción");
            Console.WriteLine("2. Mostrar todas las canciones");
            Console.WriteLine("3. Buscar canciones");
            Console.WriteLine("4.Reemplazar acorde ");
            Console.WriteLine("5. Salir");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    //cuando veamos listas
                    Console.WriteLine("Ingrese el nombre de su canción");
                    string NombreCancion = Console.ReadLine();
                    Console.WriteLine("Ingrese la cantidad de acordes que tendra su cancion");
                    int CantAcordes = int.Parse(Console.ReadLine());

                    string[,] Cancion = new string[CantAcordes + 1, CantAcordes + 1];
                    Cancion[0, 0] = NombreCancion;
                    for (int i = 0; i < Cancion.GetLength(0); i++)
                    {
                        for (int j = 0; j < Cancion.GetLength(1); j++)
                        {
                            Cancion[i, j] = Console.ReadLine();
                        }
                    }

                    break;
                case 2:
                    Console.WriteLine("Ingrese el nombre de la canción que quiere encontrar.");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el nombre de la canción que quiere encontrar.");
                    string BuscarCancion = Console.ReadLine().ToLower();
                    break;
                case 4:
                    Console.WriteLine("Ingrese el nombre de la cancion a modificar acordes");
                    break;
                case 5:
                    Menu();
                    break;

            }
        }
    }
}