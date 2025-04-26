public class actividad_1_Semana_15
{
    static void Main()
    {
        Console.WriteLine("Escriba el nombre: ");
        string nombreIngresado = Console.ReadLine();
        Console.WriteLine("Escriba la carrera: ");
        string carreraIngresada = Console.ReadLine();
        int carnetIngresado = 0;
        carnetIngresado = ValidacionCarnet(carnetIngresado);
        int edadIngresada = 0;
        edadIngresada = ValidacionEdad(edadIngresada);
        int notaAdmisionIngresada = 0;
        notaAdmisionIngresada = ValidacionNota(notaAdmisionIngresada);
        Estudiante objetoEstudiante = new Estudiante(nombreIngresado, carreraIngresada, edadIngresada, carnetIngresado, notaAdmisionIngresada);
        objetoEstudiante.MostrarResumen();
    }
    static int ValidacionCarnet(int carnetIngresado)
    {
        string entrada = "";
        while (true)
        {
            Console.Write("Escriba su carnet:  ");
            entrada = Console.ReadLine();
 
            if (int.TryParse(entrada, out carnetIngresado))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ingrese un carnet válido");
            }
        }
        return carnetIngresado;
    }
    static int ValidacionEdad(int edadIngresada)
    {
        string entrada = "";
        while (true)
        {
            Console.Write("Escriba su Edad:  ");
            entrada = Console.ReadLine();
 
            if (int.TryParse(entrada, out edadIngresada) && edadIngresada>=17)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ingrese una edad válida");
            }
        }
        return edadIngresada;

    }
    static int ValidacionNota(int notaAdmisionIngresada)
    {
        string entrada = "";
         while (true)
        {
            Console.Write("Escriba la nota de admision:  ");
            entrada = Console.ReadLine();
 
            if (int.TryParse(entrada, out notaAdmisionIngresada) && notaAdmisionIngresada>=0 && notaAdmisionIngresada<=100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ingrese una nota válida");
            }
        }
        return notaAdmisionIngresada;

    }
}
public class Estudiante
{
    string nombre {get; set;}
    public int edad {get; set;}
    string carrera {get; set;}
    int carnet {get; set;}
    int notaAdmision {get; set;}

    public Estudiante(string nombre_,string carrera_, int edad_, int carnet_, int notaAdmision_)
    {
        this.nombre = nombre_;
        this.edad = edad_;
        this.carnet = carnet_;
        this.notaAdmision = notaAdmision_;
        this.carrera = carrera_;
    }
    public void MostrarResumen()
    {
        bool puedeMatricular = PuedeMatricular(this.notaAdmision, this.carnet);
        Console.Clear();
        Console.ReadKey();
        Console.WriteLine("===== Resumen =====");
        Console.WriteLine("Nombre: " + this.nombre);
        Console.WriteLine("Edad: " + this.edad);
        Console.WriteLine("Carnet: " + this.carnet);
        Console.WriteLine("Nota: " + this.notaAdmision);
        Console.WriteLine("Carrera: " + this.carrera);
        if(puedeMatricular == true)
        {
            Console.WriteLine("Puede Matricularse");
        }
        else
        {
            Console.WriteLine("No puede matricularse");
        }
        Console.WriteLine("===================");

    }
    static bool PuedeMatricular(int notaAdmision_, int carnet_)
    {
        string carnet = Convert.ToString(carnet_);
        bool terminaCon = carnet.EndsWith("2025");

        if(notaAdmision_>=75 && terminaCon)
        {
            return true;

        }
        else
        {
            return false;

        }
    }

}
