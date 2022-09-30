//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//ввод элеменетов через консоль (через запятую. использовать 

//создаем массив 
string[] PrArray(string strArray)
{
    string[] array = strArray.Split(", ");
    return array;
}
//main
Console.WriteLine("Введите массив:");
string strArray = Console.ReadLine() ?? " ";
int arrayLength = strArray.Length;
Console.WriteLine($"В массиве {arrayLength.ToString()} элементов");
string[] array = PrArray(strArray);
for (var i = 0; i<array.Length; i++)
{
    Console.WriteLine($"{array[i]} ");
}
