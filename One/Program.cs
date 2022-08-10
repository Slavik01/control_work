// Программа из имеющегося массива строк, формирует массив из строк, 
// длина которых меньше, либо равна 3 символа.  
// Пример: ["123", "2", "hello", "world"] => ["123", "2"]

Console.WriteLine("Введите кол-во элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[size];
string[] secondArray = new string[firstArray.Length];
for (int i = 0; i < firstArray.Length; i++) 
{
    Console.Write("Введите данные: ");
    firstArray[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", firstArray) + "]");
int count = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    secondArray[count] = firstArray[i];
    count ++;  
}
Console.WriteLine("Конечный массив: [" + string.Join(", ", secondArray) + "]");