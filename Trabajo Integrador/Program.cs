using System;
using System.Runtime.Serialization.Formatters;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Linq;

namespace TrabajoIntegrador
{
    class Program
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
            int anchoConsola = Console.WindowWidth;
            int altoConsola = Console.WindowHeight;

            int anchoRecuadro = 50;
            int altoRecuadro = 10;

            int posicionX = (anchoConsola - anchoRecuadro) / 2;
            int posicionY = (altoConsola - altoRecuadro) / 2;

            DibujarBorde(anchoRecuadro, altoRecuadro, posicionX, posicionY);

            Console.SetCursorPosition(posicionX + 12, posicionY + 5);
            Console.WriteLine(" Bienvenido al Programa de Música ");
        }
        static void DibujarBorde(int ancho, int alto, int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write("╔");
            for (int i = 0; i < ancho - 2; i++)
            {
                Console.Write("═");
            }
            Console.Write("╗");

            for (int i = 1; i < alto - 1; i++)
            {
                Console.SetCursorPosition(posX, posY + i);
                Console.Write("║");
                Console.SetCursorPosition(posX + ancho - 1, posY + i);
                Console.Write("║");
            }

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
            Console.Write("Bienvenido al menú ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(nombre);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Eliga la opción que quiera ejecutar");
            Console.WriteLine("1. Teoría Musical.");
            Console.WriteLine("2. Escalas.");
            Console.WriteLine("3. Guardar mis canciones.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("4. Salir.");
            Console.ResetColor();

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
            Console.Write($"Por favor eliga una opcion ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(nombre);
            Console.ResetColor();
            Console.WriteLine("1. Mostrar las escalas mayores.");
            Console.WriteLine("2. Mostrar las escalas menores.");
            Console.WriteLine("3. Consultar por la escala mayor de una nota.");
            Console.WriteLine("4. Consultar por la escala menor de una nota.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("5. Volver al menú.");
            Console.ResetColor();
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
                    Console.Write("  \t");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{EscalaMayor[i,j]}");
                    Console.ResetColor();
                    Console.Write("\t ║ ");

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
                    Console.Write("  \t");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{EscalaMenor[i,j]}");
                    Console.ResetColor();
                    Console.Write("\t ║ ");
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
                Console.Write("  \t");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{escalaMayor[i]}");
                Console.ResetColor();
                Console.Write("\t ║ ");

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
            string eEscalaMenor = "E";
            string bEscalaMenor = "B";
            if (nota == eEscalaMenor || nota == bEscalaMenor)
            {
                string[] escalaMenor = EscalaMenorEyB(nota);
                Console.Clear();
                Console.WriteLine($"La escala menor de {nota} es: ");
                Console.WriteLine("╔════════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╗");
                Console.Write("║");
                for (int i = 0; i < 8; i++)
                {
                    Console.Write("  \t");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{escalaMenor[i]}");
                    Console.ResetColor();
                    Console.Write("\t ║ ");

                }
                Console.WriteLine();
                Console.WriteLine("╚════════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╝");
                MenuEscalas(nombre);
            }
            if (!EsNotaValida(nota))
            {
                Console.WriteLine("Nota inválida. Por favor ingrese una nota válida.");
                return;
            }
            else
            {
                string[] escalaMenor = ObtenerEscalaMenor(nota);
                Console.Clear();
                Console.WriteLine($"La escala menor de {nota} es: ");
                Console.WriteLine("╔════════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╦═══════════════╗");
                Console.Write("║");
                for (int i = 0; i < 8; i++)
                {
                    Console.Write("  \t");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{escalaMenor[i]}");
                    Console.ResetColor();
                    Console.Write("\t ║ ");
                }
                Console.WriteLine();
                Console.WriteLine("╚════════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╩═══════════════╝");
                MenuEscalas(nombre);
            }
        }
        static bool EsNotaValida(string nota)
        {
            string[] notasValidas = { "A", "B", "C", "D", "E", "F", "G" };
            return Array.Exists(notasValidas, n => n == nota);
        }
        static string[] EscalaMenorEyB(string notaBase)
        {
            string[] escalaCromatica = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

            int indiceNotaBase = Array.IndexOf(escalaCromatica, notaBase);

            // Tono, Tono, Semitono, Tono, Tono, Tono, Semitono
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
        static string[] ObtenerEscalaMenor(string notaBase)
        {
            string[] escalaCromatica = { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };

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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(nombre); 
            Console.ResetColor();
            Console.WriteLine(", selecciona una opción");
            Console.WriteLine("1. Volver al menú de escalas.");
            Console.WriteLine("2. Volver al menú principal.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3. Salir del programa.");
            Console.ResetColor();
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
        static void GuardarAcordes(string nombre)
        {
            List<Cancion> Canciones = new List<Cancion>();
            MenuAcordes(nombre, Canciones);
        }
        static void MenuAcordes(string nombre, List<Cancion> Canciones)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(nombre);
            Console.ResetColor();
            Console.WriteLine(", selecciona una opción");
            Console.WriteLine("1. Agregar canción");
            Console.WriteLine("2. Mostrar todas las canciones");
            Console.WriteLine("3. Buscar canciones");
            Console.WriteLine("4. Agregar o borrar un acorde ");
            Console.WriteLine("5. Borrar canción");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("6. Volver al menú principal");
            Console.ResetColor();
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    AgregarCancion(Canciones, nombre);
                    break;
                case 2:
                    MostrarCanciones(Canciones, nombre);
                    break;
                case 3:
                    BuscarCancion(Canciones, nombre);
                    break;
                case 4:
                    OpcionMenuAcordes(Canciones, nombre);
                    break;
                case 5:
                    BorrarCancion(Canciones, nombre);
                    break;
                case 6:
                    Menu(nombre);
                    break;

            }
        }
        static void OpcionMenuAcordes(List<Cancion> Canciones, string nombre)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(nombre);
            Console.ResetColor();
            Console.Write(" deseas agregar un acorde o borrarlo? (");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A");
            Console.ResetColor();
            Console.Write(" / ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("B");
            Console.ResetColor();
            Console.WriteLine(" ) ");

            string sb = Console.ReadLine();
            if (sb.ToLower() == "a")
            {
                AgregarAcorde(Canciones, nombre);
            }
            else if (sb.ToLower() == "b")
            {
                BorrarAcorde(Canciones, nombre);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor ingrese una opción valida");
                Console.ResetColor();
                Console.ReadKey();
                OpcionMenuAcordes(Canciones, nombre);
            }

        }
        struct Cancion
        {
            public string nombre { get; set; }
            public List<string> acorde { get; set; }
            public Cancion(string nombre1)
            {
                nombre = nombre1;
                acorde = new List<string>();
            }
        }
        static void AgregarCancion(List<Cancion> Canciones, string nombre)
        {
            Console.Clear();
            Console.WriteLine("¿Cómo se llama su canción?");
            string nombre1 = Console.ReadLine();
            Cancion nuevaCancion = new Cancion(nombre1);
            while (true)
            {
                Console.WriteLine("Ingrese tantos acordes quiera y a al terminar escriba 'listo'.");
                string acorde = Console.ReadLine();
                if (acorde.ToLower() == "listo")
                {
                    break;
                }
                nuevaCancion.acorde.Add(acorde);
            }
            Canciones.Add(nuevaCancion);
            MenuAcordes(nombre, Canciones);
        }
        static void MostrarCanciones(List<Cancion> Canciones, string nombre)
        {
            Console.Clear();
            foreach (var cancion in Canciones)
            {
                Console.WriteLine();
                Console.Write($"{cancion.nombre} por ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(nombre);
                Console.ResetColor();
                Console.WriteLine(string.Join(" | ", cancion.acorde));

            }
            Console.ReadKey();
            MenuAcordes(nombre, Canciones);
        }
        static void BuscarCancion(List<Cancion> Canciones, string nombre)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre de la canción y se mostraran sus acordes");
            string nombreCancion = Console.ReadLine();
            Cancion cancionBuscar = Canciones.Find(a => a.nombre.Equals(nombreCancion, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(string.Join(" | ", cancionBuscar.acorde));
            Console.ReadKey();
            MenuAcordes(nombre, Canciones);
        }
        static void AgregarAcorde(List<Cancion> Canciones, string nombre)
        {
            Console.WriteLine("Ingrese el nombre de la canción en la que esta el acorde");
            string nombreCancion = Console.ReadLine();
            Cancion agregarAcorde = Canciones.Find(a => a.nombre.Equals(nombreCancion, StringComparison.OrdinalIgnoreCase));
            if (nombreCancion != null)
            {
                Console.WriteLine(string.Join(" | ", agregarAcorde.acorde));
                Console.WriteLine("¿Qué acorde desea borrar?");
                string acorde =Console.ReadLine();
                agregarAcorde.acorde.Add(acorde);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El acorde fue agregado con exitó.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La canción '{nombreCancion}' no fue encontrada.");
                Console.ResetColor();
            }
            Console.ReadKey();
            MenuAcordes(nombre, Canciones);
        }
        static void BorrarAcorde(List<Cancion> Canciones, string nombre)
        {
            Console.WriteLine("Ingrese el nombre de la canción en la que esta el acorde");
            string nombreCancion = Console.ReadLine();
            Cancion cancionBuscar = Canciones.Find(a => a.nombre.Equals(nombreCancion, StringComparison.OrdinalIgnoreCase));

            if (nombreCancion != null)
            {
                Console.WriteLine(string.Join(" | ", cancionBuscar.acorde));
                Console.WriteLine();
                Console.WriteLine("¿Cuál acorde quiere borrar?");
                string acordeBorrar = Console.ReadLine();

                if (cancionBuscar.acorde.Contains(acordeBorrar))
                {
                    cancionBuscar.acorde.Remove(acordeBorrar);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"El acorde '{acordeBorrar}' ha sido borrado de la canción '{cancionBuscar.nombre}'.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"El acorde '{acordeBorrar}' no se encuentra en la canción '{cancionBuscar.nombre}'.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La canción '{nombreCancion}' no fue encontrada.");
                Console.ResetColor();
            }
            Console.ReadKey();
            MenuAcordes(nombre, Canciones);
        }
        static void BorrarCancion(List<Cancion> Canciones, string nombre)
        {
            Console.WriteLine("Ingrese el nombre de la canción que desee borrar.");
            string nombreCancion = Console.ReadLine();
            Cancion cancionBorrar = Canciones.Find(a => a.nombre.Equals(nombreCancion, StringComparison.OrdinalIgnoreCase));
            if (nombreCancion != null)
            {
                Canciones.Remove(cancionBorrar);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La canción fue eliminada con exitó.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La canción '{nombreCancion}' no fue encontrada.");
                Console.ResetColor();
            }
            Console.ReadKey();
            MenuAcordes(nombre, Canciones);
        }
    }
}