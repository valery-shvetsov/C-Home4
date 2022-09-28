// Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
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

double basis = ReadData("Введите основание степени : ");
double index = ReadData("Введите показатель степени : ");
double result = Math.Pow(basis,index);
PrintData("Результат возведения в степень =",result.ToString());



