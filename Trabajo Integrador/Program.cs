using System;

namespace TrabajoIntegrador
{
    class Cancion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al");
            Console.WriteLine("Programa de msúcica");
            Console.ReadKey();
            Menu();

        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Eliga la opción que quiera ejecutar");
            Console.WriteLine("1. Teoría Musical. |2. Escalas.|3. Guardar mis canciones.");
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
            }
        }
        static void TeoriaMusical()
        {

        }
        static void Escalas()
        {

        }
        static void GuardarAcordes()
        {
            Console.Clear();
            Console.Write("Seleccione una opción: ");
            Console.WriteLine("1. Agregar canción");
            Console.WriteLine("2. Buscar canciones");
            Console.WriteLine("3. Reemplazar acorde");
            Console.WriteLine("4. Salir");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine();
                    string NombreCancion = Console.ReadLine();
                    Console.WriteLine();
                    int CantAcordes = int.Parse(Console.ReadLine());
                    string[] Cancion = new string[CantAcordes + 1];
                    Cancion[0] = NombreCancion;

                    break;
                case 2:
                    Console.WriteLine("Ingrese el nombre de la canción que quiere encontrar.");
                    string BuscarCancion = Console.ReadLine().ToLower();
                    if(String.Compare())
                    {

                    }
                    break;
                case 3:
                  
                    break;
                case 4:
                    break;
            }

        }
    }
}