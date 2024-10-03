using System;
using System.Runtime.Serialization.Formatters;

namespace TrabajoIntegrador
{
    class Cancion
    {
        static void Main(string[] args)
        {
            EstablecerColores();
            CentrarYMostrarMensaje();
            RestaurarColores();
            Console.ReadKey();
            string nombre = ConsultarNombre();
            Menu(nombre);
        }
        static void EstablecerColores()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;  // Fondo rojo (puedes cambiar el color)
            Console.ForegroundColor = ConsoleColor.Yellow;    // Texto amarillo
        }
        static void CentrarYMostrarMensaje()
        {
            // Obtener el tamaño de la consola para centrar el mensaje y el borde
            int anchoConsola = Console.WindowWidth;
            int altoConsola = Console.WindowHeight;

            // Dimensiones del recuadro
            int anchoRecuadro = 50;
            int altoRecuadro = 10;

            // Calcular las posiciones centrales
            int posicionX = (anchoConsola - anchoRecuadro) / 2;
            int posicionY = (altoConsola - altoRecuadro) / 2;

            // Dibujar el borde centrado
            DibujarBorde(anchoRecuadro, altoRecuadro, posicionX, posicionY);

            // Posicionar el mensaje de bienvenida centrado dentro del borde
            Console.SetCursorPosition(posicionX + 12, posicionY + 5);
            Console.WriteLine(" Bienvenido al Programa de Música ");
        }
        static void DibujarBorde(int ancho, int alto, int posX, int posY)
        {
            // Dibuja el borde superior
            Console.SetCursorPosition(posX, posY);
            Console.Write("╔");
            for (int i = 0; i < ancho - 2; i++)
            {
                Console.Write("═");
            }
            Console.Write("╗");

            // Dibuja los lados
            for (int i = 1; i < alto - 1; i++)
            {
                Console.SetCursorPosition(posX, posY + i);
                Console.Write("║");
                Console.SetCursorPosition(posX + ancho - 1, posY + i);
                Console.Write("║");
            }

            // Dibuja el borde inferior
            Console.SetCursorPosition(posX, posY + alto - 1);
            Console.Write("╚");
            for (int i = 0; i < ancho - 2; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝");
        }
        static void RestaurarColores()
        {
            Console.ResetColor();
        }
        static string ConsultarNombre()
        {
            Console.Clear();
            Console.WriteLine("¿Cómo es tu nombre?");
            string nombre = Console.ReadLine();
            return nombre;
        }
        static void Menu(string nombre)
        {
            Console.Clear();
            Console.WriteLine($"Bienvenido al menú {nombre}");
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
                    Escalas(nombre);
                    break;
                case 3:
                    GuardarAcordes(nombre);
                    break;
                case 4:
                    break;
            }
        }
        static void TeoriaMusical()
        {

        }
        static void Escalas(string nombre)
        {
            Console.Clear();
            Console.WriteLine($"Por favor eliga una opcion {nombre}");
            Console.WriteLine("1. Mostrar las esclas mayores.");
            Console.WriteLine("2. Mostrar las escalas menores.");
            Console.WriteLine("3. Consultar por la escala mayor de una nota.");
            Console.WriteLine("4. Consultar por la escala menor de una nota.");
            Console.WriteLine("5. Volver al menú.");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    MostrarEscalasMayores(nombre);
                    break;
                case 2:
                    MostrarEscalasMenores(nombre);
                    break;
                case 3:
                    ConsultaEscalaMayor(nombre);
                    break;
                case 4:
                    ConsultaEscalaMenor(nombre);
                    break;
                case 5:
                    Menu(nombre);
                    break;
            }
        }
        static void MostrarEscalasMayores(string nombre)
        {
            Console.Clear();

            string[,] EscalaMayor = { { "C", "D", "E", "F", "G", "A", "B", "C" }, { "G", "A", "B", "C", "D", "E", "F#", "G" }, { "D", "E", "F#", "G", "A", "B", "C#", "D" }, { "A", "B", "C#", "D", "E", "F#", "G#", "A" }, { "E", "F#", "G#", "A", "B", "C#", "D#", "E" }, { "B", "C#", "D#", "E", "F#", "G#", "A#", "B" }, { "F#", "G#", "A#", "B", "C#", "D#", "E#", "F#" } };
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("╔════════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╗");
                Console.Write("║");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"  \t{EscalaMayor[i, j]}\t ║ ");

                }
                Console.WriteLine();
                Console.WriteLine("╚════════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╝");
            }
            MenuEscalas(nombre);
        }
        static void MostrarEscalasMenores(string nombre)
        {
            Console.Clear();
            string[,] EscalaMenor = { { "C", "D", "Eb", "F", "G", "Ab", "Bb", "C" }, { "D", "E", "F", "G", "A", "Bb", "C", "D" }, { "E", "F#", "G", "A", "B", "C", "D", "E" }, { "F", "G", "Ab", "Bb", "C", "Db", "Eb", "F" }, { "G", "A", "B", "C", "D", "E", "F#", "G" }, { "A", "Bb", "C", "D", "Eb", "F", "G", "A" }, { "B", "C#", "D", "E", "F#", "G#", "A", "B" } };
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("╔════════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╗");
                Console.Write("║");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"  \t{EscalaMenor[i, j]}\t ║ ");

                }
                Console.WriteLine();
                Console.WriteLine("╚════════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╝");
            }
            MenuEscalas(nombre);
        }
        static void ConsultaEscalaMayor(string nombre)
        {
            Console.Clear();
            Console.WriteLine("Ingrese una nota para saber su escala mayor (A, B, C, D, E, F, G): ");
            string nota = Console.ReadLine().ToUpper();
            if (!NotaValida(nota))
            {
                Console.WriteLine("Nota inválida. Por favor ingrese una nota válida.");
                return;
            }

            string[] escalaMayor = ObtenerEscalaMayor(nota);
            Console.Clear();
            Console.WriteLine($"La escala mayor de {nota} es: ");
            Console.WriteLine("╔════════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╗");
            Console.Write("║");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"  \t{escalaMayor[i]}\t ║ ");

            }
            Console.WriteLine();
            Console.WriteLine("╚════════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╝");
            MenuEscalas(nombre);
        }
        //verificar esto 
        static bool NotaValida(string nota)
        {
            string[] notasValidas = { "A", "B", "C", "D", "E", "F", "G" };
            return Array.Exists(notasValidas, n => n == nota);
        }
        static string[] ObtenerEscalaMayor(string notaBase)
        {
            string[] escalaCromatica = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

            int indiceNotaBase = Array.IndexOf(escalaCromatica, notaBase);

            // Tono, Tono, Semitono, Tono, Tono, Tono, Semitono
            int[] intervalos = { 2, 2, 1, 2, 2, 2, 1 };

            string[] escalaMayor = new string[8];

            // La primera posición del array escalaMayor será siempre la nota base ingresada por el usuario.
            escalaMayor[0] = notaBase;

            // Calcular las demás notas de la escala mayor
            int indiceActual = indiceNotaBase;
            for (int i = 0; i < intervalos.Length; i++)
            {
                // Si el índice calculado es 12, entonces 12 % 12 = 0 (volver a la primera nota, C).
                //Si el índice calculado es 13, entonces 13 % 12 = 1(volvemos a la segunda nota, C#).
                indiceActual = (indiceActual + intervalos[i]) % escalaCromatica.Length;
                escalaMayor[i + 1] = escalaCromatica[indiceActual];
            }

            return escalaMayor;
        }
        static void ConsultaEscalaMenor(string nombre)
        {
            Console.Clear();
            Console.WriteLine("Ingrese una nota para saber su escala menor (A, B, C, D, E, F, G): ");
            string nota = Console.ReadLine().ToUpper();
            if (!EsNotaValida(nota))
            {
                Console.WriteLine("Nota inválida. Por favor ingrese una nota válida.");
                return;
            }

            string[] escalaMenor = ObtenerEscalaMenor(nota);
            Console.Clear();
            Console.WriteLine($"La escala menor de {nota} es: ");
            Console.WriteLine("╔════════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╗");
            Console.Write("║");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"  \t{escalaMenor[i]}\t ║ ");

            }
            Console.WriteLine();
            Console.WriteLine("╚════════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╝");
            MenuEscalas(nombre);
        }
        static bool EsNotaValida(string nota)
        {
            string[] notasValidas = { "A", "B", "C", "D", "E", "F", "G" };
            return Array.Exists(notasValidas, n => n == nota);
        }
        static string[] ObtenerEscalaMenor(string notaBase)
        {
            string[] escalaCromatica = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

            int indiceNotaBase = Array.IndexOf(escalaCromatica, notaBase);

            // Tono - Semitono - Tono - Tono - Semitono - Tono - Tono
            int[] intervalos = { 2, 1, 2, 2, 1, 2, 2 };

            string[] escalaMenor = new string[8];

            // La primera posición del array escalaMayor será siempre la nota base ingresada por el usuario.
            escalaMenor[0] = notaBase;

            // Calcular las demás notas de la escala mayor
            int indiceActual = indiceNotaBase;
            for (int i = 0; i < intervalos.Length; i++)
            {
                // Si el índice calculado es 12, entonces 12 % 12 = 0 (volver a la primera nota, C).
                //Si el índice calculado es 13, entonces 13 % 12 = 1(volvemos a la segunda nota, C#).
                indiceActual = (indiceActual + intervalos[i]) % escalaCromatica.Length;
                escalaMenor[i + 1] = escalaCromatica[indiceActual];
            }

            return escalaMenor;
        }
        static void MenuEscalas(string nombre)
        {
            Console.WriteLine($"{nombre}, selecciona una opción");
            Console.WriteLine("1. Volver al menú de escalas.");
            Console.WriteLine("2. Volver al menú principal.");
            Console.WriteLine("3. Salir del programa.");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Escalas(nombre);
                    break;
                case 2:
                    Menu(nombre);
                    break;
                case 3:
                    break;
            }
        }
        //modularizar todo lo de abajo
        static void GuardarAcordes(string nombre)
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("1. Agregar canción");
            Console.WriteLine("2. Mostrar todas las canciones");
            Console.WriteLine("3. Buscar canciones");
            Console.WriteLine("4. Reemplazar acorde ");
            Console.WriteLine("5. Volver al menú");
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
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el nombre de la canción que quiere encontrar.");
                    string BuscarCancion = Console.ReadLine().ToLower();
                    break;
                case 4:
                    Console.WriteLine("Ingrese el nombre de la cancion a modificar acordes");
                    break;
                case 5:
                    Menu(nombre);
                    break;

            }
        }
        static void MenuAcordes()
        {

        }
    }
}