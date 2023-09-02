void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
    // void - это тип метода, соответств.подпрограмме, которая не возвращает какое-либо значение
    // т.е void - это не функция, при обращении к которой возвращается некое значение
    // однако аргументы такого метода позволяют работать с переменными в широком варианте.
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;// не совсем корректно (не "общее решение"), но пока подойдет

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // объявляем новый массив array, указав - в нем будет 10 элементов (nee int [10])

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);