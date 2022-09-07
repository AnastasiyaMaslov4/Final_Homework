 
 string[] stringArray;
 stringArray = new string[4];
 Console.WriteLine("Введите 4 строки:");

stringArray[0] = Console.ReadLine();
stringArray[1] = Console.ReadLine();
stringArray[2] = Console.ReadLine();
stringArray[3] = Console.ReadLine();


for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= 3) Console.Write($"{stringArray[i]}; ");
}

