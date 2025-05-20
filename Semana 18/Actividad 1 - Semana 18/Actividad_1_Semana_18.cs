using System;
class Actividad_1_Semana_18
{
    static Alumno[] alumnos = new Alumno[10];
    static void Main()
    {
        IngresarNotas();
        Menu();

    }
    static void Menu()
    {
        Console.Clear();
        string opcion;

        while (true)
        {
            Console.WriteLine("======Bienvenido al Menu======");
            Console.WriteLine("     Seleccione una opción");
            Console.WriteLine("1) Mostrar notas aprobadas");
            Console.WriteLine("2) Mostrar notas reprobadas");
            Console.WriteLine("3) Mostrar promedio de la clase");
            Console.WriteLine("4) Cerrar el programa");
            opcion = Console.ReadLine()!;
            switch (opcion)
            {
                case "1":
                Console.Clear();
                MostrarNotasAprobadas();
                Console.ReadKey();
                break;

                case "2":
                Console.Clear();
                MostrarNotasReprobadas();
                Console.ReadKey();
                break;

                case "3":
                Console.Clear();
                MostrarPromedio();
                Console.ReadKey();
                break;

                case "4":
                Console.Clear();
                Console.WriteLine("Cerrando el programa....");    
                Console.ReadKey();              
                return;

                default:
                Console.WriteLine("Ingrese una opción válida");
                break;


            }
            Console.Clear();
        }

    }
    static void IngresarNotas()
    {
        double nota;
        string nombre;
        Console.Clear();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese el nombre del Estudiante: ");
            nombre = Console.ReadLine()!;
            double[] notas = new double[10];

            for (int j = 0; j < 10; j++)
            {
                bool esValido = false;
                do
                {
                    Console.WriteLine($"Ingrese la nota {j + 1} de {nombre}:");
                    string notaIngresada = Console.ReadLine()!;
                    if (double.TryParse(notaIngresada, out nota) && nota >= 0 && nota <= 100)
                    {
                        notas[j] = nota;
                        esValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una nota válida");
                    }
                } while (!esValido);
            }
            alumnos[i] = new Alumno(nombre, notas);
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void MostrarNotasAprobadas()
    {
        foreach (var alumno in alumnos)
        {
            Console.Write($"{alumno.nombre}: ");
            var aprobadas = alumno.NotasAprobadas();
            if (aprobadas.Length == 0)
            {
                Console.Write("Sin notas aprobadas");
            }
            else
            {
                foreach (var nota in aprobadas)
                {
                    Console.Write($"{nota} ");
                }
            }
            Console.WriteLine();
        }

    }
    static void MostrarNotasReprobadas()
    {
        foreach (var alumno in alumnos)
        {
            Console.Write($"{alumno.nombre}: ");
            var reprobadas = alumno.NotasAprobadas();
            if (reprobadas.Length == 0)
            {
                Console.Write("Sin notas aprobadas");
            }
            else
            {
                foreach (var nota in reprobadas)
                {
                    Console.Write($"{nota} ");
                }
            }
            Console.WriteLine();
        }

    }
    static void MostrarPromedio()
    {
        double sumaPromedios = 0;


        foreach (var alumno in alumnos)
        {
            sumaPromedios += alumno.Promedio();
        }
        double promedioDelGrupo = sumaPromedios / alumnos.Length;
        Console.WriteLine($"Promedio general del grupo: {promedioDelGrupo}");
    }

}



