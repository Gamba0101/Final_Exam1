/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.WriteLine("Please input how many words you want in your sentence: ");
int size = Convert.ToInt32(Console.ReadLine());

string [] CreateArray (int arg) {
    string[] createdArray = new string[arg];
    for (int i = 0; i < arg; i++) {
        Console.WriteLine($"Please input your {i+1} word: ");
        createdArray[i] = Convert.ToString(Console.ReadLine());
    }
    return createdArray;
}

string[] array2 = new string[size-1];

void SecondArray (string[] array1, string[] array2) {
    int count = 0;
    for (int i = 0; i < array1.Length; i++) {
        if(array1[i].Length <= 3)   {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray (string[] print_ar) {
    for (int i = 0; i < print_ar.Length; i++) {
        Console.Write(print_ar[i] + " ");
    }
}

string[] firstArray = CreateArray(size);
    Console.WriteLine("Your array sentence is: ");
PrintArray(firstArray);
Console.WriteLine(" ");
SecondArray(firstArray, array2);
Console.WriteLine("Your changed array sentence is: ");
PrintArray(array2);