// See https://aka.ms/new-console-template for more information
/*
 1. El programa validara si el usuario es existente o no, y generar un sistema de registro.
 2. El programa dede ser capas de darle la bienvenida a usuairo existente si no edisite.
 3. El programa debe repetirse hasta que se registren las q0 personas. 
 */

using System.Formats.Asn1;

string[] userNames = new string[10] { "g", "h", "j", "s", "d", "a", "a", "s", "w", "" };
int arrayCurrentIndex = 9;
bool userType;
Console.WriteLine("Welcome to the best restauran in the world");

while (arrayCurrentIndex < 10)
{ 
    //if (arrayCurrentIndex == 10)
    //{
    //    Console.WriteLine("The Restauran is full, try again next year");
    //    Environment.Exit(0);    
    //}
    Console.WriteLine("\n \n Are you registred user? Write true, or write false to registre");
    userType = Convert.ToBoolean(Console.ReadLine());   

    if (userType == true)
    {
        Console.WriteLine("Hellow, you are a registered user, please enter your exact user name");
        string userToSearch = Console.ReadLine();
        Console.WriteLine("The user you seached is {0}", userToSearch);
        int index = Array.IndexOf(userNames, userToSearch); // en esta variable mediante un metodo se almacena lo que voy a buscar de un array.
        // Buscaremos dentro de Usernames, y lo que buscaremos es userToSearch.

        if (index == -1)
        {
            Console.WriteLine("User not found, try again or register");
        }
        else
        {
            Console.WriteLine("Welcome {0}, it is a plasure to give you food", userNames[index]);
        }
    }
    else if (userType == false)
    {
        Console.WriteLine("Please write an remember your User Nme");
        userNames[arrayCurrentIndex] = Console.ReadLine();
        Console.WriteLine("Your User Has been saved successfully \n"+
            "Your user name is> {0}", userNames[arrayCurrentIndex]);
        arrayCurrentIndex++;

    }
}
Console.WriteLine("The Restauran is full, try again next year \n These are the guests to the dinner:");
int i = 0;
foreach (string elemet in userNames)
{
    Console.WriteLine("User Number {0} and user name: {1}", i+1, userNames[i]);
    i++;
}
Environment.Exit(0);
