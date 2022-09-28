// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
void PrintData(string prefix, string value) 
{     
    Console.WriteLine(prefix + value);
}

//main
int number = ReadData("Введите целое число: ");
int summ=0; 
while (number>=1)
{
    int a=number%10;
//    Console.WriteLine(a);
    summ=summ+a;
    number=number/10;
} 
PrintData("Сумма цифр в числе: ", summ.ToString());  