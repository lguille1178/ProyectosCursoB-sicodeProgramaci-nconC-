
//rectangle area calc.

//Console.WriteLine("Ingresa el area del rectangulo");
//float sideA = float.Parse(Console.ReadLine());


//Console.WriteLine("Ingresa el area del rectangulo");
//float sideB = float.Parse(Console.ReadLine());

//float area = sideA * sideB;

//Console.WriteLine(area);

//***********************************arrays
//string[] coffeTypes;
//float[] coffeValues;

//coffeTypes = new string[] {"Expresso", "Lago", "Americano"};
//coffeValues = new float[] { 1.2f, 2.4f, 5.0f };

//for(int i = 0; i < 3; i++)
//{
//    Console.WriteLine(coffeTypes[i] + " Coffe Prices: "+ coffeValues[i]);
//}


//**********************************LISTAS

internal class Program
{
    // este es un metodo
    public int Integrado1(int a, int b)
    {
        int suma = a + b;
        return suma;
    }
    private static void Main(string[] args)
    {
        List<string> tacoShoppingList = new List<string>();

        tacoShoppingList.Add("Cinco Taco al pastor");
        tacoShoppingList.Add("Cuatro Tacos de Tripa");
        tacoShoppingList.Add("Cinco Tacos de suadero");
        tacoShoppingList.Add("Cuatro Super coal");

        for (int i = 0; i < tacoShoppingList.Count; i++)
        {
            Console.WriteLine(tacoShoppingList[i]);
        }


        //tacoShoppingList.Remove("Cinco Tacos de suadero");
        tacoShoppingList.RemoveAt(2);

        for (int i = 0; i < tacoShoppingList.Count; i++)
        {
            Console.WriteLine(tacoShoppingList[i]);
        }

        Random rnd = new Random(); // Con el New le estamos diciendo que lo inicialice que lo vamos a usar.

        Console.WriteLine($"{rnd.Next(1, 10)}");

        string ClassTopic = "Métodos de strings";
        string School = "Platzi";
        string SchoolClone = School.Clone().ToString();
        Console.WriteLine(SchoolClone);

        // aqui usamos el meotodo.
        //inicializaos el metodo
        Program program = new Program();
        // lo utilizamos y metemos el resultado en una variable 
        int resultado = program.Integrado1(1, 2);
        // mostramos la variable.
        Console.WriteLine(resultado);

    }
}