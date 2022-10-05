// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо
//равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При
//решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
//  Примеры:
//  ["hello", "2", "world", ":-"] -> ["2", ":-"]
//  ["Russia", "Kazan"] -> [] 

Console.Write("Введите размер массива строк: ");
int size = Convert.ToInt32(Console.ReadLine()); 
string [] array = new string [size];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива строк: ");
    string elem = Console.ReadLine().Replace(" ", "");
    if(elem != "")array[i] = elem;
    else i--;
}
Console.Write("[{0}]", string.Join(", ", array));

string [] GetElementMaxLength (string[]inpArray, int maxSymbols)
{
    int count = 0;
    int temp_i = 0;
    string [] emptyArray = new string [] { };
    for (int i = 0; i < inpArray.Length; i++) 
        {
            if (inpArray[i].Length <= maxSymbols) count++;
        }
    if (count == 0) return emptyArray;
    string [] resultArray = new string [count];
    for (int j = 0; j < inpArray.Length || temp_i < maxSymbols; j++)
    {
        if (inpArray[j].Length <= maxSymbols)
        {
            resultArray[temp_i] = inpArray[j];
            temp_i++;
        } 
    }
    return resultArray;
}
Console.WriteLine($" -> [{string.Join(", ", GetElementMaxLength(array, 3))}]");


