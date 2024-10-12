internal class Program
{
    private static void Main(string[] args)
    {
      
        int[] datos =LeerDatos();

        Console.WriteLine("Imprimiendo desde el Main");


        foreach(int i in datos)
        {


            Console.WriteLine(i);
        }

    }
     

    static int[] LeerDatos()
    {

        Console.WriteLine("¿Cuantos numeros de datos quieres que contenga el array?");

        String respuesta = Console.ReadLine();

        int numeroDeDatos = int.Parse(respuesta);

        int[]datos = new int[numeroDeDatos];

        for (int i = 0; i < numeroDeDatos; i++)
        {
            Console.WriteLine($"Introduce datos para la posicion del elemento {i}");

            respuesta = Console.ReadLine();
            int datosElementos = int.Parse(respuesta);
            datos[i] = datosElementos;

            
        }
        return datos;



    }
}