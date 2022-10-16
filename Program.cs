// Задача. Написать програму, которая из имеющегося массива строк формирует массив
//  из строк, длинна которого меньше или равна 3 символа. 


string ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    string result = Console.ReadLine() ?? "";
    return result;
}

string[] GetArrayFromString(string line)
{
    string[] stringArray = line.Split(",");
    return stringArray;
}

string[] CreateArrayFromArr(string[] array)
{
    int count = 0;
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            result[count] = array[i];
            count ++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

//Печать одномерного массива
void Print1DArr(string[] arr)
{
    Console.Write("[{0}]", string.Join(", ", arr));
}

// Исполнение программы
string[] stringsArray = GetArrayFromString(ReadData("Введите массив строк разделенных запятыми:"));
Console.WriteLine();
Print1DArr(stringsArray);
Console.Write(" -> ");
Print1DArr(CreateArrayFromArr(stringsArray));