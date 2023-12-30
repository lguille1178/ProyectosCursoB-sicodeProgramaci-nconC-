// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("ingresa un numero \n 1 Comida \n 2 Bebida \n 3 Licores");

string Opcion =  Console.ReadLine();

switch (Opcion)
{
    case "1":
        Console.WriteLine("Comidaaaaaaa mmmm");
        break;
    case "2":
        Console.WriteLine("Bebidaaaaaaa mmmm");
        break;
    case "3":
        Console.WriteLine("Licoooooooor mmmm");
        break;
}
*/
// Ciclo Foor
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

// Ciclo While
//bool opcion = true;

//while (opcion)
//{
//    Console.WriteLine("Hola Continuar? 1 No, 2 Si");
//    int opcion1 = Convert.ToInt16(Console.ReadLine());
//    if (opcion1 == 1)
//    {
//        opcion = false;
//    }

//}

// Ciclo Do While
bool opcion = true;

do
{
    Console.WriteLine("Hola Continuar? 1 No, 2 Si");
    int opcion1 = Convert.ToInt16(Console.ReadLine());
    if (opcion1 == 1)
    {
        opcion = false;
    }

}while (opcion == true );

