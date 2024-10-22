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

        static int calificacionExamen1 = -1; // -1 indica q el examen no fue realizado aun
        static int calificacionExamen2 = -1;
        static int calificacionExamen3 = -1;
        static void TeoriaMusical()
        {
            Console.Clear();

            Console.Clear();
            Console.WriteLine("Bienvenido al curso básico de teoría musical. Este consta de 3 módulos de aprendizaje y sus correspondientes exámenes orientados a comprobar el entendimiento de los contenidos dados. \n\nAcceda a los módulos escribiendo el número indicado.\n");
            Console.WriteLine("1 – Modulo I: ¿Que sería la música? \n\n2 – Modulo II: Notas y acordes \n\n3 – Modulo III: no sé todavía\n ");
            Console.WriteLine("De la misma forma puede acceder a los exámenes, que se desbloquearan progresivamente.\n");
            Console.WriteLine("4 – Examen Módulo I \n\n5 - Examen Módulo II \n\n6 - Examen Módulo III \n\n");

            Console.WriteLine($"Calificación examen 1: {(calificacionExamen1 == -1 ? "no realizado" : calificacionExamen1.ToString())}");
            Console.WriteLine($"Calificación examen 2: {(calificacionExamen2 == -1 ? "no realizado" : calificacionExamen2.ToString())}");
            Console.WriteLine($"Calificación examen 3: {(calificacionExamen3 == -1 ? "no realizado" : calificacionExamen3.ToString())}");

            Console.WriteLine("\n\n7 - Volver al menú \n ");

            int opcion = int.Parse(Console.ReadLine());
            bool opcionTMelegida = false;

            do
            {
                switch (opcion)
                {
                    case 1:
                        opcionTMelegida = true;
                        mostrarModulo(1);
                        break;
                    case 2:
                        opcionTMelegida = true;
                        mostrarModulo(2);
                        break;
                    case 3:
                        opcionTMelegida = true;
                        mostrarModulo(3);
                        break;
                    case 4:
                        opcionTMelegida = true;
                        examenTM1();
                        break;
                    case 5:
                        opcionTMelegida = true;
                        examenTM2();
                        break;
                    case 6:
                        opcionTMelegida = true;
                        examenTM3();
                        break;
                    case 7:
                        opcionTMelegida = true;                      
                        break;
                    default:
                        Console.WriteLine("Ingrese un comando válido (número 1 - 7)");
                        opcion = int.Parse(Console.ReadLine());
                        break;
                }
            }
            while (!opcionTMelegida);

            Console.ReadKey();
        }

        static void mostrarModulo(int numeroModulo)
        {
            string[] paginas;

            switch (numeroModulo)
            {
                case 1:
                    paginas = new string[]
                    {
                    "Aristóteles: \"La música es un arte imitativo de la realidad que afecta profundamente las emociones.\" \n \nAl igual que el filósofo, muchas personas a lo largo de la historia se aventuraron a la dicha misión de poder \nmediante definiciones, limitar las posibilidades del concepto, a fin de controlarlo o quizá sentirlo de alguna \nmanera, concretable. \n\nEl material teórico a continuación se centrará en este último campo mencionado, lo concreto, de forma que se evitaran posibles y probables ambigüedades. \n",
                    "La música se define como una organización de sonidos que produce efectos en el oyente. \n\nDesde la antigüedad, la música ha sido una parte integral de la cultura humana, utilizada en rituales, ceremonias y como forma de entretenimiento. \n\nA través de diversas civilizaciones, la música ha evolucionado y se ha adaptado a diferentes contextos sociales y culturales. \n",
                    "La música no solo se experimenta de manera auditiva, sino que también puede provocar respuestas emocionales profundas. \n\nLos ritmos y melodías pueden evocar recuerdos y sentimientos, conectando a las personas a través de experiencias compartidas. \n\nAsí, la música se convierte en un lenguaje universal que trasciende fronteras. \n",
                    "A lo largo del tiempo, diferentes teorías musicales han surgido para explicar cómo se percibe y se crea la música. \n\nDesde la teoría de las proporciones de Pitágoras hasta la armonía moderna, cada enfoque ha buscado desentrañar los secretos detrás de la creación musical. \n\nLa música, en este sentido, es tanto un arte como una ciencia. \n",
                    "El papel del compositor es crucial en la creación musical, ya que es quien da forma a las ideas y las traduce en sonidos. \n\nLos compositores utilizan diferentes técnicas y estilos para expresar su visión artística. \n\nDesde la notación musical hasta la improvisación, cada método ofrece una manera única de comunicar emociones. \n",
                    "Los intérpretes, por su parte, aportan su propia interpretación a las obras musicales, convirtiéndose en mediadores entre el compositor y el público. \n\nLa actuación musical implica no solo la ejecución técnica, sino también la capacidad de transmitir el sentimiento detrás de la música. \n\nEsto agrega otra capa de significado a la experiencia musical. \n",
                    "A medida que la música ha evolucionado, también lo han hecho los instrumentos musicales. \n\nDesde los primitivos instrumentos de percusión hasta los sofisticados sintetizadores de hoy, cada instrumento aporta su timbre y textura únicos a la música. \n\nLa elección de instrumentos influye directamente en el carácter de una composición. \n",
                    "La teoría musical no solo se ocupa de la composición, sino también de la forma en que los elementos musicales se combinan. \n\nConceptos como melodía, armonía y ritmo son fundamentales para entender cómo se construyen las obras musicales. \n\nCada uno de estos elementos juega un papel vital en la creación de una experiencia auditiva cohesiva. \n",
                    "La práctica de la música en conjunto, o la música de cámara, permite a los músicos interactuar y colaborar, enriqueciendo la experiencia musical. \n\nEste tipo de interpretación fomenta la comunicación y la creatividad, haciendo que la música sea una experiencia compartida. \n\nEl trabajo en equipo es esencial para lograr una interpretación exitosa. \n",
                    "La música, como arte, también refleja la sociedad y la cultura en la que se crea. \n\nA través de las diferentes épocas, los estilos musicales han sido un reflejo de los cambios sociales, políticos y culturales. \n\nAsí, la música se convierte en un espejo de la humanidad, capturando su esencia a lo largo de la historia. \n"
                    };
                    break;
                case 2:
                    paginas = new string[]
                    {
                    "En la música, las notas son la base sobre la que se construyen melodías y armonías. \n\nCada nota representa una frecuencia específica y, al combinarlas, se crean diferentes sonidos. \n\nEl sistema de notación musical nos permite escribir y leer estas notas de manera efectiva. \n",
                    "Las escalas son secuencias de notas que forman la base de la tonalidad en la música. \n\nLa escala mayor y la escala menor son las más comunes, cada una evocando diferentes emociones y sensaciones. \n\nComprender las escalas es fundamental para cualquier músico. \n",
                    "Los acordes, formados por la combinación de tres o más notas, son esenciales en la música. \n\nPueden ser mayores, menores, aumentados o disminuidos, y cada tipo aporta una atmósfera única a las composiciones. \n\nLos acordes sirven como la columna vertebral de muchas canciones. \n",
                    "La progresión de acordes es un aspecto crucial en la estructura musical. \n\nUna progresión común puede transformar una simple melodía en una obra maestra. \n\nEntender cómo funcionan estas progresiones es vital para los compositores. \n",
                    "La armonía se refiere a la combinación de diferentes notas y acordes al mismo tiempo. \n\nEste aspecto de la música crea profundidad y complejidad, enriqueciendo la experiencia auditiva. \n\nLos arreglos vocales e instrumentales son ejemplos claros de la aplicación de la armonía. \n",
                    "La relación entre las notas en un acorde y su función dentro de una escala es fundamental. \n\nAlgunas notas son consideradas más consonantes y estables, mientras que otras pueden ser disonantes, creando tensión. \n\nEsta tensión y liberación son herramientas poderosas en la música. \n",
                    "La modulación es el cambio de una tonalidad a otra dentro de una composición. \n\nEste recurso añade dinamismo y variedad a la música, sorprendiendo al oyente. \n\nAprender a modular efectivamente puede llevar una composición a nuevos niveles. \n",
                    "La relación entre ritmo y armonía es también significativa. \n\nEl ritmo da estructura temporal a la música, mientras que la armonía proporciona el contexto tonal. \n\nAmbos elementos trabajan juntos para crear una experiencia musical coherente. \n",
                    "La práctica de tocar escalas y acordes es esencial para el desarrollo técnico de cualquier músico. \n\nA través de la repetición y la práctica, los músicos pueden dominar su instrumento y mejorar su habilidad. \n\nEl entrenamiento constante es clave para alcanzar el éxito musical. \n",
                    "Finalmente, el estudio de notas y acordes no solo es una cuestión técnica, sino también emocional. \n\nCada acorde puede evocar sentimientos y recuerdos, convirtiendo la teoría en una experiencia personal. \n\nLa conexión emocional con la música es lo que la hace verdaderamente poderosa. \n"

                    };
                    break;
                case 3:
                    paginas = new string[]
                    {
                    "En el ámbito de la teoría musical, la polifonía es un concepto clave. \n\nSe refiere a la simultaneidad de varias líneas melódicas independientes, creando una textura rica y compleja. \n\nEste estilo se encuentra en muchas tradiciones musicales alrededor del mundo. \n",
                    "La forma musical describe la estructura de una composición. \n\nConceptos como verso-coro y sonata son ejemplos de formas utilizadas para organizar las ideas musicales. \n\nComprender la forma es esencial para la creación y análisis musical. \n",
                    "La textura musical se refiere a cómo se combinan las distintas voces e instrumentos en una pieza. \n\nDesde la monofonía hasta la polifonía, cada tipo de textura ofrece una experiencia auditiva única. \n\nLa textura puede influir en la percepción y el impacto emocional de la música. \n",
                    "La dinámica en música se refiere a las variaciones en el volumen de las notas. \n\nLos contrastes dinámicos pueden añadir drama y emoción a una interpretación, destacando momentos clave en una composición. \n\nLa habilidad de manejar la dinámica es vital para los intérpretes. \n",
                    "La ornamentación es el uso de adornos melódicos para enriquecer una línea musical. \n\nEste recurso puede hacer que una melodía suene más expresiva y elaborada. \n\nLos músicos pueden aplicar diversas técnicas de ornamentación para personalizar su interpretación. \n",
                    "El análisis musical es una herramienta esencial para comprender y descomponer las obras. \n\nA través del análisis, los músicos pueden identificar patrones, estructuras y elementos que contribuyen al efecto general de la música. \n\nEsta habilidad es invaluable para la educación musical. \n",
                    "La improvisación es una forma de expresión creativa que permite a los músicos crear música en el momento. \n\nEste arte requiere un profundo conocimiento de la teoría y la técnica musical. \n\nLa improvisación también fomenta la creatividad y la espontaneidad. \n",
                    "El ritmo es uno de los elementos más fundamentales de la música. \n\nLos patrones rítmicos no solo estructuran la música, sino que también pueden evocar emociones y energías específicas. \n\nLa variación en el ritmo puede transformar completamente una composición. \n",
                    "La interpretación musical es el proceso a través del cual un músico da vida a una obra. \n\nCada intérprete aporta su propio estilo y sensibilidad, haciendo que incluso la misma"

                    };
                    break;
                default:
                    paginas = new string[0];
                    break;
            }
            NavegarPaginas(numeroModulo, paginas);
        }

        static void NavegarPaginas(int numeroModulo, string[] paginas)
        {
            int paginaActual = 0;
            bool enLectura = true;

            while (enLectura)
            {
                // mostrar encabezado
                Console.Clear();
                Console.WriteLine($"Modulo {numeroModulo}  /  Página {paginaActual + 1}\n\n\n");
                Console.WriteLine(paginas[paginaActual]);

                // mostrar pie de página
                Console.SetCursorPosition(0, 28);
                Console.WriteLine("(Utiliza las flechas izquierda y derecha para navegar el texto, presiona enter para volver al menu de teoria musical)");

                // capturar la tecla
                var tecla = Console.ReadKey().Key;

                switch (tecla)
                {
                    case ConsoleKey.RightArrow:
                        if (paginaActual < paginas.Length - 1)
                        {
                            paginaActual++;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (paginaActual > 0)
                        {
                            paginaActual--;
                        }
                        break;

                    case ConsoleKey.Enter:
                        enLectura = false;
                        TeoriaMusical(); 
                        break;
                }
            }
        }

        static void examenTM1()
        {
            Console.Clear(); 
            int correctas = 0;

            string[] preguntas = 
            {
                "1. Aristóteles definió la música como un arte imitativo de la realidad. (V/F)",
                "2. La música ha sido utilizada únicamente como entretenimiento. (V/F)",
                "3. Los compositores son responsables de dar forma a las ideas musicales. (V/F)",
                "4. La interpretación musical no requiere de habilidades técnicas. (V/F)",
                "5. Los instrumentos musicales no han evolucionado con el tiempo. (V/F)"
            };

            for (int i = 0; i < preguntas.Length; i++)
            {
                Console.Clear(); 
                Console.WriteLine(preguntas[i]);
                string respuesta;

                // validar respuesta
                while (true)
                {
                    respuesta = Console.ReadLine().ToUpper();
                    if (respuesta == "V" || respuesta == "F")
                    {
                        break; 
                    }
                    Console.WriteLine("Respuesta no válida. Por favor ingrese 'V' o 'F'.");
                }

                // se registran respuestas correctas
                if ((i == 0 && respuesta == "V") ||
                    (i == 1 && respuesta == "F") ||
                    (i == 2 && respuesta == "V") ||
                    (i == 3 && respuesta == "F") ||
                    (i == 4 && respuesta == "F"))
                {
                    correctas++;
                }
            }

            // calcular la calificación del 1 al 10
            calificacionExamen1 = (int)Math.Round((correctas / 5.0) * 10);
            Console.Clear(); 
            Console.WriteLine($"Examen completado. Su calificación es: {calificacionExamen1}/10. Presione una tecla para continuar...");
            Console.ReadKey();
            TeoriaMusical(); 
        }

        static void examenTM2()
        {
            Console.Clear(); 
            int correctas = 0;

            string[] preguntas = 
            {
                "1. Las notas son la base sobre la que se construyen melodías y armonías. (V/F)",
                "2. La escala menor es más común que la escala mayor. (V/F)",
                "3. Los acordes se forman combinando al menos tres notas. (V/F)",
                "4. La progresión de acordes no influye en la atmósfera de una composición. (V/F)",
                "5. La práctica de tocar escalas y acordes es esencial para el desarrollo técnico de un músico. (V/F)"
            };

            for (int i = 0; i < preguntas.Length; i++)
            {
                Console.Clear(); 
                Console.WriteLine(preguntas[i]);
                string respuesta;

                
                while (true)
                {
                    respuesta = Console.ReadLine().ToUpper();
                    if (respuesta == "V" || respuesta == "F")
                    {
                        break; 
                    }
                    Console.WriteLine("Respuesta no válida. Por favor ingrese 'V' o 'F'.");
                }

                
                if ((i == 0 && respuesta == "V") ||
                    (i == 1 && respuesta == "F") ||
                    (i == 2 && respuesta == "V") ||
                    (i == 3 && respuesta == "F") ||
                    (i == 4 && respuesta == "V"))
                {
                    correctas++;
                }
            }

            calificacionExamen2 = (int)Math.Round((correctas / 5.0) * 10);
            Console.Clear(); 
            Console.WriteLine($"Examen completado. Su calificación es: {calificacionExamen2}/10. Presione una tecla para continuar...");
            Console.ReadKey();
            TeoriaMusical(); 
        }

        static void examenTM3()
        {
            Console.Clear(); 
            int correctas = 0;

            string[] preguntas = 
            {
                "1. La polifonía se refiere a varias líneas melódicas independientes. (V/F)",
                "2. La forma musical describe la estructura de una composición. (V/F)",
                "3. La dinámica en música se refiere a las variaciones en el volumen de las notas. (V/F)",
                "4. La ornamentación se utiliza para simplificar una línea musical. (V/F)",
                "5. El ritmo es uno de los elementos más fundamentales de la música. (V/F)"
            };

            for (int i = 0; i < preguntas.Length; i++)
            {
                Console.Clear(); 
                Console.WriteLine(preguntas[i]);
                string respuesta;

               
                while (true)
                {
                    respuesta = Console.ReadLine().ToUpper();
                    if (respuesta == "V" || respuesta == "F")
                    {
                        break; 
                    }
                    Console.WriteLine("Respuesta no válida. Por favor ingrese 'V' o 'F'.");
                }

                
                if ((i == 0 && respuesta == "V") ||
                    (i == 1 && respuesta == "V") ||
                    (i == 2 && respuesta == "V") ||
                    (i == 3 && respuesta == "F") ||
                    (i == 4 && respuesta == "V"))
                {
                    correctas++;
                }
            }

            calificacionExamen3 = (int)Math.Round((correctas / 5.0) * 10);
            Console.Clear(); 
            Console.WriteLine($"Examen completado. Su calificación es: {calificacionExamen3}/10. Presione una tecla para continuar...");
            Console.ReadKey();
            TeoriaMusical();
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
            Console.Write(" deseas agregar un acorde o borrarlo? ");
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
            Console.WriteLine(string.Join("|", cancionBuscar.acorde));
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
                Console.WriteLine(string.Join("|", agregarAcorde.acorde));
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
                Console.WriteLine(cancionBuscar.nombre);
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